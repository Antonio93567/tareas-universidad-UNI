Imports System.Configuration
Imports System.IO
Imports MailKit.Net.Smtp
Imports MailKit.Security
Imports MimeKit

Public Class frmEnviarCorreo

    ' Lista interna que guarda las rutas completas de los archivos adjuntos
    Private listaRutasAdjuntos As New List(Of String)

    Private Sub frmEnviarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbEnvio.Visible = False
        lblEstado.Text = String.Empty
        ofdAdjuntos.Multiselect = True
        ofdAdjuntos.Title = "Seleccionar archivos adjuntos"
    End Sub

    ' ---------------------------------------------------------
    ' EVENTO: Agregar archivo(s) adjunto(s)
    ' ---------------------------------------------------------
    Private Sub btnAgregarAdjunto_Click(sender As Object, e As EventArgs) Handles btnAgregarAdjunto.Click
        If ofdAdjuntos.ShowDialog() = DialogResult.OK Then
            For Each archivo As String In ofdAdjuntos.FileNames
                If Not listaRutasAdjuntos.Contains(archivo) Then
                    listaRutasAdjuntos.Add(archivo)
                    lstAdjuntos.Items.Add(Path.GetFileName(archivo))
                End If
            Next
        End If
    End Sub

    ' ---------------------------------------------------------
    ' EVENTO: Quitar archivo adjunto seleccionado
    ' ---------------------------------------------------------
    Private Sub btnQuitarAdjunto_Click(sender As Object, e As EventArgs) Handles btnQuitarAdjunto.Click
        If lstAdjuntos.SelectedIndex >= 0 Then
            Dim indice As Integer = lstAdjuntos.SelectedIndex
            listaRutasAdjuntos.RemoveAt(indice)
            lstAdjuntos.Items.RemoveAt(indice)
        Else
            MessageBox.Show("Seleccione un archivo de la lista para quitarlo.", "Aviso",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ---------------------------------------------------------
    ' EVENTO: Enviar correo (asíncrono)
    ' ---------------------------------------------------------
    Private Async Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        ' Validaciones básicas
        If String.IsNullOrWhiteSpace(txtPara.Text) Then
            MessageBox.Show("Debe ingresar al menos un correo destinatario.", "Validación",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAsunto.Text) Then
            MessageBox.Show("Debe ingresar un asunto.", "Validación",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Bloquear controles y mostrar progreso
            HabilitarControles(False)
            pbEnvio.Visible = True
            pbEnvio.Style = ProgressBarStyle.Marquee
            lblEstado.Text = "Enviando correo, por favor espere..."
            lblEstado.ForeColor = Color.DarkBlue

            Await EnviarCorreoAsync(
                txtPara.Text.Trim(),
                txtCCO.Text.Trim(),
                txtAsunto.Text.Trim(),
                txtCuerpo.Text,
                listaRutasAdjuntos
            )

            lblEstado.Text = "Correo enviado correctamente."
            lblEstado.ForeColor = Color.Green
            MessageBox.Show("El correo se envió correctamente.", "Éxito",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        Catch ex As Exception
            lblEstado.Text = "Error al enviar el correo."
            lblEstado.ForeColor = Color.Red
            MessageBox.Show("Ocurrió un error al enviar el correo:" & Environment.NewLine & ex.Message,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            pbEnvio.Visible = False
            HabilitarControles(True)
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' MÉTODO: Envío del correo usando MailKit (async)
    ' ---------------------------------------------------------
    Private Async Function EnviarCorreoAsync(destinatarios As String,
                                              cco As String,
                                              asunto As String,
                                              cuerpo As String,
                                              adjuntos As List(Of String)) As Task

        ' Datos de la cuenta remitente (Gmail), leídos desde App.config
        Dim correoOrigen As String = ConfigurationManager.AppSettings("CorreoOrigen")
        Dim claveAplicacion As String = ConfigurationManager.AppSettings("ClaveAplicacion")
        Dim nombreRemitente As String = ConfigurationManager.AppSettings("NombreRemitente")

        Dim mensaje As New MimeMessage()
        mensaje.From.Add(New MailboxAddress(nombreRemitente, correoOrigen))

        ' Agregar destinatarios principales (separados por ; o ,)
        For Each correo As String In destinatarios.Split(New Char() {";"c, ","c},
                                                           StringSplitOptions.RemoveEmptyEntries)
            mensaje.To.Add(MailboxAddress.Parse(correo.Trim()))
        Next

        ' Agregar destinatarios en copia oculta (CCO), si se especificaron
        If Not String.IsNullOrWhiteSpace(cco) Then
            For Each correoOculto As String In cco.Split(New Char() {";"c, ","c},
                                                          StringSplitOptions.RemoveEmptyEntries)
                mensaje.Bcc.Add(MailboxAddress.Parse(correoOculto.Trim()))
            Next
        End If

        mensaje.Subject = asunto

        ' Construcción del cuerpo del mensaje (con soporte para adjuntos)
        Dim generadorCuerpo As New BodyBuilder()
        generadorCuerpo.TextBody = cuerpo
        ' Si prefieres enviar el cuerpo en formato HTML, usar:
        ' generadorCuerpo.HtmlBody = "<p>" & cuerpo & "</p>"

        If adjuntos IsNot Nothing Then
            For Each rutaArchivo As String In adjuntos
                If File.Exists(rutaArchivo) Then
                    generadorCuerpo.Attachments.Add(rutaArchivo)
                End If
            Next
        End If

        mensaje.Body = generadorCuerpo.ToMessageBody()

        ' Envío mediante SmtpClient de MailKit
        Using cliente As New SmtpClient()
            ' Conexión segura con Gmail (STARTTLS en puerto 587)
            Await cliente.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls)

            ' Autenticación con contraseña de aplicación
            Await cliente.AuthenticateAsync(correoOrigen, claveAplicacion)

            Await cliente.SendAsync(mensaje)

            Await cliente.DisconnectAsync(True)
        End Using

    End Function

    ' ---------------------------------------------------------
    ' MÉTODO: Habilitar/Deshabilitar controles durante el envío
    ' ---------------------------------------------------------
    Private Sub HabilitarControles(estado As Boolean)
        txtPara.Enabled = estado
        txtCCO.Enabled = estado
        txtAsunto.Enabled = estado
        txtCuerpo.Enabled = estado
        lstAdjuntos.Enabled = estado
        btnAgregarAdjunto.Enabled = estado
        btnQuitarAdjunto.Enabled = estado
        btnEnviar.Enabled = estado
        btnCerrar.Enabled = estado
    End Sub

    ' ---------------------------------------------------------
    ' MÉTODO: Limpiar todos los campos tras un envío exitoso
    ' ---------------------------------------------------------
    Private Sub LimpiarCampos()
        txtPara.Clear()
        txtCCO.Clear()
        txtAsunto.Clear()
        txtCuerpo.Clear()
        lstAdjuntos.Items.Clear()
        listaRutasAdjuntos.Clear()
        txtPara.Focus()
    End Sub

    ' ---------------------------------------------------------
    ' EVENTO: Cerrar formulario
    ' ---------------------------------------------------------
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim confirmar As DialogResult = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmar",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmar = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class