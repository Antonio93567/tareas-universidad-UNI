<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepArchivo = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeshacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRehacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepEdicion1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepEdicion2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSeleccionarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormato = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepFormato = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAjusteLinea = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZoomMas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZoomMenos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZoomRestablecer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepVer1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTemaOscuro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHerramientas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepHerramientas = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuContarPalabras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContarCaracteres = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbAbrir = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsSepTool1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCortar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbPegar = New System.Windows.Forms.ToolStripButton()
        Me.tsSepTool2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNegrita = New System.Windows.Forms.ToolStripButton()
        Me.tsbCursiva = New System.Windows.Forms.ToolStripButton()
        Me.tsbSubrayado = New System.Windows.Forms.ToolStripButton()
        Me.tsSepTool3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscbFuente = New System.Windows.Forms.ToolStripComboBox()
        Me.tscbTamano = New System.Windows.Forms.ToolStripComboBox()
        Me.rtbDocumento = New System.Windows.Forms.RichTextBox()
        Me.stsInferior = New System.Windows.Forms.StatusStrip()
        Me.stsEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsPosicion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsCaracteres = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsPalabras = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmsTexto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepCms1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsSeleccionarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSepCms2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.dlgGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.dlgFuente = New System.Windows.Forms.FontDialog()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.tmrReloj = New System.Windows.Forms.Timer(Me.components)
        Me.mnuPrincipal.SuspendLayout()
        Me.tsPrincipal.SuspendLayout()
        Me.stsInferior.SuspendLayout()
        Me.cmsTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuEdicion, Me.mnuFormato, Me.mnuVer, Me.mnuHerramientas, Me.mnuAyuda})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(800, 24)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "mnuPrincipal"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuAbrir, Me.mnuGuardar, Me.mnuGuardarComo, Me.tsSepArchivo, Me.mnuSalir})
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Text = "&Archivo"
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N
        Me.mnuNuevo.Text = "&Nuevo"
        '
        'mnuAbrir
        '
        Me.mnuAbrir.Name = "mnuAbrir"
        Me.mnuAbrir.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O
        Me.mnuAbrir.Text = "&Abrir..."
        '
        'mnuGuardar
        '
        Me.mnuGuardar.Name = "mnuGuardar"
        Me.mnuGuardar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S
        Me.mnuGuardar.Text = "&Guardar"
        '
        'mnuGuardarComo
        '
        Me.mnuGuardarComo.Name = "mnuGuardarComo"
        Me.mnuGuardarComo.Text = "Guardar &como..."
        '
        'tsSepArchivo
        '
        Me.tsSepArchivo.Name = "tsSepArchivo"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4
        Me.mnuSalir.Text = "&Salir"
        '
        'mnuEdicion
        '
        Me.mnuEdicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeshacer, Me.mnuRehacer, Me.tsSepEdicion1, Me.mnuCortar, Me.mnuCopiar, Me.mnuPegar, Me.tsSepEdicion2, Me.mnuSeleccionarTodo})
        Me.mnuEdicion.Name = "mnuEdicion"
        Me.mnuEdicion.Text = "&Edición"
        '
        'mnuDeshacer
        '
        Me.mnuDeshacer.Name = "mnuDeshacer"
        Me.mnuDeshacer.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z
        Me.mnuDeshacer.Text = "&Deshacer"
        '
        'mnuRehacer
        '
        Me.mnuRehacer.Name = "mnuRehacer"
        Me.mnuRehacer.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y
        Me.mnuRehacer.Text = "&Rehacer"
        '
        'tsSepEdicion1
        '
        Me.tsSepEdicion1.Name = "tsSepEdicion1"
        '
        'mnuCortar
        '
        Me.mnuCortar.Name = "mnuCortar"
        Me.mnuCortar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X
        Me.mnuCortar.Text = "Cor&tar"
        '
        'mnuCopiar
        '
        Me.mnuCopiar.Name = "mnuCopiar"
        Me.mnuCopiar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C
        Me.mnuCopiar.Text = "&Copiar"
        '
        'mnuPegar
        '
        Me.mnuPegar.Name = "mnuPegar"
        Me.mnuPegar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V
        Me.mnuPegar.Text = "&Pegar"
        '
        'tsSepEdicion2
        '
        Me.tsSepEdicion2.Name = "tsSepEdicion2"
        '
        'mnuSeleccionarTodo
        '
        Me.mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        Me.mnuSeleccionarTodo.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A
        Me.mnuSeleccionarTodo.Text = "Seleccionar &todo"
        '
        'mnuFormato
        '
        Me.mnuFormato.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFuente, Me.mnuColorTexto, Me.tsSepFormato, Me.mnuAjusteLinea})
        Me.mnuFormato.Name = "mnuFormato"
        Me.mnuFormato.Text = "F&ormato"
        '
        'mnuFuente
        '
        Me.mnuFuente.Name = "mnuFuente"
        Me.mnuFuente.Text = "&Fuente..."
        '
        'mnuColorTexto
        '
        Me.mnuColorTexto.Name = "mnuColorTexto"
        Me.mnuColorTexto.Text = "Color de &texto..."
        '
        'tsSepFormato
        '
        Me.tsSepFormato.Name = "tsSepFormato"
        '
        'mnuAjusteLinea
        '
        Me.mnuAjusteLinea.CheckOnClick = True
        Me.mnuAjusteLinea.Name = "mnuAjusteLinea"
        Me.mnuAjusteLinea.Text = "&Ajuste de línea"
        '
        'mnuVer
        '
        Me.mnuVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuZoomMas, Me.mnuZoomMenos, Me.mnuZoomRestablecer, Me.tsSepVer1, Me.mnuTemaOscuro})
        Me.mnuVer.Name = "mnuVer"
        Me.mnuVer.Text = "&Ver"
        '
        'mnuZoomMas
        '
        Me.mnuZoomMas.Name = "mnuZoomMas"
        Me.mnuZoomMas.Text = "Acercar"
        '
        'mnuZoomMenos
        '
        Me.mnuZoomMenos.Name = "mnuZoomMenos"
        Me.mnuZoomMenos.Text = "Alejar"
        '
        'mnuZoomRestablecer
        '
        Me.mnuZoomRestablecer.Name = "mnuZoomRestablecer"
        Me.mnuZoomRestablecer.Text = "Restablecer zoom"
        '
        'tsSepVer1
        '
        Me.tsSepVer1.Name = "tsSepVer1"
        '
        'mnuTemaOscuro
        '
        Me.mnuTemaOscuro.CheckOnClick = True
        Me.mnuTemaOscuro.Name = "mnuTemaOscuro"
        Me.mnuTemaOscuro.Text = "&Tema oscuro"
        '
        'mnuHerramientas
        '
        Me.mnuHerramientas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBuscar, Me.tsSepHerramientas, Me.mnuContarPalabras, Me.mnuContarCaracteres})
        Me.mnuHerramientas.Name = "mnuHerramientas"
        Me.mnuHerramientas.Text = "&Herramientas"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F
        Me.mnuBuscar.Text = "&Buscar..."
        '
        'tsSepHerramientas
        '
        Me.tsSepHerramientas.Name = "tsSepHerramientas"
        '
        'mnuContarPalabras
        '
        Me.mnuContarPalabras.Name = "mnuContarPalabras"
        Me.mnuContarPalabras.Text = "&Contar palabras"
        '
        'mnuContarCaracteres
        '
        Me.mnuContarCaracteres.Name = "mnuContarCaracteres"
        Me.mnuContarCaracteres.Text = "Contar &caracteres"
        '
        'mnuAyuda
        '
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcercaDe})
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.Text = "&Ayuda"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Text = "&Acerca de..."
        '
        'tsPrincipal
        '
        Me.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbAbrir, Me.tsbGuardar, Me.tsSepTool1, Me.tsbCortar, Me.tsbCopiar, Me.tsbPegar, Me.tsSepTool2, Me.tsbNegrita, Me.tsbCursiva, Me.tsbSubrayado, Me.tsSepTool3, Me.tscbFuente, Me.tscbTamano})
        Me.tsPrincipal.Location = New System.Drawing.Point(0, 24)
        Me.tsPrincipal.Name = "tsPrincipal"
        Me.tsPrincipal.Size = New System.Drawing.Size(800, 25)
        Me.tsPrincipal.TabIndex = 1
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbAbrir
        '
        Me.tsbAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAbrir.Name = "tsbAbrir"
        Me.tsbAbrir.Text = "Abrir"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsSepTool1
        '
        Me.tsSepTool1.Name = "tsSepTool1"
        '
        'tsbCortar
        '
        Me.tsbCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCortar.Name = "tsbCortar"
        Me.tsbCortar.Text = "Cortar"
        '
        'tsbCopiar
        '
        Me.tsbCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCopiar.Name = "tsbCopiar"
        Me.tsbCopiar.Text = "Copiar"
        '
        'tsbPegar
        '
        Me.tsbPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPegar.Name = "tsbPegar"
        Me.tsbPegar.Text = "Pegar"
        '
        'tsSepTool2
        '
        Me.tsSepTool2.Name = "tsSepTool2"
        '
        'tsbNegrita
        '
        Me.tsbNegrita.CheckOnClick = True
        Me.tsbNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNegrita.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tsbNegrita.Name = "tsbNegrita"
        Me.tsbNegrita.Text = "B"
        '
        'tsbCursiva
        '
        Me.tsbCursiva.CheckOnClick = True
        Me.tsbCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCursiva.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.tsbCursiva.Name = "tsbCursiva"
        Me.tsbCursiva.Text = "I"
        '
        'tsbSubrayado
        '
        Me.tsbSubrayado.CheckOnClick = True
        Me.tsbSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSubrayado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.tsbSubrayado.Name = "tsbSubrayado"
        Me.tsbSubrayado.Text = "S"
        '
        'tsSepTool3
        '
        Me.tsSepTool3.Name = "tsSepTool3"
        '
        'tscbFuente
        '
        Me.tscbFuente.Name = "tscbFuente"
        Me.tscbFuente.Size = New System.Drawing.Size(140, 25)
        '
        'tscbTamano
        '
        Me.tscbTamano.Name = "tscbTamano"
        Me.tscbTamano.Size = New System.Drawing.Size(60, 25)
        '
        'rtbDocumento
        '
        Me.rtbDocumento.ContextMenuStrip = Me.cmsTexto
        Me.rtbDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDocumento.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDocumento.Location = New System.Drawing.Point(0, 49)
        Me.rtbDocumento.Name = "rtbDocumento"
        Me.rtbDocumento.Size = New System.Drawing.Size(800, 427)
        Me.rtbDocumento.TabIndex = 2
        Me.rtbDocumento.Text = ""
        '
        'stsInferior
        '
        Me.stsInferior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsEstado, Me.stsPosicion, Me.stsCaracteres, Me.stsPalabras, Me.stsZoom, Me.stsFechaHora})
        Me.stsInferior.Location = New System.Drawing.Point(0, 476)
        Me.stsInferior.Name = "stsInferior"
        Me.stsInferior.Size = New System.Drawing.Size(800, 22)
        Me.stsInferior.TabIndex = 3
        '
        'stsEstado
        '
        Me.stsEstado.Name = "stsEstado"
        Me.stsEstado.Size = New System.Drawing.Size(463, 17)
        Me.stsEstado.Spring = True
        Me.stsEstado.Text = "Listo"
        '
        'stsPosicion
        '
        Me.stsPosicion.Name = "stsPosicion"
        Me.stsPosicion.Size = New System.Drawing.Size(100, 17)
        Me.stsPosicion.Text = "Línea: 1   Columna: 1"
        '
        'stsCaracteres
        '
        Me.stsCaracteres.Name = "stsCaracteres"
        Me.stsCaracteres.Size = New System.Drawing.Size(86, 17)
        Me.stsCaracteres.Text = "Caracteres: 0"
        '
        'stsPalabras
        '
        Me.stsPalabras.Name = "stsPalabras"
        Me.stsPalabras.Size = New System.Drawing.Size(70, 17)
        Me.stsPalabras.Text = "Palabras: 0"
        '
        'stsZoom
        '
        Me.stsZoom.Name = "stsZoom"
        Me.stsZoom.Size = New System.Drawing.Size(62, 17)
        Me.stsZoom.Text = "Zoom: 100%"
        '
        'stsFechaHora
        '
        Me.stsFechaHora.Name = "stsFechaHora"
        Me.stsFechaHora.Size = New System.Drawing.Size(73, 17)
        Me.stsFechaHora.Text = ""
        '
        'cmsTexto
        '
        Me.cmsTexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsCortar, Me.cmsCopiar, Me.cmsPegar, Me.tsSepCms1, Me.cmsSeleccionarTodo, Me.tsSepCms2, Me.cmsFuente})
        Me.cmsTexto.Name = "cmsTexto"
        Me.cmsTexto.Size = New System.Drawing.Size(161, 148)
        '
        'cmsCortar
        '
        Me.cmsCortar.Name = "cmsCortar"
        Me.cmsCortar.Size = New System.Drawing.Size(160, 22)
        Me.cmsCortar.Text = "Cortar"
        '
        'cmsCopiar
        '
        Me.cmsCopiar.Name = "cmsCopiar"
        Me.cmsCopiar.Size = New System.Drawing.Size(160, 22)
        Me.cmsCopiar.Text = "Copiar"
        '
        'cmsPegar
        '
        Me.cmsPegar.Name = "cmsPegar"
        Me.cmsPegar.Size = New System.Drawing.Size(160, 22)
        Me.cmsPegar.Text = "Pegar"
        '
        'tsSepCms1
        '
        Me.tsSepCms1.Name = "tsSepCms1"
        Me.tsSepCms1.Size = New System.Drawing.Size(157, 6)
        '
        'cmsSeleccionarTodo
        '
        Me.cmsSeleccionarTodo.Name = "cmsSeleccionarTodo"
        Me.cmsSeleccionarTodo.Size = New System.Drawing.Size(160, 22)
        Me.cmsSeleccionarTodo.Text = "Seleccionar todo"
        '
        'tsSepCms2
        '
        Me.tsSepCms2.Name = "tsSepCms2"
        Me.tsSepCms2.Size = New System.Drawing.Size(157, 6)
        '
        'cmsFuente
        '
        Me.cmsFuente.Name = "cmsFuente"
        Me.cmsFuente.Size = New System.Drawing.Size(160, 22)
        Me.cmsFuente.Text = "Fuente..."
        '
        'dlgAbrir
        '
        Me.dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        Me.dlgAbrir.Title = "Abrir archivo"
        '
        'dlgGuardar
        '
        Me.dlgGuardar.DefaultExt = "txt"
        Me.dlgGuardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        Me.dlgGuardar.Title = "Guardar archivo"
        '
        'dlgFuente
        '
        Me.dlgFuente.ShowColor = True
        '
        'dlgColor
        '
        Me.dlgColor.FullOpen = True
        '
        'tmrReloj
        '
        Me.tmrReloj.Enabled = True
        Me.tmrReloj.Interval = 1000
        '
        'frmBlocNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.stsInferior)
        Me.Controls.Add(Me.rtbDocumento)
        Me.Controls.Add(Me.tsPrincipal)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "frmBlocNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloc de Notas VB.NET"
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.tsPrincipal.ResumeLayout(False)
        Me.tsPrincipal.PerformLayout()
        Me.stsInferior.ResumeLayout(False)
        Me.stsInferior.PerformLayout()
        Me.cmsTexto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepArchivo As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeshacer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRehacer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepEdicion1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPegar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepEdicion2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSeleccionarTodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFormato As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFuente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColorTexto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepFormato As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAjusteLinea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuZoomMas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuZoomMenos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuZoomRestablecer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepVer1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTemaOscuro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHerramientas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepHerramientas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuContarPalabras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContarCaracteres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAbrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSepTool1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCortar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCopiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPegar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSepTool2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbNegrita As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCursiva As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSubrayado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSepTool3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tscbFuente As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tscbTamano As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents rtbDocumento As System.Windows.Forms.RichTextBox
    Friend WithEvents stsInferior As System.Windows.Forms.StatusStrip
    Friend WithEvents stsEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsPosicion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsCaracteres As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsPalabras As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsZoom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsFechaHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmsTexto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPegar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepCms1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsSeleccionarTodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSepCms2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsFuente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgFuente As System.Windows.Forms.FontDialog
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents tmrReloj As System.Windows.Forms.Timer

End Class