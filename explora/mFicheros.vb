Module mFicheros
    Public DIR_ORIGINAL As String


  ' ****************************************************************************
  ' * ABRIRDIRECTORIO
  ' ****************************************************************************
  ' * Realiza las operaciones necesarias para abrir el directorio que recibe
  ' * como argumento.
  ' *
  ' * Parámetros:
  ' *   - sNombre: Ruta a abrir.
  ' *   - sActual: Ruta actual. Si todo va bien será actualizada.
  ' *   - lsVista: ListView a modificar donde se almacena la lista de archivos
  ' *              y directorios de la ruta actual.
  ' *   - txtRuta: 
  ' ****************************************************************************
  Sub abrirDirectorio(ByVal sNombre As String, ByRef sActual As String, _
                      ByRef lsVista As ListView, ByVal bVerOcultos As Boolean)
    ' Contador para el bucle for.
    Dim iIndice As Integer = 0
    ' Contador para indicar el tipo de fichero
    Dim iTipo As Integer = 0
    ' Control de tamaño de fichero
    Dim lTamano As Long = 0
    ' Colección de nombres de ficheros del directorio actual
    Dim sFicheros As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
    ' Variable auxiliar con los nombres "limpios" para ficheros y directorios
    Dim sAux As String = ""
    ' Variable auxiliar para guardar el tipo de fichero
    Dim sTipo As String = ""
    ' Elemento a introducir en la lista de archivos y directorios
    Dim lviElemento As System.Windows.Forms.ListViewItem
    ' Indica si un fichero es oculto (True) o no (False)
    Dim bOculto As Boolean = False
    ' Atributos de un fichero
    Dim fiAtributos As System.IO.FileInfo
    ' Atributos de un directorio
    Dim diAtributos As System.IO.DirectoryInfo

    Try
      ' ------------------------------------------------------------------------
      ' Obtención de subdirectorios
      ' ------------------------------------------------------------------------
      ' Obtención de la lista de subdirectorios del directorio indicado
      sFicheros = My.Computer.FileSystem.GetDirectories(sNombre)

      lsVista.Items.Clear()

      ' Recorrido por todos los subdirectorios
      For iIndice = 0 To sFicheros.Count - 1
        If visualizar(sFicheros(iIndice), bOculto, bVerOcultos) Then
          ' Obtención del nombre del directorio
          sAux = sFicheros(iIndice)
          sAux = sAux.Substring(sAux.LastIndexOf("\") + 1)
          diAtributos = My.Computer.FileSystem.GetDirectoryInfo(sFicheros(iIndice))

          ' Relleno de datos del subdirectorio
          If Not bOculto Then
            iTipo = TipoArchivo.directorio
          Else
            iTipo = TipoArchivo.directorio + iIncrementoOculto
          End If

          lviElemento = New System.Windows.Forms.ListViewItem(sAux, iTipo)
          lviElemento.SubItems.Add(" ")
          lviElemento.SubItems.Add("Directorio")
          lviElemento.SubItems.Add(diAtributos.LastWriteTime.ToString)
          lviElemento.ToolTipText = sFicheros(iIndice)

          'Inserción del elemento en la lista
          lsVista.Items.Add(lviElemento)
        End If
      Next

      ' ------------------------------------------------------------------------
      ' Obtención de ficheros
      ' ------------------------------------------------------------------------
      ' Obtención de los nombres de fichero del directorio
      sFicheros = My.Computer.FileSystem.GetFiles(sNombre)

      ' Recorrido por todos los ficheros
      For iIndice = 0 To sFicheros.Count - 1
        If visualizar(sFicheros(iIndice), bOculto, bVerOcultos) Then
          ' Obtención del nombre del fichero
          sAux = sFicheros(iIndice)
          sAux = sAux.Substring(sAux.LastIndexOf("\") + 1)

          ' Relleno de datos del fichero
          iTipo = comprobarTipo(sAux, sTipo, bOculto)
          lviElemento = New System.Windows.Forms.ListViewItem(sAux, iTipo)

          fiAtributos = My.Computer.FileSystem.GetFileInfo(sFicheros(iIndice))

          lviElemento.SubItems.Add(calcularTamano(fiAtributos.Length))
          lviElemento.SubItems.Add(sTipo)
          lviElemento.SubItems.Add(fiAtributos.LastWriteTime.ToString)
          lviElemento.ToolTipText = sFicheros(iIndice)
          lviElemento.SubItems.Add(obtenerAtributos(fiAtributos.Attributes))

          ' Inserción del elemento de la lista
          lsVista.Items.Add(lviElemento)
        End If
      Next

      lsVista.Refresh()

      ' Actualización del directorio actual
            sActual = sNombre

    Catch ex As Exception
      ' Captura e impresión del mensaje de error generado por la aplicación.
      imprimirError(ex.Message, sNombre)
    End Try
  End Sub



  ' ****************************************************************************
  ' * AGREGAROBJETOS
  ' ****************************************************************************
  ' * Obtención de los atributos de un fichero.
  ' ****************************************************************************
  Function agregarObjetos(ByVal sFichero As String, _
                          ByVal bVerOcultos As Boolean, ByVal bDir As Boolean) _
                          As ListViewItem
    ' Indica si un fichero es oculto (True) o no (False)
    Dim bOculto As Boolean = False
    ' Variable auxiliar con los nombres "limpios" para ficheros y directorios
    Dim sAux As String = ""
    ' Elemento a introducir en la lista de archivos y directorios
    Dim lviElemento As System.Windows.Forms.ListViewItem
    ' Atributos de un fichero
    Dim fiAtributos 'As System.IO.FileInfo
    ' Contador para indicar el tipo de fichero
    Dim iTipo As Integer
    ' Variable auxiliar para guardar el tipo de fichero
    Dim sTipo As String

    sTipo = ""

    If visualizar(sFichero, bOculto, bVerOcultos) Then
      ' Obtención del nombre del directorio
      sAux = sFichero.Substring(sFichero.LastIndexOf("\") + 1)
      fiAtributos = My.Computer.FileSystem.GetDirectoryInfo(sFichero)

      If bDir Then
        iTipo = comprobarTipo("-*dir*-", sTipo, bOculto)
      Else
        iTipo = comprobarTipo(sAux, sTipo, bOculto)
      End If

      lviElemento = New System.Windows.Forms.ListViewItem(sAux, iTipo)

      If bDir Then
        lviElemento.SubItems.Add(" ")
      Else
        lviElemento.SubItems.Add(calcularTamano(fiAtributos.Length))
      End If

      lviElemento.SubItems.Add(sTipo)
      lviElemento.SubItems.Add(fiAtributos.LastWriteTime.ToString)
      lviElemento.ToolTipText = sFichero

    Else
      lviElemento = New System.Windows.Forms.ListViewItem("")
    End If

      Return lviElemento
  End Function



  ' ****************************************************************************
  ' * CALCULARTAMANO
  ' ****************************************************************************
  ' * Obtención de los atributos de un fichero.
  ' ****************************************************************************
  Function calcularTamano(ByVal lTamano As Long) As String
    Dim sCadena As String

    ' Cálculo del tamaño dependiendo de ciertos límites
    If lTamano < 1024 Then ' Hasta 1KB
      sCadena = lTamano & " Bytes"
    ElseIf (lTamano < 1024 ^ eUnidades.MB) Then ' Hasta 1MB
      sCadena = Format(lTamano / 1024, "F") & " KB"
    ElseIf (lTamano < 1024 ^ eUnidades.GB) Then ' Hasta 1GB
      sCadena = Format(lTamano / (1024 ^ 2), "F") & " MB"
    Else ' A partir de 1 GB
      sCadena = Format(lTamano / (1024 ^ 3), "F") & " GB"
    End If

    Return sCadena
  End Function


  ' ****************************************************************************
  ' * OBTENERATRIBUTOS
  ' ****************************************************************************
  ' * Obtención de los atributos de un fichero.
  ' ****************************************************************************
  Function obtenerAtributos(ByVal faAtributos As IO.FileAttributes) As String
    Dim sAtributos As String

    sAtributos = ""

    If (faAtributos And IO.FileAttributes.Compressed) = _
                                               IO.FileAttributes.Compressed Then
      sAtributos = sAtributos & "C"
    End If
    If (faAtributos And IO.FileAttributes.Encrypted) = _
                                               IO.FileAttributes.Encrypted Then
      sAtributos = sAtributos & "E"
    End If
    If (faAtributos And IO.FileAttributes.Hidden) = _
                                               IO.FileAttributes.Hidden Then
      sAtributos = sAtributos & "O"
    End If
    If (faAtributos And IO.FileAttributes.ReadOnly) = _
                                               IO.FileAttributes.ReadOnly Then
      sAtributos = sAtributos & "L"
    End If
    If (faAtributos And IO.FileAttributes.System) = _
                                               IO.FileAttributes.System Then
      sAtributos = sAtributos & "S"
    End If
    If (faAtributos And IO.FileAttributes.Temporary) = _
                                               IO.FileAttributes.Temporary Then
      sAtributos = sAtributos & "T"
    End If

    Return sAtributos
  End Function

End Module
