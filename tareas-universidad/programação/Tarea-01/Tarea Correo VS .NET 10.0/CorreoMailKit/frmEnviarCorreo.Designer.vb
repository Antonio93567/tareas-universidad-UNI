<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnviarCorreo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New System.ComponentModel.Container()
        ofdAdjuntos = New OpenFileDialog()
        lblPara = New Label()
        txtPara = New TextBox()
        lblCCO = New Label()
        txtCCO = New TextBox()
        lblAsunto = New Label()
        txtAsunto = New TextBox()
        lblCuerpo = New Label()
        txtCuerpo = New TextBox()
        lblAdjuntos = New Label()
        lstAdjuntos = New ListBox()
        btnAgregarAdjunto = New Button()
        btnQuitarAdjunto = New Button()
        pbEnvio = New ProgressBar()
        lblEstado = New Label()
        btnEnviar = New Button()
        btnCerrar = New Button()
        SuspendLayout()

        'lblPara
        lblPara.AutoSize = True
        lblPara.Location = New Point(20, 20)
        lblPara.Name = "lblPara"
        lblPara.Text = "Enviar a:"

        'txtPara
        txtPara.Location = New Point(20, 38)
        txtPara.Name = "txtPara"
        txtPara.Size = New Size(520, 23)
        txtPara.TabIndex = 0

        'lblCCO
        lblCCO.AutoSize = True
        lblCCO.Location = New Point(20, 66)
        lblCCO.Name = "lblCCO"
        lblCCO.Text = "CCO (copia oculta):"

        'txtCCO
        txtCCO.Location = New Point(20, 84)
        txtCCO.Name = "txtCCO"
        txtCCO.Size = New Size(520, 23)
        txtCCO.TabIndex = 1

        'lblAsunto
        lblAsunto.AutoSize = True
        lblAsunto.Location = New Point(20, 112)
        lblAsunto.Name = "lblAsunto"
        lblAsunto.Text = "Asunto:"

        'txtAsunto
        txtAsunto.Location = New Point(20, 130)
        txtAsunto.Name = "txtAsunto"
        txtAsunto.Size = New Size(520, 23)
        txtAsunto.TabIndex = 2

        'lblCuerpo
        lblCuerpo.AutoSize = True
        lblCuerpo.Location = New Point(20, 158)
        lblCuerpo.Name = "lblCuerpo"
        lblCuerpo.Text = "Cuerpo del correo:"

        'txtCuerpo
        txtCuerpo.Location = New Point(20, 176)
        txtCuerpo.Multiline = True
        txtCuerpo.Name = "txtCuerpo"
        txtCuerpo.ScrollBars = ScrollBars.Vertical
        txtCuerpo.Size = New Size(520, 150)
        txtCuerpo.TabIndex = 3

        'lblAdjuntos
        lblAdjuntos.AutoSize = True
        lblAdjuntos.Location = New Point(20, 332)
        lblAdjuntos.Name = "lblAdjuntos"
        lblAdjuntos.Text = "Archivos adjuntos:"

        'lstAdjuntos
        lstAdjuntos.FormattingEnabled = True
        lstAdjuntos.Location = New Point(20, 350)
        lstAdjuntos.Name = "lstAdjuntos"
        lstAdjuntos.Size = New Size(400, 80)
        lstAdjuntos.TabIndex = 4

        'btnAgregarAdjunto
        btnAgregarAdjunto.Location = New Point(432, 350)
        btnAgregarAdjunto.Name = "btnAgregarAdjunto"
        btnAgregarAdjunto.Size = New Size(108, 25)
        btnAgregarAdjunto.TabIndex = 5
        btnAgregarAdjunto.Text = "Agregar..."

        'btnQuitarAdjunto
        btnQuitarAdjunto.Location = New Point(432, 381)
        btnQuitarAdjunto.Name = "btnQuitarAdjunto"
        btnQuitarAdjunto.Size = New Size(108, 25)
        btnQuitarAdjunto.TabIndex = 6
        btnQuitarAdjunto.Text = "Quitar"

        'ofdAdjuntos
        ofdAdjuntos.Multiselect = True
        ofdAdjuntos.Title = "Seleccionar archivos adjuntos"

        'pbEnvio
        pbEnvio.Location = New Point(20, 442)
        pbEnvio.Name = "pbEnvio"
        pbEnvio.Size = New Size(520, 20)
        pbEnvio.Style = ProgressBarStyle.Marquee
        pbEnvio.TabIndex = 7
        pbEnvio.Visible = False

        'lblEstado
        lblEstado.AutoSize = True
        lblEstado.ForeColor = Color.DarkBlue
        lblEstado.Location = New Point(20, 470)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(0, 15)
        lblEstado.TabIndex = 8
        lblEstado.Text = ""

        'btnEnviar
        btnEnviar.BackColor = Color.LightGreen
        btnEnviar.FlatStyle = FlatStyle.Standard
        btnEnviar.Location = New Point(352, 500)
        btnEnviar.Name = "btnEnviar"
        btnEnviar.Size = New Size(100, 25)
        btnEnviar.TabIndex = 9
        btnEnviar.Text = "Enviar"
        btnEnviar.UseVisualStyleBackColor = False

        'btnCerrar
        btnCerrar.Location = New Point(462, 500)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(100, 25)
        btnCerrar.TabIndex = 10
        btnCerrar.Text = "Cerrar"

        'frmEnviarCorreo
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 560)
        Controls.Add(btnCerrar)
        Controls.Add(btnEnviar)
        Controls.Add(lblEstado)
        Controls.Add(pbEnvio)
        Controls.Add(btnQuitarAdjunto)
        Controls.Add(btnAgregarAdjunto)
        Controls.Add(lstAdjuntos)
        Controls.Add(lblAdjuntos)
        Controls.Add(txtCuerpo)
        Controls.Add(lblCuerpo)
        Controls.Add(txtAsunto)
        Controls.Add(lblAsunto)
        Controls.Add(txtCCO)
        Controls.Add(lblCCO)
        Controls.Add(txtPara)
        Controls.Add(lblPara)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmEnviarCorreo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Enviar Correo - MailKit"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblPara As Label
    Friend WithEvents txtPara As TextBox
    Friend WithEvents lblCCO As Label
    Friend WithEvents txtCCO As TextBox
    Friend WithEvents lblAsunto As Label
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents lblCuerpo As Label
    Friend WithEvents txtCuerpo As TextBox
    Friend WithEvents lblAdjuntos As Label
    Friend WithEvents lstAdjuntos As ListBox
    Friend WithEvents btnAgregarAdjunto As Button
    Friend WithEvents btnQuitarAdjunto As Button
    Friend WithEvents pbEnvio As ProgressBar
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents ofdAdjuntos As OpenFileDialog

End Class
