Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmBlocNotas

    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False
    Private modoOscuro As Boolean = False
    Private frmBusqueda As frmBuscar = Nothing

    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        mnuAjusteLinea.Checked = True

        tscbFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tscbFuente.SelectedIndex = 1
        tscbTamano.Items.AddRange(New String() {"8", "10", "11", "12", "14", "18", "24"})
        tscbTamano.SelectedIndex = 2

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub

    Private Sub frmBlocNotas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If documentoModificado Then
            Dim r = MessageBox.Show("¿Desea guardar los cambios antes de salir?",
                                     "Bloc de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf r = DialogResult.Yes Then
                If Not GuardarDocumento(False) Then e.Cancel = True
            End If
        End If
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub

    ' ===== MenuStrip: Archivo =====

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
        GuardarDocumento(True)
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    ' ===== MenuStrip: Edición y Formato =====

    Private Sub mnuDeshacer_Click(sender As Object, e As EventArgs) Handles mnuDeshacer.Click
        If rtbDocumento.CanUndo Then rtbDocumento.Undo()
    End Sub

    Private Sub mnuRehacer_Click(sender As Object, e As EventArgs) Handles mnuRehacer.Click
        If rtbDocumento.CanRedo Then rtbDocumento.Redo()
    End Sub

    Private Sub mnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub mnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub mnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub mnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles mnuSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles mnuFuente.Click
        dlgFuente.Font = ObtenerFuenteActual()
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    Private Sub mnuColorTexto_Click(sender As Object, e As EventArgs) Handles mnuColorTexto.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub mnuAjusteLinea_Click(sender As Object, e As EventArgs) Handles mnuAjusteLinea.Click
        rtbDocumento.WordWrap = mnuAjusteLinea.Checked
    End Sub

    ' ===== MenuStrip: Ver y Ayuda =====

    Private Sub mnuZoomMas_Click(sender As Object, e As EventArgs) Handles mnuZoomMas.Click
        If rtbDocumento.ZoomFactor < 4.0F Then rtbDocumento.ZoomFactor += 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomMenos_Click(sender As Object, e As EventArgs) Handles mnuZoomMenos.Click
        If rtbDocumento.ZoomFactor > 0.3F Then rtbDocumento.ZoomFactor -= 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomRestablecer_Click(sender As Object, e As EventArgs) Handles mnuZoomRestablecer.Click
        rtbDocumento.ZoomFactor = 1.0F
        ActualizarBarraEstado()
    End Sub

    ' ===== MenuStrip: Ver -> Tema oscuro =====

    Private Sub mnuTemaOscuro_Click(sender As Object, e As EventArgs) Handles mnuTemaOscuro.Click
        modoOscuro = mnuTemaOscuro.Checked
        AplicarTema()
    End Sub

    ' ===== MenuStrip: Herramientas =====

    Private Sub mnuBuscar_Click(sender As Object, e As EventArgs) Handles mnuBuscar.Click
        If frmBusqueda Is Nothing OrElse frmBusqueda.IsDisposed Then
            frmBusqueda = New frmBuscar()
            frmBusqueda.Documento = rtbDocumento
        End If
        frmBusqueda.Show(Me)
        frmBusqueda.BringToFront()
    End Sub

    Private Sub mnuContarPalabras_Click(sender As Object, e As EventArgs) Handles mnuContarPalabras.Click
        Dim palabras As Integer = ContarPalabras()
        MessageBox.Show("El documento contiene " & palabras & " palabra(s)." & vbCrLf &
                        "Caracteres: " & rtbDocumento.TextLength,
                        "Contar palabras", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuContarCaracteres_Click(sender As Object, e As EventArgs) Handles mnuContarCaracteres.Click
        MessageBox.Show("El documento contiene " & rtbDocumento.TextLength & " carácter(es)." & vbCrLf &
                        "Palabras: " & ContarPalabras(),
                        "Contar caracteres", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show("Bloc de Notas VB.NET" & vbCrLf & "Ejemplo académico - MenuStrip/ToolStrip/StatusStrip",
                         "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ===== ToolStrip: Botones y combos de formato =====

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tsbCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tsbCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tsbPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFuente.SelectedIndexChanged
        Dim fuenteActual As Font = ObtenerFuenteActual()
        Dim tamano As Single = fuenteActual.Size
        rtbDocumento.SelectionFont = New Font(tscbFuente.Text, tamano, fuenteActual.Style)
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTamano.SelectedIndexChanged
        Dim fuenteActual As Font = ObtenerFuenteActual()
        Dim tam As Single = Convert.ToSingle(tscbTamano.Text)
        rtbDocumento.SelectionFont = New Font(fuenteActual.FontFamily, tam, fuenteActual.Style)
    End Sub

    ' Combina o quita un estilo de fuente sobre el texto seleccionado
    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub
        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If
        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    Private Function ObtenerFuenteActual() As Font
        Return If(rtbDocumento.SelectionFont, rtbDocumento.Font)
    End Function

    ' ===== ContextMenuStrip: Menú contextual del área de texto =====

    Private Sub cmsTexto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTexto.Opening
        Dim haySeleccion As Boolean = rtbDocumento.SelectionLength > 0
        cmsCortar.Enabled = haySeleccion
        cmsCopiar.Enabled = haySeleccion
        cmsPegar.Enabled = Clipboard.ContainsText()
    End Sub

    Private Sub cmsCortar_Click(sender As Object, e As EventArgs) Handles cmsCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub cmsCopiar_Click(sender As Object, e As EventArgs) Handles cmsCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub cmsPegar_Click(sender As Object, e As EventArgs) Handles cmsPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub cmsSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles cmsSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub cmsFuente_Click(sender As Object, e As EventArgs) Handles cmsFuente.Click
        dlgFuente.Font = ObtenerFuenteActual()
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    ' ===== StatusStrip: Información de estado en tiempo real =====

    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub

    Private Sub ActualizarBarraEstado()
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
        Dim inicioLinea As Integer = rtbDocumento.GetFirstCharIndexOfCurrentLine()
        Dim columna As Integer = rtbDocumento.SelectionStart - inicioLinea + 1

        stsPosicion.Text = $"Línea: {linea}   Columna: {columna}"
        stsCaracteres.Text = $"Caracteres: {rtbDocumento.TextLength}"
        stsPalabras.Text = $"Palabras: {ContarPalabras()}"
        stsZoom.Text = $"Zoom: {CInt(rtbDocumento.ZoomFactor * 100)}%"
        stsEstado.Text = If(documentoModificado, "Modificado", "Listo")
    End Sub

    ' ===== Funciones auxiliares comunes (Nuevo / Abrir / Guardar) =====

    Private Function ContarPalabras() As Integer
        Dim texto As String = rtbDocumento.Text
        If String.IsNullOrWhiteSpace(texto) Then Return 0
        Dim partes As String() = texto.Split(New Char() {" "c, ControlChars.Tab, ControlChars.Cr, ControlChars.Lf},
                                              StringSplitOptions.RemoveEmptyEntries)
        Return partes.Length
    End Function

    ' ===== Tema (claro / oscuro) =====

    Private Sub AplicarTema()
        If modoOscuro Then
            Me.BackColor = Color.FromArgb(30, 30, 30)
            mnuPrincipal.BackColor = Color.FromArgb(45, 45, 48)
            mnuPrincipal.ForeColor = Color.White
            tsPrincipal.BackColor = Color.FromArgb(45, 45, 48)
            tsPrincipal.ForeColor = Color.White
            stsInferior.BackColor = Color.FromArgb(45, 45, 48)
            stsInferior.ForeColor = Color.White
            rtbDocumento.BackColor = Color.FromArgb(30, 30, 30)
            rtbDocumento.ForeColor = Color.White

            tsPrincipal.Renderer = New ToolStripProfessionalRenderer(New TemaOscuroColorTable())
            mnuPrincipal.Renderer = New ToolStripProfessionalRenderer(New TemaOscuroColorTable())
            stsInferior.Renderer = New ToolStripProfessionalRenderer(New TemaOscuroColorTable())
            cmsTexto.Renderer = New ToolStripProfessionalRenderer(New TemaOscuroColorTable())
        Else
            Me.BackColor = SystemColors.Control
            mnuPrincipal.BackColor = SystemColors.Control
            mnuPrincipal.ForeColor = SystemColors.ControlText
            tsPrincipal.BackColor = SystemColors.Control
            tsPrincipal.ForeColor = SystemColors.ControlText
            stsInferior.BackColor = SystemColors.Control
            stsInferior.ForeColor = SystemColors.ControlText
            rtbDocumento.BackColor = Color.White
            rtbDocumento.ForeColor = Color.Black

            tsPrincipal.Renderer = New ToolStripProfessionalRenderer()
            mnuPrincipal.Renderer = New ToolStripProfessionalRenderer()
            stsInferior.Renderer = New ToolStripProfessionalRenderer()
            cmsTexto.Renderer = New ToolStripProfessionalRenderer()

            For Each item As ToolStripItem In mnuPrincipal.Items
                item.ForeColor = SystemColors.ControlText
            Next
        End If
        ActualizarBarraEstado()
    End Sub

    Private Sub NuevoDocumento()
        If documentoModificado Then
            Dim r = MessageBox.Show("¿Desea guardar los cambios antes de continuar?",
                                     "Bloc de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Cancel Then Exit Sub
            If r = DialogResult.Yes Then GuardarDocumento(False)
        End If
        rtbDocumento.Clear()
        rutaActual = String.Empty
        documentoModificado = False
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
        ActualizarBarraEstado()
    End Sub

    Private Sub AbrirDocumento()
        If dlgAbrir.ShowDialog() = DialogResult.OK Then
            rtbDocumento.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText)
            rutaActual = dlgAbrir.FileName
            documentoModificado = False
            Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
            ActualizarBarraEstado()
        End If
    End Sub

    Private Function GuardarDocumento(forzarDialogo As Boolean) As Boolean
        If String.IsNullOrEmpty(rutaActual) OrElse forzarDialogo Then
            If dlgGuardar.ShowDialog() = DialogResult.OK Then
                rutaActual = dlgGuardar.FileName
            Else
                Return False
            End If
        End If
        rtbDocumento.SaveFile(rutaActual, RichTextBoxStreamType.PlainText)
        documentoModificado = False
        Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
        stsEstado.Text = "Guardado correctamente"
        Return True
    End Function

End Class

Public Class TemaOscuroColorTable
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return Color.FromArgb(80, 80, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return Color.FromArgb(51, 153, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return Color.FromArgb(62, 62, 66)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return Color.FromArgb(62, 62, 66)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return Color.FromArgb(62, 62, 66)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripBorder As Color
        Get
            Return Color.FromArgb(80, 80, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientMiddle As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return Color.FromArgb(45, 45, 48)
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark As Color
        Get
            Return Color.FromArgb(80, 80, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorLight As Color
        Get
            Return Color.FromArgb(80, 80, 80)
        End Get
    End Property
End Class