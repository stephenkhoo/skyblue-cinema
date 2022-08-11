Public Class frmamountpayablepage
    Public total As Double
    Public aftertaxPrice As Double
    Const taxrate As Integer = 0.06
    Private Sub frmpaymentpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        total = (frmFoodPage.SnackTotal + frmDrinkPage.DrinkTotal)
        aftertaxPrice = total * (1 + 0.06)
        lblpayamount.Hide()
        lblpayamount.Text() = Math.Round(aftertaxPrice, 2)
        lblpayamount.Show()
        lblGst.Hide()
        lblGst.Text() = Math.Round(total * 0.06, 2)
        lblGst.Show()
    End Sub

    Private Sub lblGstDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGstDescription.Click

    End Sub

    Private Sub btnpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmakepayment.Click
        Me.Hide()
        frmpaymentpage.Show()
    End Sub
End Class