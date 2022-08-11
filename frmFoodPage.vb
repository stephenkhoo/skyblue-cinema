Public Class frmFoodPage

    Dim popcornM As Double
    Dim popcornL As Double
    Dim RoyalChocolateBar As Double
    Dim TwistedCheeseRing As Double
    Dim CookieDoughBites As Double
    Dim GummyWorms As Double
    Public SnackTotal As Double
    'Selection and calculation for snacks.
    Private Sub btnDrinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToDrinks.Click

        If ChkBxPopcornM.Checked = False Then
            txtPopcornM.Text() = 0
        Else
            If txtPopcornM.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Popcorn(Medium)")
            Else
                popcornM = txtPopcornM.Text()
            End If
        End If

        If ChkBxPopcornL.Checked = False Then
            txtPopcornL.Text() = 0
        Else
            If txtPopcornL.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Popcorn(Large)")
            Else
                popcornL = txtPopcornL.Text()
            End If
        End If


        If ChkBxRoyalChocolateBar.Checked = False Then
            txtRoyal.Text() = 0
        Else
            If txtRoyal.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Royal Chocolate Bar")
            Else
                RoyalChocolateBar = txtRoyal.Text()
            End If
        End If

        If chkbxTwisted.Checked = False Then
            txtTwisted.Text() = 0
        Else
            If txtTwisted.Text() = Nothing Then
                MsgBox("Please enter a valid quantity for Twisted Cheese Ring")
            Else
                TwistedCheeseRing = txtTwisted.Text()
            End If
        End If

        If chkbxCookie.Checked = False Then
            txtCookie.Text() = 0
        Else
            If txtCookie.Text() = Nothing Then
                MsgBox("Please enter a valid quantity For Cookie Dough Bites")
            Else
                CookieDoughBites = txtCookie.Text()
            End If
        End If


        If chkbxGummy.Checked = False Then
            txtGummy.Text() = 0
        Else
            If txtGummy.Text() = Nothing Then
                MsgBox("Please enter a valid quantity For Gummy Worms")
            Else
                GummyWorms = txtGummy.Text()
            End If
        End If
        If txtPopcornM.Text() <> Nothing And txtPopcornL.Text() <> Nothing And txtRoyal.Text() <> Nothing And txtTwisted.Text() <> Nothing And txtCookie.Text() <> Nothing And txtGummy.Text() <> Nothing Then
            SnackTotal = popcornM * 7.99 + popcornL * 9.99 + RoyalChocolateBar * 12.5 + TwistedCheeseRing * 3.99 + CookieDoughBites * 8.99 + GummyWorms * 4.99

            Me.Hide()
            frmDrinkPage.Show()
        End If
    End Sub
    Private Sub ChkBxPopcornM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBxPopcornM.CheckedChanged
        If ChkBxPopcornM.Checked = True Then
            txtPopcornM.Enabled = True
        Else
            txtPopcornM.Enabled = False
        End If
    End Sub

    Private Sub chkbxGummy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxGummy.CheckedChanged
        If chkbxGummy.Checked = True Then
            txtGummy.Enabled = True
        Else : txtGummy.Enabled = False
        End If
    End Sub

    Private Sub ChkBxPopcornL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBxPopcornL.CheckedChanged
        If ChkBxPopcornL.Checked = True Then
            txtPopcornL.Enabled = True
        Else : txtPopcornL.Enabled = False
        End If
    End Sub

    Private Sub ChkBxRoyalChocolateBar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBxRoyalChocolateBar.CheckedChanged
        If ChkBxRoyalChocolateBar.Checked = True Then
            txtRoyal.Enabled = True
        Else : txtRoyal.Enabled = False
        End If
    End Sub

    Private Sub chkbxTwisted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxTwisted.CheckedChanged
        If chkbxTwisted.Checked = True Then
            txtTwisted.Enabled = True
        Else : txtTwisted.Enabled = False
        End If
    End Sub

    Private Sub chkbxCookie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxCookie.CheckedChanged
        If chkbxCookie.Checked = True Then
            txtCookie.Enabled = True
        Else : txtCookie.Enabled = False
        End If
    End Sub

    Private Sub txtPopcornM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPopcornM.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPopcornL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPopcornL.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRoyal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoyal.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTwisted_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTwisted.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCookie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCookie.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtGummy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGummy.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Reset()
        popcornM = Empty
        popcornL = Empty
        RoyalChocolateBar = Empty
        TwistedCheeseRing = Empty
        CookieDoughBites = Empty
        GummyWorms = Empty
        popcornM = Empty
    End Sub
End Class




