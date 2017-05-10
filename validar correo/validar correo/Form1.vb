Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'validar entrada de: .,@,- etc 
        If Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "@" And Not e.KeyChar = "-" And Not e.KeyChar = "_" Then

            e.Handled = True
        End If


    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated

        If TextBox1.Text.Length < 1 Then
            TextBox2.Text = "INGRESE CORREO"

            Exit Sub

        End If

        Dim primera As Char = TextBox1.Text.Substring(0, 1)
        Dim ultima As Char = TextBox1.Text.Substring(TextBox1.Text.Length - 1, 1)

        If primera = "@" Or primera = "." Then

        End If
    End Sub
End Class

