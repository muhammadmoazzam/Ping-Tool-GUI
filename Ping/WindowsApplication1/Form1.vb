Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button2
        Button2.Focus()
        Try
            If My.Computer.Network.Ping("8.8.8.8") Then
                TextBox2.ForeColor = Color.Green
                TextBox2.Text = "Auto-Ping Host Pass"
            Else
                TextBox2.ForeColor = Color.Red
                TextBox2.Text = "Auto-Ping Host Failed"
            End If
        Catch ex As Exception
            textbox2.ForeColor = Color.Red
            textbox2.Text = ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If My.Computer.Network.Ping("8.8.8.8") Then
                TextBox2.ForeColor = Color.Green
                TextBox2.Text = "Auto-Ping Host Pass"
            Else
                TextBox2.ForeColor = Color.Red
                TextBox2.Text = "Auto-Ping Host Failed"
            End If
        Catch ex As System.Net.NetworkInformation.PingException
            TextBox2.ForeColor = Color.Red
            TextBox2.Text = ex.Message
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.ForeColor = Color.Black
        TextBox2.Text = "Pinging..."
        If TextBox1.Text = "" Then
            TextBox2.ForeColor = Color.Red

            TextBox2.Text = "Address cannot be null."
        Else
            Try
                If My.Computer.Network.Ping(TextBox1.Text, NumericUpDown1.Text) Then
                    TextBox2.ForeColor = Color.Green
                    TextBox2.Text = "Ping Host Pass"

                Else
                    TextBox2.ForeColor = Color.Red
                    TextBox2.Text = "Ping Host Failed"
                End If
            Catch ex As System.Net.NetworkInformation.PingException

                TextBox2.ForeColor = Color.Red
                TextBox2.Text = ex.Message
            End Try
        End If
    End Sub
End Class
