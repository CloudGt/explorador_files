<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ilImagen1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.lsVista = New System.Windows.Forms.ListView()
        Me.cNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTamano = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cAtributos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssSeparadorContextual2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnSubir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnOcultos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssEstado = New System.Windows.Forms.StatusStrip()
        Me.slblEtObjetos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblObjetos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblEtBuffer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblBuffer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblEtAccion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblAccion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progressbar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.label6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssSeparador01 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnSubir = New System.Windows.Forms.ToolStripButton()
        Me.chkOcultos = New System.Windows.Forms.ToolStripButton()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador04 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tssSeparador05 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.pnlAtributos = New System.Windows.Forms.Panel()
        Me.pnlAtributosDesc = New System.Windows.Forms.Panel()
        Me.pnlAtributosImagen = New System.Windows.Forms.Panel()
        Me.lblEtDimensiones = New System.Windows.Forms.Label()
        Me.lblDimensiones = New System.Windows.Forms.Label()
        Me.lblResolucionVertical = New System.Windows.Forms.Label()
        Me.lblEtResolucionHorizontal = New System.Windows.Forms.Label()
        Me.lblResolucionHorizontal = New System.Windows.Forms.Label()
        Me.lblEtResolucionVertical = New System.Windows.Forms.Label()
        Me.lblNombreFichero = New System.Windows.Forms.Label()
        Me.lblEtFechaCreacion = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.lblEtFechaAcceso = New System.Windows.Forms.Label()
        Me.lblFechaAcceso = New System.Windows.Forms.Label()
        Me.lblEtTamano = New System.Windows.Forms.Label()
        Me.lblTamano = New System.Windows.Forms.Label()
        Me.pnlVistaPrevia = New System.Windows.Forms.Panel()
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.prc_sesion_servidor = New System.Diagnostics.Process()
        Me.ABRIR_DIRECTORIO = New System.Diagnostics.Process()
        Me.cmsMenu.SuspendLayout()
        Me.ssEstado.SuspendLayout()
        Me.tsHerramientas.SuspendLayout()
        Me.pnlAtributos.SuspendLayout()
        Me.pnlAtributosDesc.SuspendLayout()
        Me.pnlAtributosImagen.SuspendLayout()
        Me.pnlVistaPrevia.SuspendLayout()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ilImagen1
        '
        Me.ilImagen1.ImageStream = CType(resources.GetObject("ilImagen1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilImagen1.TransparentColor = System.Drawing.Color.Transparent
        Me.ilImagen1.Images.SetKeyName(0, "directorio.png")
        Me.ilImagen1.Images.SetKeyName(1, "texto.png")
        Me.ilImagen1.Images.SetKeyName(2, "doc.png")
        Me.ilImagen1.Images.SetKeyName(3, "documento.png")
        Me.ilImagen1.Images.SetKeyName(4, "pdf.png")
        Me.ilImagen1.Images.SetKeyName(5, "imagen.png")
        Me.ilImagen1.Images.SetKeyName(6, "audio.png")
        Me.ilImagen1.Images.SetKeyName(7, "html.png")
        Me.ilImagen1.Images.SetKeyName(8, "comprimido.png")
        Me.ilImagen1.Images.SetKeyName(9, "aplicacion.png")
        Me.ilImagen1.Images.SetKeyName(10, "script.png")
        Me.ilImagen1.Images.SetKeyName(11, "dll.png")
        Me.ilImagen1.Images.SetKeyName(12, "video.png")
        Me.ilImagen1.Images.SetKeyName(13, "php.png")
        Me.ilImagen1.Images.SetKeyName(14, "enlace.png")
        Me.ilImagen1.Images.SetKeyName(15, "c.png")
        Me.ilImagen1.Images.SetKeyName(16, "cmm.png")
        Me.ilImagen1.Images.SetKeyName(17, "instalador.png")
        Me.ilImagen1.Images.SetKeyName(18, "css.png")
        Me.ilImagen1.Images.SetKeyName(19, "xml.png")
        Me.ilImagen1.Images.SetKeyName(20, "basedatos.png")
        Me.ilImagen1.Images.SetKeyName(21, "excel.png")
        Me.ilImagen1.Images.SetKeyName(22, "powerpoint.png")
        Me.ilImagen1.Images.SetKeyName(23, "h.png")
        Me.ilImagen1.Images.SetKeyName(24, "java.png")
        Me.ilImagen1.Images.SetKeyName(25, "fichero.png")
        Me.ilImagen1.Images.SetKeyName(26, "odirectorio.png")
        Me.ilImagen1.Images.SetKeyName(27, "otexto.png")
        Me.ilImagen1.Images.SetKeyName(28, "odoc.png")
        Me.ilImagen1.Images.SetKeyName(29, "odocumento.png")
        Me.ilImagen1.Images.SetKeyName(30, "opdf.png")
        Me.ilImagen1.Images.SetKeyName(31, "oimagen.png")
        Me.ilImagen1.Images.SetKeyName(32, "oaudio.png")
        Me.ilImagen1.Images.SetKeyName(33, "ohtml.png")
        Me.ilImagen1.Images.SetKeyName(34, "ocomprimido.png")
        Me.ilImagen1.Images.SetKeyName(35, "oaplicacion.png")
        Me.ilImagen1.Images.SetKeyName(36, "oscript.png")
        Me.ilImagen1.Images.SetKeyName(37, "odll.png")
        Me.ilImagen1.Images.SetKeyName(38, "ovideo.png")
        Me.ilImagen1.Images.SetKeyName(39, "ophp.png")
        Me.ilImagen1.Images.SetKeyName(40, "oenlace.png")
        Me.ilImagen1.Images.SetKeyName(41, "oc.png")
        Me.ilImagen1.Images.SetKeyName(42, "ocmm.png")
        Me.ilImagen1.Images.SetKeyName(43, "oinstalador.png")
        Me.ilImagen1.Images.SetKeyName(44, "ocss.png")
        Me.ilImagen1.Images.SetKeyName(45, "oxml.png")
        Me.ilImagen1.Images.SetKeyName(46, "obasedatos.png")
        Me.ilImagen1.Images.SetKeyName(47, "oexcel.png")
        Me.ilImagen1.Images.SetKeyName(48, "opowerpoint.png")
        Me.ilImagen1.Images.SetKeyName(49, "oh.png")
        Me.ilImagen1.Images.SetKeyName(50, "ojava.png")
        Me.ilImagen1.Images.SetKeyName(51, "ofichero.png")
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lsVista
        '
        Me.lsVista.AllowColumnReorder = True
        Me.lsVista.AutoArrange = False
        Me.lsVista.BackColor = System.Drawing.Color.White
        Me.lsVista.BackgroundImageTiled = True
        Me.lsVista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cNombre, Me.cTamano, Me.cTipo, Me.cFecha, Me.cAtributos})
        Me.lsVista.ContextMenuStrip = Me.cmsMenu
        Me.lsVista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsVista.FullRowSelect = True
        Me.lsVista.Location = New System.Drawing.Point(0, 40)
        Me.lsVista.Margin = New System.Windows.Forms.Padding(4)
        Me.lsVista.MultiSelect = False
        Me.lsVista.Name = "lsVista"
        Me.lsVista.ShowItemToolTips = True
        Me.lsVista.Size = New System.Drawing.Size(736, 474)
        Me.lsVista.SmallImageList = Me.ilImagen1
        Me.lsVista.TabIndex = 0
        Me.lsVista.UseCompatibleStateImageBehavior = False
        Me.lsVista.View = System.Windows.Forms.View.Details
        '
        'cNombre
        '
        Me.cNombre.Tag = "cadena"
        Me.cNombre.Text = "Nombre"
        Me.cNombre.Width = 200
        '
        'cTamano
        '
        Me.cTamano.Tag = "espacio"
        Me.cTamano.Text = "Tamaño"
        Me.cTamano.Width = 120
        '
        'cTipo
        '
        Me.cTipo.Tag = "cadena"
        Me.cTipo.Text = "Tipo"
        Me.cTipo.Width = 150
        '
        'cFecha
        '
        Me.cFecha.Tag = "fecha"
        Me.cFecha.Text = "Fecha de modificación"
        Me.cFecha.Width = 160
        '
        'cAtributos
        '
        Me.cAtributos.Tag = "atributo"
        Me.cAtributos.Text = "Atributos"
        Me.cAtributos.Width = 80
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAbrir, Me.tssSeparadorContextual2, Me.mnSubir, Me.mnCopiar, Me.ToolStripSeparator2, Me.mnActualizar, Me.mnOcultos, Me.ToolStripSeparator3, Me.mnAyuda})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(214, 154)
        '
        'mnAbrir
        '
        Me.mnAbrir.Image = CType(resources.GetObject("mnAbrir.Image"), System.Drawing.Image)
        Me.mnAbrir.Name = "mnAbrir"
        Me.mnAbrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnAbrir.Size = New System.Drawing.Size(213, 22)
        Me.mnAbrir.Text = "&Abrir"
        Me.mnAbrir.Visible = False
        '
        'tssSeparadorContextual2
        '
        Me.tssSeparadorContextual2.Name = "tssSeparadorContextual2"
        Me.tssSeparadorContextual2.Size = New System.Drawing.Size(210, 6)
        '
        'mnSubir
        '
        Me.mnSubir.Image = CType(resources.GetObject("mnSubir.Image"), System.Drawing.Image)
        Me.mnSubir.Name = "mnSubir"
        Me.mnSubir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.mnSubir.Size = New System.Drawing.Size(213, 22)
        Me.mnSubir.Text = "I&R A REFERENCIA"
        '
        'mnCopiar
        '
        Me.mnCopiar.Image = Global.Explora.My.Resources.Resources.btnCopiarB
        Me.mnCopiar.Name = "mnCopiar"
        Me.mnCopiar.Size = New System.Drawing.Size(213, 22)
        Me.mnCopiar.Text = "&Descargar Archivo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'mnActualizar
        '
        Me.mnActualizar.Image = CType(resources.GetObject("mnActualizar.Image"), System.Drawing.Image)
        Me.mnActualizar.Name = "mnActualizar"
        Me.mnActualizar.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnActualizar.Size = New System.Drawing.Size(213, 22)
        Me.mnActualizar.Text = "Ac&tualizar"
        '
        'mnOcultos
        '
        Me.mnOcultos.CheckOnClick = True
        Me.mnOcultos.Image = CType(resources.GetObject("mnOcultos.Image"), System.Drawing.Image)
        Me.mnOcultos.Name = "mnOcultos"
        Me.mnOcultos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnOcultos.Size = New System.Drawing.Size(213, 22)
        Me.mnOcultos.Text = "Ficheros &ocultos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(210, 6)
        '
        'mnAyuda
        '
        Me.mnAyuda.Image = CType(resources.GetObject("mnAyuda.Image"), System.Drawing.Image)
        Me.mnAyuda.Name = "mnAyuda"
        Me.mnAyuda.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnAyuda.Size = New System.Drawing.Size(213, 22)
        Me.mnAyuda.Text = "A&yuda"
        '
        'ssEstado
        '
        Me.ssEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblEtObjetos, Me.slblObjetos, Me.slblEtBuffer, Me.slblBuffer, Me.slblEtAccion, Me.slblAccion, Me.progressbar1, Me.label6})
        Me.ssEstado.Location = New System.Drawing.Point(0, 595)
        Me.ssEstado.Name = "ssEstado"
        Me.ssEstado.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ssEstado.Size = New System.Drawing.Size(736, 25)
        Me.ssEstado.SizingGrip = False
        Me.ssEstado.TabIndex = 10
        '
        'slblEtObjetos
        '
        Me.slblEtObjetos.BackColor = System.Drawing.SystemColors.Control
        Me.slblEtObjetos.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblEtObjetos.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.slblEtObjetos.Margin = New System.Windows.Forms.Padding(0, 3, -1, 2)
        Me.slblEtObjetos.Name = "slblEtObjetos"
        Me.slblEtObjetos.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.slblEtObjetos.Size = New System.Drawing.Size(58, 20)
        Me.slblEtObjetos.Text = "Objetos: "
        '
        'slblObjetos
        '
        Me.slblObjetos.BackColor = System.Drawing.SystemColors.Control
        Me.slblObjetos.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblObjetos.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.slblObjetos.Name = "slblObjetos"
        Me.slblObjetos.Padding = New System.Windows.Forms.Padding(0, 0, 10, 1)
        Me.slblObjetos.Size = New System.Drawing.Size(14, 20)
        '
        'slblEtBuffer
        '
        Me.slblEtBuffer.BackColor = System.Drawing.SystemColors.Control
        Me.slblEtBuffer.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblEtBuffer.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.slblEtBuffer.Margin = New System.Windows.Forms.Padding(0, 3, -1, 2)
        Me.slblEtBuffer.Name = "slblEtBuffer"
        Me.slblEtBuffer.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.slblEtBuffer.Size = New System.Drawing.Size(46, 20)
        Me.slblEtBuffer.Text = "Buffer:"
        '
        'slblBuffer
        '
        Me.slblBuffer.BackColor = System.Drawing.SystemColors.Control
        Me.slblBuffer.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblBuffer.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.slblBuffer.Name = "slblBuffer"
        Me.slblBuffer.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.slblBuffer.Size = New System.Drawing.Size(14, 20)
        '
        'slblEtAccion
        '
        Me.slblEtAccion.BackColor = System.Drawing.SystemColors.Control
        Me.slblEtAccion.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblEtAccion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.slblEtAccion.Margin = New System.Windows.Forms.Padding(0, 3, -1, 2)
        Me.slblEtAccion.Name = "slblEtAccion"
        Me.slblEtAccion.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.slblEtAccion.Size = New System.Drawing.Size(51, 20)
        Me.slblEtAccion.Text = "Acción:"
        '
        'slblAccion
        '
        Me.slblAccion.BackColor = System.Drawing.SystemColors.Control
        Me.slblAccion.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblAccion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.slblAccion.Name = "slblAccion"
        Me.slblAccion.Padding = New System.Windows.Forms.Padding(0, 0, 10, 1)
        Me.slblAccion.Size = New System.Drawing.Size(14, 20)
        '
        'progressbar1
        '
        Me.progressbar1.Name = "progressbar1"
        Me.progressbar1.Size = New System.Drawing.Size(100, 19)
        '
        'label6
        '
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(26, 20)
        Me.label6.Text = "0 %"
        '
        'tssSeparador01
        '
        Me.tssSeparador01.Name = "tssSeparador01"
        Me.tssSeparador01.Size = New System.Drawing.Size(6, 40)
        '
        'tsHerramientas
        '
        Me.tsHerramientas.AutoSize = False
        Me.tsHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSubir, Me.tssSeparador01, Me.chkOcultos, Me.btnActualizar, Me.tssSeparador04, Me.ToolStripLabel1, Me.tssSeparador05, Me.ToolStripButton2})
        Me.tsHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.tsHerramientas.Name = "tsHerramientas"
        Me.tsHerramientas.Padding = New System.Windows.Forms.Padding(7, 0, 1, 0)
        Me.tsHerramientas.Size = New System.Drawing.Size(736, 40)
        Me.tsHerramientas.Stretch = True
        Me.tsHerramientas.TabIndex = 12
        '
        'btnSubir
        '
        Me.btnSubir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSubir.Image = CType(resources.GetObject("btnSubir.Image"), System.Drawing.Image)
        Me.btnSubir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSubir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(36, 37)
        Me.btnSubir.Text = "&Regresar a referencia"
        '
        'chkOcultos
        '
        Me.chkOcultos.CheckOnClick = True
        Me.chkOcultos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.chkOcultos.Image = CType(resources.GetObject("chkOcultos.Image"), System.Drawing.Image)
        Me.chkOcultos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.chkOcultos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.chkOcultos.Name = "chkOcultos"
        Me.chkOcultos.Size = New System.Drawing.Size(36, 37)
        Me.chkOcultos.Text = "Mostrar &ocultos (Ctrl + O)"
        '
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnActualizar.Image = Global.Explora.My.Resources.Resources.btnActualizarB
        Me.btnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(36, 37)
        Me.btnActualizar.Text = "&Actualizar (F5)"
        '
        'tssSeparador04
        '
        Me.tssSeparador04.Name = "tssSeparador04"
        Me.tssSeparador04.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(160, 37)
        Me.ToolStripLabel1.Text = "Referencia:"
        '
        'tssSeparador05
        '
        Me.tssSeparador05.Name = "tssSeparador05"
        Me.tssSeparador05.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Explora.My.Resources.Resources.agregar32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 37)
        Me.ToolStripButton2.Text = "A&gregar Documentos "
        '
        'pnlAtributos
        '
        Me.pnlAtributos.Controls.Add(Me.pnlAtributosDesc)
        Me.pnlAtributos.Controls.Add(Me.pnlVistaPrevia)
        Me.pnlAtributos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAtributos.Location = New System.Drawing.Point(0, 514)
        Me.pnlAtributos.Name = "pnlAtributos"
        Me.pnlAtributos.Size = New System.Drawing.Size(736, 81)
        Me.pnlAtributos.TabIndex = 14
        Me.pnlAtributos.Visible = False
        '
        'pnlAtributosDesc
        '
        Me.pnlAtributosDesc.Controls.Add(Me.pnlAtributosImagen)
        Me.pnlAtributosDesc.Controls.Add(Me.lblNombreFichero)
        Me.pnlAtributosDesc.Controls.Add(Me.lblEtFechaCreacion)
        Me.pnlAtributosDesc.Controls.Add(Me.lblFechaCreacion)
        Me.pnlAtributosDesc.Controls.Add(Me.lblEtFechaAcceso)
        Me.pnlAtributosDesc.Controls.Add(Me.lblFechaAcceso)
        Me.pnlAtributosDesc.Controls.Add(Me.lblEtTamano)
        Me.pnlAtributosDesc.Controls.Add(Me.lblTamano)
        Me.pnlAtributosDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAtributosDesc.Location = New System.Drawing.Point(122, 0)
        Me.pnlAtributosDesc.Name = "pnlAtributosDesc"
        Me.pnlAtributosDesc.Size = New System.Drawing.Size(614, 81)
        Me.pnlAtributosDesc.TabIndex = 17
        '
        'pnlAtributosImagen
        '
        Me.pnlAtributosImagen.Controls.Add(Me.lblEtDimensiones)
        Me.pnlAtributosImagen.Controls.Add(Me.lblDimensiones)
        Me.pnlAtributosImagen.Controls.Add(Me.lblResolucionVertical)
        Me.pnlAtributosImagen.Controls.Add(Me.lblEtResolucionHorizontal)
        Me.pnlAtributosImagen.Controls.Add(Me.lblResolucionHorizontal)
        Me.pnlAtributosImagen.Controls.Add(Me.lblEtResolucionVertical)
        Me.pnlAtributosImagen.Location = New System.Drawing.Point(297, 3)
        Me.pnlAtributosImagen.Name = "pnlAtributosImagen"
        Me.pnlAtributosImagen.Size = New System.Drawing.Size(287, 75)
        Me.pnlAtributosImagen.TabIndex = 16
        Me.pnlAtributosImagen.Visible = False
        '
        'lblEtDimensiones
        '
        Me.lblEtDimensiones.AutoSize = True
        Me.lblEtDimensiones.Location = New System.Drawing.Point(3, 20)
        Me.lblEtDimensiones.Name = "lblEtDimensiones"
        Me.lblEtDimensiones.Size = New System.Drawing.Size(93, 16)
        Me.lblEtDimensiones.TabIndex = 10
        Me.lblEtDimensiones.Text = "Dimensiones: "
        '
        'lblDimensiones
        '
        Me.lblDimensiones.AutoSize = True
        Me.lblDimensiones.Location = New System.Drawing.Point(143, 20)
        Me.lblDimensiones.Name = "lblDimensiones"
        Me.lblDimensiones.Size = New System.Drawing.Size(12, 16)
        Me.lblDimensiones.TabIndex = 11
        Me.lblDimensiones.Text = "-"
        '
        'lblResolucionVertical
        '
        Me.lblResolucionVertical.AutoSize = True
        Me.lblResolucionVertical.Location = New System.Drawing.Point(143, 57)
        Me.lblResolucionVertical.Name = "lblResolucionVertical"
        Me.lblResolucionVertical.Size = New System.Drawing.Size(12, 16)
        Me.lblResolucionVertical.TabIndex = 15
        Me.lblResolucionVertical.Text = "-"
        '
        'lblEtResolucionHorizontal
        '
        Me.lblEtResolucionHorizontal.AutoSize = True
        Me.lblEtResolucionHorizontal.Location = New System.Drawing.Point(3, 39)
        Me.lblEtResolucionHorizontal.Name = "lblEtResolucionHorizontal"
        Me.lblEtResolucionHorizontal.Size = New System.Drawing.Size(142, 16)
        Me.lblEtResolucionHorizontal.TabIndex = 12
        Me.lblEtResolucionHorizontal.Text = "Resolución horizontal: "
        '
        'lblResolucionHorizontal
        '
        Me.lblResolucionHorizontal.AutoSize = True
        Me.lblResolucionHorizontal.Location = New System.Drawing.Point(143, 39)
        Me.lblResolucionHorizontal.Name = "lblResolucionHorizontal"
        Me.lblResolucionHorizontal.Size = New System.Drawing.Size(12, 16)
        Me.lblResolucionHorizontal.TabIndex = 13
        Me.lblResolucionHorizontal.Text = "-"
        '
        'lblEtResolucionVertical
        '
        Me.lblEtResolucionVertical.AutoSize = True
        Me.lblEtResolucionVertical.Location = New System.Drawing.Point(3, 57)
        Me.lblEtResolucionVertical.Name = "lblEtResolucionVertical"
        Me.lblEtResolucionVertical.Size = New System.Drawing.Size(125, 16)
        Me.lblEtResolucionVertical.TabIndex = 14
        Me.lblEtResolucionVertical.Text = "Resolución vertical:"
        '
        'lblNombreFichero
        '
        Me.lblNombreFichero.AutoSize = True
        Me.lblNombreFichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreFichero.Location = New System.Drawing.Point(3, 4)
        Me.lblNombreFichero.Name = "lblNombreFichero"
        Me.lblNombreFichero.Size = New System.Drawing.Size(288, 16)
        Me.lblNombreFichero.TabIndex = 2
        Me.lblNombreFichero.Text = "12345678901234567890123456789012345"
        '
        'lblEtFechaCreacion
        '
        Me.lblEtFechaCreacion.AutoSize = True
        Me.lblEtFechaCreacion.Location = New System.Drawing.Point(3, 23)
        Me.lblEtFechaCreacion.Name = "lblEtFechaCreacion"
        Me.lblEtFechaCreacion.Size = New System.Drawing.Size(126, 16)
        Me.lblEtFechaCreacion.TabIndex = 3
        Me.lblEtFechaCreacion.Text = "Fecha de creación: "
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Location = New System.Drawing.Point(126, 23)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(106, 16)
        Me.lblFechaCreacion.TabIndex = 4
        Me.lblFechaCreacion.Text = "01/01/2000 00:00"
        '
        'lblEtFechaAcceso
        '
        Me.lblEtFechaAcceso.AutoSize = True
        Me.lblEtFechaAcceso.Location = New System.Drawing.Point(3, 42)
        Me.lblEtFechaAcceso.Name = "lblEtFechaAcceso"
        Me.lblEtFechaAcceso.Size = New System.Drawing.Size(119, 16)
        Me.lblEtFechaAcceso.TabIndex = 5
        Me.lblEtFechaAcceso.Text = "Fecha de acceso: "
        '
        'lblFechaAcceso
        '
        Me.lblFechaAcceso.AutoSize = True
        Me.lblFechaAcceso.Location = New System.Drawing.Point(126, 42)
        Me.lblFechaAcceso.Name = "lblFechaAcceso"
        Me.lblFechaAcceso.Size = New System.Drawing.Size(106, 16)
        Me.lblFechaAcceso.TabIndex = 6
        Me.lblFechaAcceso.Text = "01/01/2000 00:00"
        '
        'lblEtTamano
        '
        Me.lblEtTamano.AutoSize = True
        Me.lblEtTamano.Location = New System.Drawing.Point(3, 60)
        Me.lblEtTamano.Name = "lblEtTamano"
        Me.lblEtTamano.Size = New System.Drawing.Size(62, 16)
        Me.lblEtTamano.TabIndex = 7
        Me.lblEtTamano.Text = "Tamaño:"
        '
        'lblTamano
        '
        Me.lblTamano.AutoSize = True
        Me.lblTamano.Location = New System.Drawing.Point(126, 60)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(37, 16)
        Me.lblTamano.TabIndex = 8
        Me.lblTamano.Text = ".mp3"
        '
        'pnlVistaPrevia
        '
        Me.pnlVistaPrevia.Controls.Add(Me.pcbImagen)
        Me.pnlVistaPrevia.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlVistaPrevia.Location = New System.Drawing.Point(0, 0)
        Me.pnlVistaPrevia.Name = "pnlVistaPrevia"
        Me.pnlVistaPrevia.Size = New System.Drawing.Size(122, 81)
        Me.pnlVistaPrevia.TabIndex = 16
        Me.pnlVistaPrevia.Visible = False
        '
        'pcbImagen
        '
        Me.pcbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbImagen.Image = CType(resources.GetObject("pcbImagen.Image"), System.Drawing.Image)
        Me.pcbImagen.Location = New System.Drawing.Point(3, 3)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(116, 75)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 1
        Me.pcbImagen.TabStop = False
        '
        'prc_sesion_servidor
        '
        Me.prc_sesion_servidor.StartInfo.Arguments = "use \\192.168.0.1\shared franz /USER:FRANZ"
        Me.prc_sesion_servidor.StartInfo.Domain = ""
        Me.prc_sesion_servidor.StartInfo.FileName = "%systemroot%\System32\user.exe"
        Me.prc_sesion_servidor.StartInfo.LoadUserProfile = False
        Me.prc_sesion_servidor.StartInfo.Password = Nothing
        Me.prc_sesion_servidor.StartInfo.StandardErrorEncoding = Nothing
        Me.prc_sesion_servidor.StartInfo.StandardOutputEncoding = Nothing
        Me.prc_sesion_servidor.StartInfo.UserName = ""
        Me.prc_sesion_servidor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        Me.prc_sesion_servidor.SynchronizingObject = Me
        '
        'ABRIR_DIRECTORIO
        '
        Me.ABRIR_DIRECTORIO.StartInfo.Domain = ""
        Me.ABRIR_DIRECTORIO.StartInfo.LoadUserProfile = False
        Me.ABRIR_DIRECTORIO.StartInfo.Password = Nothing
        Me.ABRIR_DIRECTORIO.StartInfo.StandardErrorEncoding = Nothing
        Me.ABRIR_DIRECTORIO.StartInfo.StandardOutputEncoding = Nothing
        Me.ABRIR_DIRECTORIO.StartInfo.UserName = ""
        Me.ABRIR_DIRECTORIO.SynchronizingObject = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(736, 620)
        Me.Controls.Add(Me.lsVista)
        Me.Controls.Add(Me.pnlAtributos)
        Me.Controls.Add(Me.ssEstado)
        Me.Controls.Add(Me.tsHerramientas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(726, 654)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Explorador Referencias Dacotrans"
        Me.cmsMenu.ResumeLayout(False)
        Me.ssEstado.ResumeLayout(False)
        Me.ssEstado.PerformLayout()
        Me.tsHerramientas.ResumeLayout(False)
        Me.tsHerramientas.PerformLayout()
        Me.pnlAtributos.ResumeLayout(False)
        Me.pnlAtributosDesc.ResumeLayout(False)
        Me.pnlAtributosDesc.PerformLayout()
        Me.pnlAtributosImagen.ResumeLayout(False)
        Me.pnlAtributosImagen.PerformLayout()
        Me.pnlVistaPrevia.ResumeLayout(False)
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsVista As System.Windows.Forms.ListView
    Friend WithEvents cNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents ilImagen1 As System.Windows.Forms.ImageList
    Friend WithEvents cTamano As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents cFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnSubir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnOcultos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents mnActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cAtributos As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSubir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkOcultos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents mnAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssSeparadorContextual2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents slblEtBuffer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblBuffer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblEtAccion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblAccion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssSeparador05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSeparador04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents slblEtObjetos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblObjetos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlAtributos As System.Windows.Forms.Panel
    Friend WithEvents pcbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents lblNombreFichero As System.Windows.Forms.Label
    Friend WithEvents lblFechaAcceso As System.Windows.Forms.Label
    Friend WithEvents lblEtFechaAcceso As System.Windows.Forms.Label
    Friend WithEvents lblFechaCreacion As System.Windows.Forms.Label
    Friend WithEvents lblEtFechaCreacion As System.Windows.Forms.Label
    Friend WithEvents lblTamano As System.Windows.Forms.Label
    Friend WithEvents lblEtTamano As System.Windows.Forms.Label
    Friend WithEvents lblResolucionVertical As System.Windows.Forms.Label
    Friend WithEvents lblEtResolucionVertical As System.Windows.Forms.Label
    Friend WithEvents lblResolucionHorizontal As System.Windows.Forms.Label
    Friend WithEvents lblEtResolucionHorizontal As System.Windows.Forms.Label
    Friend WithEvents lblDimensiones As System.Windows.Forms.Label
    Friend WithEvents lblEtDimensiones As System.Windows.Forms.Label
    Friend WithEvents pnlVistaPrevia As System.Windows.Forms.Panel
    Friend WithEvents pnlAtributosDesc As System.Windows.Forms.Panel
    Friend WithEvents pnlAtributosImagen As System.Windows.Forms.Panel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents progressbar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents label6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents prc_sesion_servidor As System.Diagnostics.Process
    Friend WithEvents mnCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABRIR_DIRECTORIO As System.Diagnostics.Process

End Class
