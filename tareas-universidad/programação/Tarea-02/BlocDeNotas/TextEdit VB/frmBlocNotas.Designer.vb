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
        components = New ComponentModel.Container()
        mnuPrincipal = New System.Windows.Forms.MenuStrip()
        mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        mnuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        mnuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        mnuGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
        tsSepArchivo = New System.Windows.Forms.ToolStripSeparator()
        mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        mnuEdicion = New System.Windows.Forms.ToolStripMenuItem()
        mnuDeshacer = New System.Windows.Forms.ToolStripMenuItem()
        mnuRehacer = New System.Windows.Forms.ToolStripMenuItem()
        tsSepEdicion1 = New System.Windows.Forms.ToolStripSeparator()
        mnuCortar = New System.Windows.Forms.ToolStripMenuItem()
        mnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        mnuPegar = New System.Windows.Forms.ToolStripMenuItem()
        tsSepEdicion2 = New System.Windows.Forms.ToolStripSeparator()
        mnuSeleccionarTodo = New System.Windows.Forms.ToolStripMenuItem()
        mnuFormato = New System.Windows.Forms.ToolStripMenuItem()
        mnuFuente = New System.Windows.Forms.ToolStripMenuItem()
        mnuColorTexto = New System.Windows.Forms.ToolStripMenuItem()
        tsSepFormato = New System.Windows.Forms.ToolStripSeparator()
        mnuAjusteLinea = New System.Windows.Forms.ToolStripMenuItem()
        mnuVer = New System.Windows.Forms.ToolStripMenuItem()
        mnuZoomMas = New System.Windows.Forms.ToolStripMenuItem()
        mnuZoomMenos = New System.Windows.Forms.ToolStripMenuItem()
        mnuZoomRestablecer = New System.Windows.Forms.ToolStripMenuItem()
        tsSepVer1 = New System.Windows.Forms.ToolStripSeparator()
        mnuTemaOscuro = New System.Windows.Forms.ToolStripMenuItem()
        mnuHerramientas = New System.Windows.Forms.ToolStripMenuItem()
        mnuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        tsSepHerramientas = New System.Windows.Forms.ToolStripSeparator()
        mnuContarPalabras = New System.Windows.Forms.ToolStripMenuItem()
        mnuContarCaracteres = New System.Windows.Forms.ToolStripMenuItem()
        mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        tsPrincipal = New System.Windows.Forms.ToolStrip()
        tsbNuevo = New System.Windows.Forms.ToolStripButton()
        tsbAbrir = New System.Windows.Forms.ToolStripButton()
        tsbGuardar = New System.Windows.Forms.ToolStripButton()
        tsSepTool1 = New System.Windows.Forms.ToolStripSeparator()
        tsbCortar = New System.Windows.Forms.ToolStripButton()
        tsbCopiar = New System.Windows.Forms.ToolStripButton()
        tsbPegar = New System.Windows.Forms.ToolStripButton()
        tsSepTool2 = New System.Windows.Forms.ToolStripSeparator()
        tsbNegrita = New System.Windows.Forms.ToolStripButton()
        tsbCursiva = New System.Windows.Forms.ToolStripButton()
        tsbSubrayado = New System.Windows.Forms.ToolStripButton()
        tsSepTool3 = New System.Windows.Forms.ToolStripSeparator()
        tscbFuente = New System.Windows.Forms.ToolStripComboBox()
        tscbTamano = New System.Windows.Forms.ToolStripComboBox()
        rtbDocumento = New System.Windows.Forms.RichTextBox()
        cmsTexto = New System.Windows.Forms.ContextMenuStrip(components)
        cmsCortar = New System.Windows.Forms.ToolStripMenuItem()
        cmsCopiar = New System.Windows.Forms.ToolStripMenuItem()
        cmsPegar = New System.Windows.Forms.ToolStripMenuItem()
        tsSepCms1 = New System.Windows.Forms.ToolStripSeparator()
        cmsSeleccionarTodo = New System.Windows.Forms.ToolStripMenuItem()
        tsSepCms2 = New System.Windows.Forms.ToolStripSeparator()
        cmsFuente = New System.Windows.Forms.ToolStripMenuItem()
        stsInferior = New System.Windows.Forms.StatusStrip()
        stsEstado = New System.Windows.Forms.ToolStripStatusLabel()
        stsPosicion = New System.Windows.Forms.ToolStripStatusLabel()
        stsCaracteres = New System.Windows.Forms.ToolStripStatusLabel()
        stsPalabras = New System.Windows.Forms.ToolStripStatusLabel()
        stsZoom = New System.Windows.Forms.ToolStripStatusLabel()
        stsFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        dlgAbrir = New System.Windows.Forms.OpenFileDialog()
        dlgGuardar = New System.Windows.Forms.SaveFileDialog()
        dlgFuente = New System.Windows.Forms.FontDialog()
        dlgColor = New System.Windows.Forms.ColorDialog()
        tmrReloj = New System.Windows.Forms.Timer(components)
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.ImageScalingSize = New System.Drawing.Size(24, 24)
        mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {mnuArchivo, mnuEdicion, mnuFormato, mnuVer, mnuHerramientas, mnuAyuda})
        mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        mnuPrincipal.Size = New System.Drawing.Size(1143, 35)
        mnuPrincipal.TabIndex = 0
        mnuPrincipal.Text = "mnuPrincipal"
        ' 
        ' mnuArchivo
        ' 
        mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, tsSepArchivo, mnuSalir})
        mnuArchivo.Name = "mnuArchivo"
        mnuArchivo.Size = New System.Drawing.Size(88, 29)
        mnuArchivo.Text = "&Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N
        mnuNuevo.Size = New System.Drawing.Size(240, 34)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O
        mnuAbrir.Size = New System.Drawing.Size(240, 34)
        mnuAbrir.Text = "&Abrir..."
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S
        mnuGuardar.Size = New System.Drawing.Size(240, 34)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New System.Drawing.Size(240, 34)
        mnuGuardarComo.Text = "Guardar &como..."
        ' 
        ' tsSepArchivo
        ' 
        tsSepArchivo.Name = "tsSepArchivo"
        tsSepArchivo.Size = New System.Drawing.Size(237, 6)
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4
        mnuSalir.Size = New System.Drawing.Size(240, 34)
        mnuSalir.Text = "&Salir"
        ' 
        ' mnuEdicion
        ' 
        mnuEdicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuDeshacer, mnuRehacer, tsSepEdicion1, mnuCortar, mnuCopiar, mnuPegar, tsSepEdicion2, mnuSeleccionarTodo})
        mnuEdicion.Name = "mnuEdicion"
        mnuEdicion.Size = New System.Drawing.Size(85, 29)
        mnuEdicion.Text = "&Edición"
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z
        mnuDeshacer.Size = New System.Drawing.Size(309, 34)
        mnuDeshacer.Text = "&Deshacer"
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y
        mnuRehacer.Size = New System.Drawing.Size(309, 34)
        mnuRehacer.Text = "&Rehacer"
        ' 
        ' tsSepEdicion1
        ' 
        tsSepEdicion1.Name = "tsSepEdicion1"
        tsSepEdicion1.Size = New System.Drawing.Size(306, 6)
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X
        mnuCortar.Size = New System.Drawing.Size(309, 34)
        mnuCortar.Text = "Cor&tar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C
        mnuCopiar.Size = New System.Drawing.Size(309, 34)
        mnuCopiar.Text = "&Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V
        mnuPegar.Size = New System.Drawing.Size(309, 34)
        mnuPegar.Text = "&Pegar"
        ' 
        ' tsSepEdicion2
        ' 
        tsSepEdicion2.Name = "tsSepEdicion2"
        tsSepEdicion2.Size = New System.Drawing.Size(306, 6)
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A
        mnuSeleccionarTodo.Size = New System.Drawing.Size(309, 34)
        mnuSeleccionarTodo.Text = "Seleccionar &todo"
        ' 
        ' mnuFormato
        ' 
        mnuFormato.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuFuente, mnuColorTexto, tsSepFormato, mnuAjusteLinea})
        mnuFormato.Name = "mnuFormato"
        mnuFormato.Size = New System.Drawing.Size(96, 29)
        mnuFormato.Text = "F&ormato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New System.Drawing.Size(239, 34)
        mnuFuente.Text = "&Fuente..."
        ' 
        ' mnuColorTexto
        ' 
        mnuColorTexto.Name = "mnuColorTexto"
        mnuColorTexto.Size = New System.Drawing.Size(239, 34)
        mnuColorTexto.Text = "Color de &texto..."
        ' 
        ' tsSepFormato
        ' 
        tsSepFormato.Name = "tsSepFormato"
        tsSepFormato.Size = New System.Drawing.Size(236, 6)
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New System.Drawing.Size(239, 34)
        mnuAjusteLinea.Text = "&Ajuste de línea"
        ' 
        ' mnuVer
        ' 
        mnuVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuZoomMas, mnuZoomMenos, mnuZoomRestablecer, tsSepVer1, mnuTemaOscuro})
        mnuVer.Name = "mnuVer"
        mnuVer.Size = New System.Drawing.Size(53, 29)
        mnuVer.Text = "&Ver"
        ' 
        ' mnuZoomMas
        ' 
        mnuZoomMas.Name = "mnuZoomMas"
        mnuZoomMas.Size = New System.Drawing.Size(254, 34)
        mnuZoomMas.Text = "Acercar"
        ' 
        ' mnuZoomMenos
        ' 
        mnuZoomMenos.Name = "mnuZoomMenos"
        mnuZoomMenos.Size = New System.Drawing.Size(254, 34)
        mnuZoomMenos.Text = "Alejar"
        ' 
        ' mnuZoomRestablecer
        ' 
        mnuZoomRestablecer.Name = "mnuZoomRestablecer"
        mnuZoomRestablecer.Size = New System.Drawing.Size(254, 34)
        mnuZoomRestablecer.Text = "Restablecer zoom"
        ' 
        ' tsSepVer1
        ' 
        tsSepVer1.Name = "tsSepVer1"
        tsSepVer1.Size = New System.Drawing.Size(251, 6)
        ' 
        ' mnuTemaOscuro
        ' 
        mnuTemaOscuro.CheckOnClick = True
        mnuTemaOscuro.Name = "mnuTemaOscuro"
        mnuTemaOscuro.Size = New System.Drawing.Size(254, 34)
        mnuTemaOscuro.Text = "&Tema oscuro"
        ' 
        ' mnuHerramientas
        ' 
        mnuHerramientas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuBuscar, tsSepHerramientas, mnuContarPalabras, mnuContarCaracteres})
        mnuHerramientas.Name = "mnuHerramientas"
        mnuHerramientas.Size = New System.Drawing.Size(133, 29)
        mnuHerramientas.Text = "&Herramientas"
        ' 
        ' mnuBuscar
        ' 
        mnuBuscar.Name = "mnuBuscar"
        mnuBuscar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F
        mnuBuscar.Size = New System.Drawing.Size(250, 34)
        mnuBuscar.Text = "&Buscar..."
        ' 
        ' tsSepHerramientas
        ' 
        tsSepHerramientas.Name = "tsSepHerramientas"
        tsSepHerramientas.Size = New System.Drawing.Size(247, 6)
        ' 
        ' mnuContarPalabras
        ' 
        mnuContarPalabras.Name = "mnuContarPalabras"
        mnuContarPalabras.Size = New System.Drawing.Size(250, 34)
        mnuContarPalabras.Text = "&Contar palabras"
        ' 
        ' mnuContarCaracteres
        ' 
        mnuContarCaracteres.Name = "mnuContarCaracteres"
        mnuContarCaracteres.Size = New System.Drawing.Size(250, 34)
        mnuContarCaracteres.Text = "Contar &caracteres"
        ' 
        ' mnuAyuda
        ' 
        mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuAcercaDe})
        mnuAyuda.Name = "mnuAyuda"
        mnuAyuda.Size = New System.Drawing.Size(79, 29)
        mnuAyuda.Text = "&Ayuda"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New System.Drawing.Size(203, 34)
        mnuAcercaDe.Text = "&Acerca de..."
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        tsPrincipal.ImageScalingSize = New System.Drawing.Size(24, 24)
        tsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, tsSepTool1, tsbCortar, tsbCopiar, tsbPegar, tsSepTool2, tsbNegrita, tsbCursiva, tsbSubrayado, tsSepTool3, tscbFuente, tscbTamano})
        tsPrincipal.Location = New System.Drawing.Point(0, 35)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        tsPrincipal.Size = New System.Drawing.Size(1143, 34)
        tsPrincipal.TabIndex = 1
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New System.Drawing.Size(68, 29)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New System.Drawing.Size(55, 29)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New System.Drawing.Size(79, 29)
        tsbGuardar.Text = "Guardar"
        ' 
        ' tsSepTool1
        ' 
        tsSepTool1.Name = "tsSepTool1"
        tsSepTool1.Size = New System.Drawing.Size(6, 34)
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New System.Drawing.Size(65, 29)
        tsbCortar.Text = "Cortar"
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New System.Drawing.Size(68, 29)
        tsbCopiar.Text = "Copiar"
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New System.Drawing.Size(60, 29)
        tsbPegar.Text = "Pegar"
        ' 
        ' tsSepTool2
        ' 
        tsSepTool2.Name = "tsSepTool2"
        tsSepTool2.Size = New System.Drawing.Size(6, 34)
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbNegrita.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New System.Drawing.Size(34, 29)
        tsbNegrita.Text = "B"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbCursiva.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Italic)
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New System.Drawing.Size(34, 29)
        tsbCursiva.Text = "I"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsbSubrayado.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Underline)
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New System.Drawing.Size(34, 29)
        tsbSubrayado.Text = "S"
        ' 
        ' tsSepTool3
        ' 
        tsSepTool3.Name = "tsSepTool3"
        tsSepTool3.Size = New System.Drawing.Size(6, 34)
        ' 
        ' tscbFuente
        ' 
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New System.Drawing.Size(198, 34)
        ' 
        ' tscbTamano
        ' 
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New System.Drawing.Size(105, 34)
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        rtbDocumento.Font = New System.Drawing.Font("Consolas", 11.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New System.Drawing.Point(0, 69)
        rtbDocumento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New System.Drawing.Size(1143, 761)
        rtbDocumento.TabIndex = 2
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.ImageScalingSize = New System.Drawing.Size(24, 24)
        cmsTexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {cmsCortar, cmsCopiar, cmsPegar, tsSepCms1, cmsSeleccionarTodo, tsSepCms2, cmsFuente})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New System.Drawing.Size(217, 176)
        ' 
        ' cmsCortar
        ' 
        cmsCortar.Name = "cmsCortar"
        cmsCortar.Size = New System.Drawing.Size(216, 32)
        cmsCortar.Text = "Cortar"
        ' 
        ' cmsCopiar
        ' 
        cmsCopiar.Name = "cmsCopiar"
        cmsCopiar.Size = New System.Drawing.Size(216, 32)
        cmsCopiar.Text = "Copiar"
        ' 
        ' cmsPegar
        ' 
        cmsPegar.Name = "cmsPegar"
        cmsPegar.Size = New System.Drawing.Size(216, 32)
        cmsPegar.Text = "Pegar"
        ' 
        ' tsSepCms1
        ' 
        tsSepCms1.Name = "tsSepCms1"
        tsSepCms1.Size = New System.Drawing.Size(213, 6)
        ' 
        ' cmsSeleccionarTodo
        ' 
        cmsSeleccionarTodo.Name = "cmsSeleccionarTodo"
        cmsSeleccionarTodo.Size = New System.Drawing.Size(216, 32)
        cmsSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' tsSepCms2
        ' 
        tsSepCms2.Name = "tsSepCms2"
        tsSepCms2.Size = New System.Drawing.Size(213, 6)
        ' 
        ' cmsFuente
        ' 
        cmsFuente.Name = "cmsFuente"
        cmsFuente.Size = New System.Drawing.Size(216, 32)
        cmsFuente.Text = "Fuente..."
        ' 
        ' stsInferior
        ' 
        stsInferior.ImageScalingSize = New System.Drawing.Size(24, 24)
        stsInferior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsPalabras, stsZoom, stsFechaHora})
        stsInferior.Location = New System.Drawing.Point(0, 798)
        stsInferior.Name = "stsInferior"
        stsInferior.Padding = New System.Windows.Forms.Padding(1, 0, 20, 0)
        stsInferior.Size = New System.Drawing.Size(1143, 32)
        stsInferior.TabIndex = 3
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New System.Drawing.Size(624, 25)
        stsEstado.Spring = True
        stsEstado.Text = "Listo"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New System.Drawing.Size(176, 25)
        stsPosicion.Text = "Línea: 1   Columna: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New System.Drawing.Size(112, 25)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsPalabras
        ' 
        stsPalabras.Name = "stsPalabras"
        stsPalabras.Size = New System.Drawing.Size(96, 25)
        stsPalabras.Text = "Palabras: 0"
        ' 
        ' stsZoom
        ' 
        stsZoom.Name = "stsZoom"
        stsZoom.Size = New System.Drawing.Size(114, 25)
        stsZoom.Text = "Zoom: 100%"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New System.Drawing.Size(0, 25)
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        dlgAbrir.Title = "Abrir archivo"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        dlgGuardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        dlgGuardar.Title = "Guardar archivo"
        ' 
        ' dlgFuente
        ' 
        dlgFuente.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1143, 830)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        MinimumSize = New System.Drawing.Size(848, 629)
        Name = "frmBlocNotas"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        WindowState = System.Windows.Forms.FormWindowState.Maximized
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

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