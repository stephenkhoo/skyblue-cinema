Public Class frmpaymentpage
    Dim balance As Double
    Dim paid As Double
    Dim change As Double
    Dim userinput As String
    Private Sub txtpayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayment.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 45 Then
        Else
            e.Handled = True
        End If
    End Sub
    'Calculation for payment, balance,change.Error when negative value enter.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        If txtpayment.Text() < 0 Then
            MsgBox("Error,Please enter the amount again.")
        Else
            If txtpayment.Text() <= frmamountpayablepage.aftertaxPrice Then
                paid = paid + txtpayment.Text()
                balance = frmamountpayablepage.aftertaxPrice - paid
                If balance > 0 Then
                    MsgBox("Your payment is insufficient,please insert another $" & Math.Round(balance, 2))
                ElseIf balance = 0 Then
                    MsgBox("You have fully paid")

                    Do
                        userinput = InputBox("Do you want to make a new selection?")
                    Loop Until (userinput = "-1")
                    MsgBox("Thank you for using SkyBlue ordering system.")
                    Me.Hide()
                Else : MsgBox("You have fully paid, Your change is" & Math.Round(0 - balance, 2))
                    Do
                        userinput = InputBox("Do you want to make a new selection?")
                    Loop Until (userinput = "-1")
                    MsgBox("Thank you for using SkyBlue ordering system.")
                    Me.Hide()
                End If
            Else
                If frmamountpayablepage.aftertaxPrice < txtpayment.Text() Then
                    change = txtpayment.Text() - (frmamountpayablepage.aftertaxPrice)
                    MsgBox("Your change is $" & Math.Round(change, 2))
                    Do
                        userinput = InputBox("Do you want to make a new selection?")
                    Loop Until (userinput = "-1")
                    MsgBox("Thank you for using SkyBlue ordering system.")
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub frmpaymentpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class