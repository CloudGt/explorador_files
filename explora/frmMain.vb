Imports Explora.mHerramientas
Imports Explora.mFicheros
Public Class frmMain
    ' ****************************************************************************
    ' ****************************************************************************
    ' **                            VARIABLES GLOBALES                          **
    ' ****************************************************************************
    ' ****************************************************************************
    ' Ruta del directorio actual en que nos encontramos.
    Private sActual As String
    ' Indica si las columnas est�n ordenadas ascendentemente (TRUE) o
    ' descendentemente (FALSE).
    Private bColumnaAsc() As Boolean = {False, False, False, False, False}
    ' Almacena los datos temporales de la operaci�n a realizar sobre un fichero
    ' o un directorio.
    Private stBuffer As Buffer

    ' ****************************************************************************
    ' * ABRIR
    ' *
    ' * Se encarga de preparar el sistema para mostrar el contenido de un
    ' * directorio y luego llama a la funci�n encargada de mostrar dicho
    ' * contenido.
    ' ****************************************************************************
    Private Sub abrir(ByVal sRuta As String)
        Dim sNueva As String
        sNueva = sRuta
        abrirDirectorio(sNueva, sActual, Me.lsVista, Me.chkOcultos.Checked)
        'Me.txtRuta.Text = sActual
        ' Obtenci�n del n�mero de objetos de la vista.
        Me.slblObjetos.Text = Me.lsVista.Items.Count.ToString
    End Sub

    ' ****************************************************************************
    ' * ABRIRSELECCION
    ' *
    ' * Permite abrir el elemento seleccionado en la lista de objetos. En el caso
    ' * de ser un directorio mostrar� su contenido, y en el caso de ser un fichero
    ' * lo abrir� con su programa asociado.
    ' ****************************************************************************
    Private Sub abrirSeleccion()
        ' Variable auxiliar en la que almacenar el elemento de la lista
        Dim lviElemento As System.Windows.Forms.ListViewItem

        ' Si hay un elemento seleccionado en la lista
        If (Me.lsVista.SelectedItems.Count > 0) Then
            ' Obtenci�n de los datos del elemento seleccionado
            lviElemento = Me.lsVista.SelectedItems(0)

            ' Si el tipo de elemento seleccionado es un directorio se procede a su
            ' apertura
            If (lviElemento.SubItems(2).Text = "Directorio") Then
                ' Apertura del directorio indicado
                abrir(lviElemento.ToolTipText)
                RutGuarda = lviElemento.ToolTipText & "\"
            Else
                ' En el caso de ser un fichero se intenta abrir con su programa
                ' asociado. Si no tiene un programa asociado o no se dispone de
                ' permisos de apertura, saltar� una excepci�n.
                Try
                    Process.Start(lviElemento.ToolTipText)
                Catch ex As Exception
                    imprimirError(ex.Message, lviElemento.ToolTipText)
                End Try
            End If
        End If
    End Sub

    ' * SUBIR
    ' *
    ' * Accede al directorio superior al actual.
    ' ****************************************************************************
    Private Sub subir()
        ' Apertura del directorio superior
        ' *-------------- ABRIR DIRECCION DE REFERENCIA
        RutGuarda = DIR_ORIGINAL
        'abrir(My.Computer.FileSystem.GetParentPath(sActual))
        abrir(DIR_ORIGINAL)
    End Sub


    ' ****************************************************************************
    ' ****************************************************************************
    ' **                                 EVENTOS                                **
    ' ****************************************************************************
    ' ****************************************************************************

    ' ****************************************************************************
    ' * CARGA DEL FORMULARIO
    ' ****************************************************************************
    ' * Operaciones a realizar al cargar el formulario de la aplicaci�n.
    ' ****************************************************************************
    Private Sub frmMain_Load(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles MyBase.Load
        Dim matriz
        matriz = My.Application.Info.DirectoryPath.Split(":")
        Call CREAR_carpetas()
        ToolStripLabel1.Text = ToolStripLabel1.Text
        'sustituir por la  unidad a abrir
        DIR_ORIGINAL = matriz(0) & ":\"
        sActual = DIR_ORIGINAL
        RutGuarda = DIR_ORIGINAL
        ' Establecimiento del t�tulo de la ventana.
        Me.Text = "Explorador de unidades " & My.Application.Info.Version.ToString
        abrir(sActual)
        ' Obtenci�n de la lista de unidades del sistema
        '*rellenarUnidades(Me.cmbUnidades)

        ' Si hay seleccionada al menos una unidad, se intentar� abrir la misma.
        ABRIR_DIRECTORIO.StartInfo.FileName = Environment.GetEnvironmentVariable("windir").ToString & "\explorer.exe"
        ABRIR_DIRECTORIO.StartInfo.Arguments = ""
    End Sub


    ' ****************************************************************************
    ' * ACTIVADORES DE APERTURA
    ' ****************************************************************************
    ' * Control de los eventos para abrir el elemento seleccionado.
    ' ****************************************************************************
    Private Sub lsVista_MouseDoubleClick(ByVal sender As System.Object, _
                              ByVal e As System.Windows.Forms.MouseEventArgs) _
                              Handles lsVista.MouseDoubleClick
        abrirSeleccion()
    End Sub

    Private Sub mnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAbrir.Click
        abrirSeleccion()
    End Sub


    ' ****************************************************************************
    ' * CONTROL DE TECLAS PULSADAS
    ' ****************************************************************************
    ' * Controla la tecla pulsada en la lista para verificar la acci�n a realizar.
    ' ****************************************************************************
    Private Sub lsVista_KeyPress(ByVal sender As System.Object, _
                              ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                              Handles lsVista.KeyPress
        ' En el caso de pulsarse la tecla Intro se procede a abrir el elemento
        ' seleccionado.
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            abrirSeleccion()
            ' En el caso de pulsar Retroceso se abre el directorio superior.
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then

        End If
    End Sub


    ' ****************************************************************************
    ' * ACTIVADORES DE ACCI�N SUBIR
    ' ****************************************************************************
    ' * El primero controla las acciones a realizar al hacer clic en el bot�n
    ' * Subir y el segundo el men� contextual Subir.
    ' ****************************************************************************
    Private Sub btnSubir_Click(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) Handles btnSubir.Click
        subir()
        Me.slblObjetos.Text = Me.lsVista.Items.Count.ToString


        Me.pnlAtributos.Visible = False
        Me.pnlVistaPrevia.Visible = False
        Me.pnlAtributosImagen.Visible = False
    End Sub
    Private Sub mncSubir_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                               Handles mnSubir.Click
        subir()
        Me.slblObjetos.Text = Me.lsVista.Items.Count.ToString

        Me.pnlAtributos.Visible = False
        Me.pnlVistaPrevia.Visible = False
        Me.pnlAtributosImagen.Visible = False

    End Sub


    ' ****************************************************************************
    ' * ACTIVADORES DE ACCI�N ACTUALIZAR
    ' ****************************************************************************
    ' * El primero controla las acciones a realizar al hacer clic en el bot�n
    ' * Subir y el segundo el men� contextual Subir.
    ' ****************************************************************************
    Private Sub btnActualizar_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) _
                                    Handles btnActualizar.Click
        'abrirDirectorio(sActual, sActual, Me.lsVista, Me.chkOcultos)
        abrir(sActual)

    End Sub
    Private Sub mncActualizar_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) _
                                    Handles mnActualizar.Click
        'abrirDirectorio(sActual, sActual, Me.lsVista, Me.chkOcultos)
        abrir(sActual)


    End Sub





    ' ****************************************************************************
    ' * CONTROL DE FICHEROS OCULTOS
    ' ****************************************************************************
    ' * Realiza las opciones necesarias para mostrar o esconder los ficheros
    ' * ocultos.
    ' ****************************************************************************
    Private Sub chkOcultos_CheckedChanged(ByVal sender As System.Object, _
                                          ByVal e As System.EventArgs) _
                                          Handles chkOcultos.CheckedChanged
        'abrirDirectorio(sActual, sActual, Me.lsVista, Me.chkOcultos)
        abrir(sActual)


        Me.mnOcultos.Checked = Me.chkOcultos.Checked
    End Sub
    Private Sub mnOcultos_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) _
                                 Handles mnOcultos.Click
        Me.chkOcultos.Checked = Not Me.chkOcultos.Checked
    End Sub


    ' ****************************************************************************
    ' * VENTANA DE AYUDA
    ' ****************************************************************************
    ' * Apertura de la ventana de ayuda.
    ' ****************************************************************************
    Private Sub mncAyuda_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                               Handles mnAyuda.Click
        My.Forms.frmInfo.ShowDialog()
    End Sub


    ' ****************************************************************************
    ' * ORDENACI�N DE ELEMENTOS
    ' ****************************************************************************
    ' * Primera implementaci�n de la ordenaci�n de elementos en la lista.
    ' ****************************************************************************
    Private Sub lsVista_ColumnClick(ByVal sender As System.Object, _
                                    ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
                                    Handles lsVista.ColumnClick
        ' Si el orden anterior no es ascendente, se pone el orden actual como
        ' ascendente y se actualiza la lista de orden. En caso contrario, se
        ' establece el orden como descendente y se pone la lista de �rdenes a
        ' FALSE.
        If Not bColumnaAsc(e.Column) Then
            indicarOrdenColumnas(bColumnaAsc, e.Column)
        Else
            indicarOrdenColumnas(bColumnaAsc)
        End If

        ' Ordenaci�n de la lista de elementos.
        Me.lsVista.ListViewItemSorter = New cComparaLista(e.Column, _
                                                   bColumnaAsc(e.Column), _
                                                   Me.lsVista.Columns(e.Column).Tag)
    End Sub
    ' ****************************************************************************
    ' * CONTROL DEL MEN� CONTEXTUAL
    ' ****************************************************************************
    ' Controla la aparici�n de la opci�n de men� Abrir al abrir el men� contextual
    ' ****************************************************************************
    Private Sub cmsMenu_Opening(ByVal sender As System.Object, _
                                ByVal e As System.ComponentModel.CancelEventArgs) _
                                Handles cmsMenu.Opening
        ' Si hay un elemento seleccionado, se activa la opci�n de men� Abrir.
        If Me.lsVista.SelectedItems.Count = 1 Then
            Me.mnAbrir.Visible = True

            ' directorio, en caso contrario, se mostrar� el icono de abrir fichero.
            If Me.lsVista.SelectedItems(0).SubItems(2).Text = "Directorio" Then
                Me.mnAbrir.Image = My.Resources.icoAbrirDir
            Else
                Me.mnAbrir.Image = My.Resources.icoAbrirDoc
            End If
        End If
    End Sub

    ' ****************************************************************************
    ' * ACTIVACI�N/DESACTIVACI�N CONTROLES CON ELEMENTOS SELECCIONADOS
    ' ****************************************************************************
    ' Activa o desactiva los controles referidos a los ficheros y directorios
    ' dependiendo de si se encuentran seleccionados o no.
    ' ****************************************************************************
    Private Sub lsVista_SelectedIndexChanged(ByVal sender As System.Object, _
                                             ByVal e As System.EventArgs) _
                                             Handles lsVista.SelectedIndexChanged
        Dim bActivar As Boolean
        ' Si hay un fichero o directorio seleccionado se controlan los botones y
        ' elementos de men�.
        If Me.lsVista.SelectedItems.Count = 1 Then
            bActivar = True

            ' Se muestran los datos del fichero o directorio seleccionado
            mostrarDatosFichero()
        Else
            bActivar = False
        End If
        ' Actualizaci�n del estado de los controles
        Me.pnlAtributos.Visible = bActivar
        Me.mnAbrir.Visible = bActivar
    End Sub


    ' ****************************************************************************
    ' ****************************************************************************
    ' MOSTRARDATOSFICHERO
    ' ****************************************************************************
    ' Muestra informaci�n sobre el fichero seleccionado.
    Private Sub mostrarDatosFichero()
        Dim imgImagen As Image
        Dim sAuxNombre As String
        Dim fiInfo As System.IO.FileInfo
        Dim diInfo As System.IO.DirectoryInfo

        If Me.lsVista.SelectedItems(0).SubItems(2).Text = "Imagen" Then
            Me.pnlVistaPrevia.Visible = True
            Me.pnlAtributosImagen.Visible = True
            Try
                imgImagen = Image.FromFile(sActual & "\" & _
                                           Me.lsVista.SelectedItems(0).SubItems(0).Text)
                Me.pcbImagen.Image = imgImagen

                Me.lblDimensiones.Text = imgImagen.Width & " x " & imgImagen.Height & _
                                         " px"
                Me.lblResolucionHorizontal.Text = imgImagen.HorizontalResolution & _
                                         " px/pulgada"
                Me.lblResolucionVertical.Text = imgImagen.VerticalResolution & _
                                         " px/pulgada"
            Catch ex As Exception
                Me.pcbImagen.Image = My.Resources.imgNoImagen
                Me.lblDimensiones.Text = "Archivo no v�lido"
                Me.lblResolucionHorizontal.Text = "-"
                Me.lblResolucionVertical.Text = "-"
            End Try
        Else
            Me.pnlVistaPrevia.Visible = False
            Me.pnlAtributosImagen.Visible = False
        End If

        sAuxNombre = Me.lsVista.SelectedItems(0).SubItems(0).Text

        If Me.lsVista.SelectedItems(0).SubItems(0).Text.Length > 35 Then
            Me.lblNombreFichero.Text = sAuxNombre.Substring(0, 32) & "..."
        Else
            Me.lblNombreFichero.Text = sAuxNombre
        End If

        If Me.lsVista.SelectedItems(0).SubItems(2).Text <> "Directorio" Then
            fiInfo = My.Computer.FileSystem.GetFileInfo(sActual & "\" & sAuxNombre)
            Me.lblFechaCreacion.Text = fiInfo.CreationTime
            Me.lblTamano.Text = fiInfo.Length & " bytes"
            Me.lblFechaAcceso.Text = fiInfo.LastAccessTime
            Me.lblEtFechaAcceso.Text = "Fecha de apertura:"
            Me.lblTamano.Visible = True
            Me.lblEtTamano.Visible = True
        Else
            diInfo = My.Computer.FileSystem.GetDirectoryInfo(sActual & "\" & sAuxNombre)
            Me.lblFechaCreacion.Text = diInfo.CreationTime
            Me.lblFechaAcceso.Text = diInfo.LastAccessTime
            Me.lblEtFechaAcceso.Text = "Fecha de acceso:"
            Me.lblTamano.Visible = False
            Me.lblEtTamano.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim DirRuta As DialogResult = OpenFileDialog1.ShowDialog()
        If DirRuta = Windows.Forms.DialogResult.OK Then
            capRuta = OpenFileDialog1.FileName
            Archivo = OpenFileDialog1.FileName
            Call CopiaArchivoConProgreso(capRuta, RutGuarda, Archivo)
        End If
    End Sub
    Sub CREAR_carpetas()
        If Not (My.Computer.FileSystem.DirectoryExists(DIR_ORIGINAL)) Then
            My.Computer.FileSystem.CreateDirectory(DIR_ORIGINAL + DVar)
        End If
    End Sub
    Sub CopiaArchivoConProgreso(ByVal path As String, ByVal path2 As String, ByVal mediafile As String)
        'path = ruta del lugar de origen, en donde se encuentra el archivo
        'path2 = ruta del lugar de destino, a donde se copiar� el archivo
        'mediafile = nombre del archivo a copiar
        Dim fi As New IO.FileInfo(mediafile)
        Dim sr As New IO.FileStream(path, IO.FileMode.Open) 'lugar de origen
        Dim sw As New IO.FileStream(path2 & fi.Name, IO.FileMode.Create) 'lugar de destino

        Dim len As Long = sr.Length - 1
        progressbar1.Visible = True
        slblAccion.Text = "Transfiriendo..."
        For i As Long = 0 To len
            sw.WriteByte(sr.ReadByte)
            If i Mod 1024 = 0 Then 'Actualiza con cada 1 kb copiado
                progressbar1.Value = i * 100 / len
                label6.Text = progressbar1.Value & "%"
                Application.DoEvents()
            End If
        Next
        Call btnActualizar.PerformClick()
        progressbar1.Visible = True
        progressbar1.Value = 0
        label6.Text = progressbar1.Value & "%"
        slblAccion.Text = "Completo."
        sr.Close()
        sw.Close()
    End Sub
    ' COPIAR
    ' Copia a memoria el nombre del fichero o directorio, e indica que la
    ' operaci�n que debe ser llevada a cabo es de copiado.
    ' ****************************************************************************
    Private Sub copiar()
        If Me.lsVista.SelectedItems.Count = 1 Then
            stBuffer.eAccion = eAcciones.copiar

            stBuffer.sRuta = sActual
            stBuffer.sFichero = Me.lsVista.SelectedItems(0).SubItems(0).Text
            Me.slblAccion.Text = "Copiar"
            If stBuffer.sRuta.Length > 3 Then
                stBuffer.sRuta = stBuffer.sRuta & "\"
            End If
            Me.slblBuffer.Text = stBuffer.sRuta & stBuffer.sFichero
            If Me.lsVista.SelectedItems(0).SubItems(2).Text = "Directorio" Then
                stBuffer.eTipo = eTipo.directorio
            Else
                stBuffer.eTipo = eTipo.fichero
            End If
        End If
    End Sub
    Sub descargas()
        If Not (My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString & "\DESCARGAS")) Then
            My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString & "\DESCARGAS\")
        End If
    End Sub

    Private Sub mnCopiar_Click(sender As Object, e As EventArgs) Handles mnCopiar.Click
        Call descargas()
        Dim lviElemento As System.Windows.Forms.ListViewItem
        Dim NNombre = Me.lsVista.SelectedItems(0).SubItems(0).Text
        lviElemento = Me.lsVista.SelectedItems(0)
        Dim nruta = lviElemento.ToolTipText
        Dim DESCARGA As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString & "\DESCARGAS\"
        Call CopiaArchivoConProgreso(nruta, DESCARGA, NNombre)
        ABRIR_DIRECTORIO.StartInfo.Arguments = DESCARGA.ToString
        ABRIR_DIRECTORIO.Start()
    End Sub

    Private Sub ttConsejo_Popup(sender As Object, e As PopupEventArgs) Handles ttConsejo.Popup

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
End Class
