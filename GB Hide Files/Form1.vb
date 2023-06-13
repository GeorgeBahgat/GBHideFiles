



Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Please select the image format!", MsgBoxStyle.Critical)
        Else
            Shell("cmd.exe /k" + "copy /b " + TextBox1.Text + "." + ComboBox1.Text + "+" + TextBox2.Text + "." + TextBox3.Text + " " + TextBox1.Text + "." + ComboBox1.Text)
            Timer1.Start()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim proc = Process.GetProcessesByName("cmd")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Width = PictureBox2.Width + 10
        PictureBox2.Show()
        If PictureBox2.Width = "300" Then
            Dim proc = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i
        End If
        If PictureBox2.Width = "430" Then
            Timer1.Stop()
            MsgBox("File Successfully Hidden !", vbInformation)
            PictureBox2.Width = "10"
            PictureBox2.Hide()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
    End Sub
End Class
