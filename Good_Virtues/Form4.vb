Public Class pg14
    Private Sub Pic_PreviousPage_Click(sender As Object, e As EventArgs) Handles Pic_PreviousPage.Click

    End Sub

    Private Sub btn_BestPark_Click(sender As Object, e As EventArgs) Handles btn_BestPark.Click
        Pic_BestPark.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pic_BestPark.Hide()
    End Sub
End Class