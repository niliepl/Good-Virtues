Imports System.Diagnostics
Public Class Form6
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim youtubeUrl As String = "https://youtu.be/m0GcZ24pK6k?feature=shared"
        Dim psi As New ProcessStartInfo
        psi.UseShellExecute = True
        psi.FileName = youtubeUrl
        Process.Start(psi)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim youtubeUrl As String = "https://youtu.be/BRfxI2Es2lE?feature=shared"
        Dim psi As New ProcessStartInfo
        psi.UseShellExecute = True
        psi.FileName = youtubeUrl
        Process.Start(psi)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim youtubeUrl As String = "https://youtu.be/r6MBg8-FlD4?feature=shared"
        Dim psi As New ProcessStartInfo
        psi.UseShellExecute = True
        psi.FileName = youtubeUrl
        Process.Start(psi)
    End Sub
    Dim count As Integer = 0
    Sub CheckAllDone()
        ' Enable the "Done All" button only when all three exercises are marked as done
        If count = 3 Then
            btn_DoneAll.Enabled = True
        End If
    End Sub
    Private Sub btn_Done1_Click(sender As Object, e As EventArgs) Handles btn_Done1.Click
        btn_Done1.Enabled = False
        count += 1
        CheckAllDone()
    End Sub
    Private Sub btn_Done2_Click(sender As Object, e As EventArgs) Handles btn_Done2.Click
        btn_Done2.Enabled = False
        count += 1
        CheckAllDone()
    End Sub

    Private Sub btn_Done3_Click(sender As Object, e As EventArgs) Handles btn_Done3.Click
        btn_Done3.Enabled = False
        count += 1
        CheckAllDone()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Done1.Enabled = True
        btn_Done2.Enabled = True
        btn_Done3.Enabled = True
        btn_DoneAll.Enabled = False
    End Sub
    Private Sub btn_DoneAll_Click(sender As Object, e As EventArgs) Handles btn_DoneAll.Click
        MsgBox("Hurray! You've accomplished all exercises. Keep up the good work!", vbEmpty, "Exercise Completion! ")
        btn_DoneAll.Enabled = False
    End Sub
End Class