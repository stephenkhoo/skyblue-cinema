Public Class frmDrinkPage
    Dim coke As Double
    Dim lemonade As Double
    Dim mountaindew As Double
    Dim orangejuice As Double
    Public DrinkTotal As Double
    Private Sub chkbxcoke_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxcoke.CheckedChanged
        If chkbxcoke.Checked = True Then
            txtCoke.Enabled = True
        Else
            txtCoke.Enabled = False
        End If
    End Sub

    Private Sub chkbxlemonade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxlemonade.CheckedChanged
        If chkbxlemonade.Checked = True Then
            txtLemonade.Enabled = True
        Else
            txtLemonade.Enabled = False
        End If
    End Sub

    Private Sub ChkBxMountainDew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBxMountainDew.CheckedChanged
        If ChkBxMountainDew.Checked = True Then
            txtMountainDew.Enabled = True
        Else
            txtMountainDew.Enabled = False
        End If
    End Sub

    Private Sub ChkBxOrangeJuice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBxOrangeJuice.CheckedChanged
        If ChkBxOrangeJuice.Checked = True Then
            txtOrangeJuice.Enabled = True
        Else
            txtOrangeJuice.Enabled = False
        End If
    End Sub
    'Selection and calculation for Drink.
    Private Sub btnShowPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        If chkbxcoke.Checked = False Then
            txtCoke.Text() = 0
        Else
            If txtCoke.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Coke")
            Else
                coke = txtCoke.Text()
            End If
        End If

        If chkbxlemonade.Checked = False Then
            txtLemonade.Text() = 0
        Else
            If txtLemonade.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Lemonade")
            Else
                lemonade = txtLemonade.Text()
            End If
        End If

        If ChkBxMountainDew.Checked = False Then
            txtMountainDew.Text() = 0
        Else
            If txtMountainDew.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Mountain Dew")
            Else
                mountaindew = txtMountainDew.Text()
            End If
        End If

        If ChkBxOrangeJuice.Checked = False Then
            txtOrangeJuice.Text() = 0
        Else
            If txtOrangeJuice.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Orange juice")
            Else
                orangejuice = txtOrangeJuice.Text()
            End If
        End If

        If txtCoke.Text() <> Nothing And txtLemonade.Text() <> Nothing And txtMountainDew.Text() <> Nothing And txtOrangeJuice.Text() <> Nothing Then
            DrinkTotal = coke * 2.99 + lemonade * 3.99 + mountaindew * 2.5 + orangejuice * 4.99
            Me.Hide()
            frmamountpayablepage.Show()
        End If
    End Sub

    Private Sub txtCoke_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCoke.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtLemonade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLemonade.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMountainDew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMountainDew.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtOrangeJuice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrangeJuice.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Reset()
        coke = Empty
        lemonade = Empty
        mountaindew = Empty
        orangejuice = Empty
    End Sub
End Class
