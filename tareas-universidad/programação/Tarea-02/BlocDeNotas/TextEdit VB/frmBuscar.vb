Imports System.Windows.Forms

Public Class frmBuscar

    Private _documento As RichTextBox
    Private _inicioUltimaBusqueda As Integer = 0

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property Documento() As RichTextBox
        Get
            Return _documento
        End Get
        Set(ByVal value As RichTextBox)
            _documento = value
        End Set
    End Property

    Private Sub frmBuscar_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtBuscar.Focus()
        If _documento IsNot Nothing AndAlso _documento.SelectionLength > 0 Then
            txtBuscar.Text = _documento.SelectedText
            txtBuscar.SelectAll()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        _inicioUltimaBusqueda = 0
    End Sub

    Private Sub btnBuscarSiguiente_Click(sender As Object, e As EventArgs) Handles btnBuscarSiguiente.Click
        Buscar(1)
    End Sub

    Private Sub btnBuscarAnterior_Click(sender As Object, e As EventArgs) Handles btnBuscarAnterior.Click
        Buscar(-1)
    End Sub

    Private Sub Buscar(direccion As Integer)
        If _documento Is Nothing Then Exit Sub
        Dim texto As String = txtBuscar.Text
        If String.IsNullOrEmpty(texto) Then
            MessageBox.Show("Escriba el texto que desea buscar.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtBuscar.Focus()
            Exit Sub
        End If

        Dim opciones As RichTextBoxFinds = RichTextBoxFinds.None
        If chkMayusculas.Checked Then
            opciones = RichTextBoxFinds.MatchCase
        End If

        Dim indice As Integer
        If direccion > 0 Then
            indice = _documento.Find(texto, _inicioUltimaBusqueda, opciones)
        Else
            indice = _documento.Find(texto, _inicioUltimaBusqueda, _documento.TextLength, opciones Or RichTextBoxFinds.Reverse)
        End If

        If indice >= 0 Then
            _documento.Select(indice, texto.Length)
            _documento.ScrollToCaret()
            _inicioUltimaBusqueda = indice + texto.Length
        Else
            _inicioUltimaBusqueda = 0
            MessageBox.Show("No se encontró el texto especificado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        _documento.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
