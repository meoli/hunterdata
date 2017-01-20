Public Class Form1
    Dim exp As Integer
    Dim drop As Integer
    Dim job As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exp = 1
        job = 1
        drop = 1
        rateExp.Text = "x" + String.Concat(exp)
        rateJob.Text = "x" + String.Concat(job)
        rateDrop.Text = "x" + String.Concat(drop)
        Form2.Hide()


    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        

        Integer.TryParse(rateExp.Text, exp)
        Integer.TryParse(rateDrop.Text, drop)
        Integer.TryParse(rateJob.Text, job)

            rateDrop.Text = ""
            rateExp.Text = ""
            rateJob.Text = ""

            rateExp.Text = "x" + String.Concat(exp)
            rateJob.Text = "x" + String.Concat(job)
            rateDrop.Text = "x" + String.Concat(drop)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        searchName.Clear()
        rateDrop.Text = "x1"
        rateExp.Text = "x1"
        rateJob.Text = "x1"

        exp = 1
        job = 1
        drop = 1

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Form2.Show()

    End Sub
End Class
