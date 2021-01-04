Public Class Form1


    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Housing As Double = CSng(txtHousing.Text)
        Dim Food As Double = CSng(txtFood.Text)
        Dim Transportation As Double = CSng(txtTransportation.Text)
        Dim Other As Double = CSng(txtOther.Text)

        Dim legend() As String = {"Housing", "Transportation", "Food", "Other"}
        Dim quantity() As Single = {Housing, Transportation, Food, Other}
        Dim percent(quantity.Count - 1) As Single
        Dim sumOfQuantities As Single = 0
        Dim sumOfSweepAngles As Single = 0
        Dim br() As Brush = {Brushes.Blue, Brushes.Red, Brushes.Green, Brushes.Orange}
        Dim gr As Graphics = picBox.CreateGraphics
        Dim r As Integer = 100
        Dim c As Integer = 105

        For i As Integer = 0 To (quantity.Count - 1)
            sumOfQuantities += quantity(i)
        Next

        For i As Integer = 0 To quantity.Count - 1
            percent(i) = quantity(i) / sumOfQuantities
        Next

        For i As Integer = 0 To (quantity.Count - 1)
            gr.FillPie(br(i), c - r, c - r, 2 * r, 2 * r, sumOfSweepAngles, percent(i) * 360)
            sumOfSweepAngles += percent(i) * 360

            gr.FillRectangle(br(i), 220, 20 + 30 * i, 20, 20)
            gr.DrawString(legend(i), Me.Font, Brushes.Black, 250, 22 + 30 * i)



        Next

    End Sub
End Class
