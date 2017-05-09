Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'hola
        If Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "@" Or e.KeyChar = "-" Or e.KeyChar = "_" Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated

        If TextBox1.Text.Length < 1 Then
            MsgBox("ingrese correo")

        End If

        Dim primera As Char = TextBox1.Text.Substring(0, 1)
        Dim ultima As Char = TextBox1.Text.Substring(TextBox1.Text.Length - 1, 1)

        If primera = "@" Or primera = "." Then

        End If
    End Sub
End Class

