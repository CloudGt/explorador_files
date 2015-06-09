Module mHerramientas

  ' Almacena los datos temporales de la operación a realizar sobre un fichero
  ' o un directorio.
  Public Structure Buffer
    Public sFichero As String
    Public sRuta As String
    Public eAccion As eAcciones
    Public eTipo As eTipo
  End Structure

  Public Enum eUnidades
    Bytes
    KB
    MB
    GB
  End Enum

  ' Enumeración que indica los tipos de acciones a realizar sobre los
  ' directorios y ficheros.
  Public Enum eAcciones
    vacio        ' Indica que no hay acción a realizar.
    cortar       ' Indica que la operación pendiente es cortar.
    copiar       ' Indica que la operación pendiente es copiar.
  End Enum

  ' Enumeración que indica el tipo de elemento seleccionado.
  Public Enum eTipo
    directorio   ' El elemento es un directorio.
    fichero      ' El elemento es un fichero.
  End Enum

  ' Enumeración con los iconos de cada tipo de archivo
  Public Enum TipoArchivo
    directorio = 0
    texto
    doc
    documento
    pdf
    imagen
    audio
    html
    comprimido
    aplicacion
    script
    libreria
    video
    php
    enlace
    c
    cmm
    instalador
    css
    xml
    basedatos
    excel
    powerpoint
    h
    java
    fichero
  End Enum

  Public Const iIncrementoOculto As Integer = TipoArchivo.fichero + 1
  Public iObjetos() As Integer = {0, 0}

  ' ****************************************************************************
  ' * IMPRIMIRERROR
  ' ****************************************************************************
  ' * Recibe el mensaje de error generado por Visual Basic e imprime un mensaje
  ' * de error personalziado.
  ' ****************************************************************************
  Sub imprimirError(ByVal sMensaje As String, ByVal sDir As String)
    ' Dependiendo del tipo de mensaje original, se personaliza el mensaje de
    ' error mostrado al usuario.

    ' Error de apertura
    If sMensaje.Contains("No se puede encontrar una parte de la ruta de acceso") _
       Or sMensaje.Contains("El nombre del directorio no es válido") Then
      Try
        Process.Start(sDir)
      Catch ex As Exception
                MessageBox.Show("El directorio " & Chr(34) & sDir & Chr(34) & _
                                " no existe.", "Fallo al abrir directorio", _
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End
            End Try

      ' Error de acceso
    ElseIf sMensaje.Contains("Acceso denegado a la ruta de acceso") Then
            MessageBox.Show("No tienes permisos para acceder al directorio" & _
                            vbNewLine & Chr(34) & sDir & Chr(34), _
                            "Sin permisos de lectura", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
            End

      ' Error de acceso a unidad
    ElseIf sMensaje.Contains("El dispositivo no está listo") Then
            MessageBox.Show("No hay un disco en la unidad " & Chr(34) & sDir & _
                            Chr(34) & " o no tienes " & vbNewLine & _
                            "permisos para acceder a ella", _
                            "Error de acceso a unidad", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
            End


      ' Error al abrir el fichero
    ElseIf sMensaje.Contains("No hay ninguna aplicación asociada con el archivo") Then
      MessageBox.Show("Los ficheros de tipo " & sDir.Substring(sDir.LastIndexOf(".")) & _
                      " no tienen ningún programa asociado.", _
                      "Error al abrir", MessageBoxButtons.OK, _
                      MessageBoxIcon.Warning)

      ' Error genérico no controlado
    Else
            MessageBox.Show(sMensaje, "Error al abrir el directorio", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End
    End If
  End Sub


  ' ****************************************************************************
  ' * VISUALIZAR
  ' ****************************************************************************
  ' * Indica si se debe mostrar u ocultar el fichero que recibe como
  ' * argumento.
  ' ****************************************************************************
  Function visualizar(ByVal sFichero As String, ByRef bOculto As Byte, _
                      ByVal bMarcado As Boolean)
    ' Indica si el fichero se muestra (TRUE) o no (FALSE)
    Dim bVisualizar As Boolean
    ' Conjunto de atributos del fichero
    Dim faAtributo As System.IO.FileAttributes

    bVisualizar = True
    faAtributo = My.Computer.FileSystem.GetFileInfo(sFichero).Attributes

    ' Si el atributo es de sistema y la casilla correspondiente no está
    ' seleccionada, se oculta el fichero
    If ((faAtributo And IO.FileAttributes.Hidden) > 0) Then
      bOculto = 1
      If Not bMarcado Then
        bVisualizar = False
      End If
    Else
      bOculto = 0
    End If

    Return bVisualizar
  End Function


  ' ****************************************************************************
  ' * COMPROBARTIPO
  ' ****************************************************************************
  ' * Recibe un nombre de fichero, obtiene su extensión y cambia el icono de
  ' * tipo de archivo.
  ' ****************************************************************************
  Function comprobarTipo(ByVal sNombre As String, ByRef sTipo As String, _
                         ByVal bOculto As Boolean) As Integer
    ' Indica el tipo de fichero recibido
    Dim iTipo As Integer = 0
    Dim byOculto As Byte

    If bOculto Then
      byOculto = 1
    Else
      byOculto = 0
    End If

    ' Obtención de la extensión del archivo
    sNombre = sNombre.Substring(sNombre.LastIndexOf(".") + 1)
    sNombre = sNombre.ToLower

    ' Comparación con los distintos tipos de fichero
    If sNombre = "-*dir*-" Then
      iTipo = TipoArchivo.directorio + byOculto * iIncrementoOculto
      sTipo = "Directorio"
    ElseIf sNombre = "log" Or sNombre = "txt" Then
      iTipo = TipoArchivo.texto + byOculto * iIncrementoOculto
      sTipo = "Fichero de texto"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "docx" Or sNombre = "doc" Then
      iTipo = TipoArchivo.doc + byOculto * iIncrementoOculto
      sTipo = "Documento Word"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "odt" Or sNombre = "rtf" Then
      iTipo = TipoArchivo.documento + byOculto * iIncrementoOculto
      sTipo = "Documento"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "pdf" Then
      iTipo = TipoArchivo.pdf + byOculto * iIncrementoOculto
      sTipo = "Documento PDF"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "bmp" Or sNombre = "gif" Or sNombre = "jpe" Or _
           sNombre = "jpeg" Or sNombre = "jpg" Or sNombre = "png" Or _
           sNombre = "raw" Or sNombre = "tif" Or sNombre = "tiff" Then
      iTipo = TipoArchivo.imagen + byOculto * iIncrementoOculto
      sTipo = "Imagen"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "aac" Or sNombre = "mid" Or sNombre = "midi" Or _
          sNombre = "mp3" Or sNombre = "ogg" Or sNombre = "wav" Or _
          sNombre = "wma" Then
      iTipo = TipoArchivo.audio + byOculto * iIncrementoOculto
      sTipo = "Fichero de audio"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "htm" Or sNombre = "html" Or sNombre = "xhtml" Then
      iTipo = TipoArchivo.html + byOculto * iIncrementoOculto
      sTipo = "Página web"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "ace" Or sNombre = "arc" Or sNombre = "arj" Or _
           sNombre = "bza" Or sNombre = "bz2" Or sNombre = "cab" Or _
           sNombre = "pak" Or sNombre = "rar" Or sNombre = "tar" Or _
           sNombre = "zip" Or sNombre = "7z" Then
      iTipo = TipoArchivo.comprimido + byOculto * iIncrementoOculto
      sTipo = "Fichero comprimido"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "com" Or sNombre = "exe" Then
      iTipo = TipoArchivo.aplicacion + byOculto * iIncrementoOculto
      sTipo = "Aplicación"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "bat" Or sNombre = "js" Or sNombre = "jse" Or _
           sNombre = "vbe" Or sNombre = "vbs" Or sNombre = "wsc" Or _
           sNombre = "wsh" Then
      iTipo = TipoArchivo.script + byOculto * iIncrementoOculto
      sTipo = "Script"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "dll" Or sNombre = "386" Then
      iTipo = TipoArchivo.libreria + byOculto * iIncrementoOculto
      sTipo = "Librería"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "avi" Or sNombre = "mpe" Or sNombre = "mpeg" Or _
           sNombre = "mpg" Or sNombre = "mp4" Or sNombre = "wmv" Then
      iTipo = TipoArchivo.video + byOculto * iIncrementoOculto
      sTipo = "Fichero de vídeo"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "php" Then
      iTipo = TipoArchivo.php + byOculto * iIncrementoOculto
      sTipo = "Página PHP"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "lnk" Then
      iTipo = TipoArchivo.enlace + byOculto * iIncrementoOculto
      sTipo = "Enlace"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "c" Then
      iTipo = TipoArchivo.c + byOculto * iIncrementoOculto
      sTipo = "Código C"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "cpp" Then
      iTipo = TipoArchivo.cmm + byOculto * iIncrementoOculto
      sTipo = "Código C++"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "msi" Then
      iTipo = TipoArchivo.instalador + byOculto * iIncrementoOculto
      sTipo = "Instalador"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "css" Then
      iTipo = TipoArchivo.css + byOculto * iIncrementoOculto
      sTipo = "Hoja de estilo CSS"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "xml" Then
      iTipo = TipoArchivo.xml + byOculto * iIncrementoOculto
      sTipo = "Documento XML"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "dbf" Or sNombre = "mdb" Then
      iTipo = TipoArchivo.basedatos + byOculto * iIncrementoOculto
      sTipo = "Base de Datos"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "xls" Or sNombre = "xlsx" Or sNombre = "xlsb" Or _
           sNombre = "xlsm" Or sNombre = "xlt" Or sNombre = "xltx" Or _
           sNombre = "xltm" Or sNombre = "xlw" Then
      iTipo = TipoArchivo.excel + byOculto * iIncrementoOculto
      sTipo = "Documento Excel"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "pot" Or sNombre = "potm" Or sNombre = "potx" Or _
           sNombre = "pps" Or sNombre = "ppsx" Or sNombre = "ppsm" Or _
           sNombre = "ppt" Or sNombre = "pptm" Or sNombre = "pptx" Then
      iTipo = TipoArchivo.powerpoint + byOculto * iIncrementoOculto
      sTipo = "Presentación PowerPoint"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "h" Then
      iTipo = TipoArchivo.h + byOculto * iIncrementoOculto
      sTipo = "Librería c/c++"
      ' ------------------------------------------------------------------------
    ElseIf sNombre = "java" Then
      iTipo = TipoArchivo.java + byOculto * iIncrementoOculto
      sTipo = "Código Java"
      ' ------------------------------------------------------------------------
    Else
      iTipo = TipoArchivo.fichero + byOculto * iIncrementoOculto
      sTipo = "Fichero"
    End If

    If bOculto Then
      iObjetos(1) = iObjetos(1) + 1
    Else
      iObjetos(0) = iObjetos(0) + 1
    End If

    Return iTipo
  End Function


  Public Sub indicarOrdenColumnas(ByRef bLista() As Boolean, _
                                  Optional ByVal iIndice As Integer = -1)
    Dim i As Integer

    For i = 0 To bLista.Length - 1
      If i = iIndice Then
        bLista(i) = True
      Else
        bLista(i) = False
      End If
    Next
  End Sub

  Public Function convertirTamano(ByVal dTamano As Double, _
                                  ByVal eOrigen As eUnidades, _
                                  ByVal eDestino As eUnidades) As Double
    Return dTamano * 1024 ^ (eOrigen - eDestino)
  End Function


End Module
