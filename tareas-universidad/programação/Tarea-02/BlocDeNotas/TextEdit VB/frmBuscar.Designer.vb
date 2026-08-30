<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscar
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.chkMayusculas = New System.Windows.Forms.CheckBox()
        Me.btnBuscarSiguiente = New System.Windows.Forms.Button()
        Me.btnBuscarAnterior = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(12, 18)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(54, 15)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(72, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(240, 23)
        Me.txtBuscar.TabIndex = 1
        '
        'chkMayusculas
        '
        Me.chkMayusculas.AutoSize = True
        Me.chkMayusculas.Location = New System.Drawing.Point(72, 56)
        Me.chkMayusculas.Name = "chkMayusculas"
        Me.chkMayusculas.Size = New System.Drawing.Size(167, 19)
        Me.chkMayusculas.TabIndex = 2
        Me.chkMayusculas.Text = "Coincidir mayúsculas/minúsculas"
        '
        'btnBuscarSiguiente
        '
        Me.btnBuscarSiguiente.Location = New System.Drawing.Point(318, 14)
        Me.btnBuscarSiguiente.Name = "btnBuscarSiguiente"
        Me.btnBuscarSiguiente.Size = New System.Drawing.Size(110, 24)
        Me.btnBuscarSiguiente.TabIndex = 3
        Me.btnBuscarSiguiente.Text = "Buscar siguiente"
        Me.btnBuscarSiguiente.UseVisualStyleBackColor = True
        '
        'btnBuscarAnterior
        '
        Me.btnBuscarAnterior.Location = New System.Drawing.Point(318, 44)
        Me.btnBuscarAnterior.Name = "btnBuscarAnterior"
        Me.btnBuscarAnterior.Size = New System.Drawing.Size(110, 24)
        Me.btnBuscarAnterior.TabIndex = 4
        Me.btnBuscarAnterior.Text = "Buscar anterior"
        Me.btnBuscarAnterior.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(353, 83)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 24)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBuscar
        '
        Me.AcceptButton = Me.btnBuscarSiguiente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(440, 119)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnBuscarAnterior)
        Me.Controls.Add(Me.btnBuscarSiguiente)
        Me.Controls.Add(Me.chkMayusculas)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents chkMayusculas As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscarSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnBuscarAnterior As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

End Class
