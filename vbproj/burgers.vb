
Public Class burgers
    Dim counterGBR As Integer = 0, counterPS = 0, counterSO = 0,
        counterGM = 0, counterGBS = 0, counterBBQ = 0

    Friend valfromburgerGBR As String
    Friend valfromburgerPS As String
    Friend valfromburgerSO As String
    Friend valfromburgerGM As String
    Friend valfromburgerGBS As String
    Friend valfromburgerBQQ As String

    Private Sub PS_minus_Click(sender As Object, e As EventArgs) Handles PS_minus.Click
        counterPS = Minus_item(counterPS)
        PS_counter.Text = counterPS
        valfromburgerPS = PS_counter.Text
    End Sub

    Private Sub PS_plus_Click(sender As Object, e As EventArgs) Handles PS_plus.Click
        counterPS = add_item(counterPS)
        PS_counter.Text = counterPS
        valfromburgerPS = PS_counter.Text
    End Sub

    Private Sub SO_minus_Click(sender As Object, e As EventArgs) Handles SO_minus.Click
        counterSO = Minus_item(counterSO)
        SO_counter.Text = counterSO
        valfromburgerSO = SO_counter.Text
        SO_counter.Text = valfromburgerSO
    End Sub

    Private Sub SO_plus_Click(sender As Object, e As EventArgs) Handles SO_plus.Click
        counterSO = add_item(counterSO)
        SO_counter.Text = counterSO
        valfromburgerSO = SO_counter.Text
        SO_counter.Text = valfromburgerSO
    End Sub

    Private Sub GM_minus_Click(sender As Object, e As EventArgs) Handles GM_minus.Click
        counterGM = Minus_item(counterGM)
        GM_counter.Text = counterGM
        valfromburgerGM = GM_counter.Text
        GM_counter.Text = valfromburgerGM
    End Sub

    Private Sub GM_plus_Click(sender As Object, e As EventArgs) Handles GM_plus.Click
        counterGM = add_item(counterGM)
        GM_counter.Text = counterGM
        valfromburgerGM = GM_counter.Text
    End Sub

    Private Sub GBS_minus_Click(sender As Object, e As EventArgs) Handles GBS_minus.Click
        counterGBS = Minus_item(counterGBS)
        GBS_counter.Text = counterGBS
        valfromburgerGBS = GBS_counter.Text
    End Sub

    Private Sub GBS_plus_Click(sender As Object, e As EventArgs) Handles GBS_plus.Click
        counterGBS = add_item(counterGBS)
        GBS_counter.Text = counterGBS
        valfromburgerGBS = GBS_counter.Text
    End Sub

    Private Sub BBQ_minus_Click(sender As Object, e As EventArgs) Handles BBQ_minus.Click
        counterBBQ = Minus_item(counterBBQ)
        BQQ_counter.Text = counterBBQ
        valfromburgerBQQ = BQQ_counter.Text
        BQQ_counter.Text = valfromburgerBQQ
    End Sub

    Private Sub BQQ_plus_Click(sender As Object, e As EventArgs) Handles BQQ_plus.Click
        counterBBQ = add_item(counterBBQ)
        BQQ_counter.Text = counterBBQ
        valfromburgerBQQ = BQQ_counter.Text
        BQQ_counter.Text = valfromburgerBQQ
    End Sub

    Private Sub gbGBR_plus_minus_Enter(sender As Object, e As EventArgs) Handles gbGBR_plus_minus.MouseEnter
        frommain()
    End Sub
    Private Sub gbGBR_plus_minus_Leave(sender As Object, e As EventArgs) Handles gbGBR_plus_minus.MouseLeave
        frommain()
    End Sub

    Private Sub gbPS_plus_minus_Enter(sender As Object, e As EventArgs) Handles gbPS_plus_minus.MouseEnter
        frommain()
    End Sub

    Private Sub gbPS_plus_minus_Leave(sender As Object, e As EventArgs) Handles gbGBR_plus_minus.MouseLeave
        frommain()
    End Sub

    Private Sub gbSO_plus_minus_Enter(sender As Object, e As EventArgs) Handles gbSO_plus_minus.MouseEnter
        frommain()
    End Sub

    Private Sub gbSO_plus_minus_Leave(sender As Object, e As EventArgs) Handles gbSO_plus_minus.MouseLeave
        frommain()
    End Sub
    Private Sub gbGM_plus_minus_Enter(sender As Object, e As EventArgs) Handles gbGM_plus_minus.MouseEnter
        frommain()
    End Sub
    Private Sub gbGM_plus_minus_Leave(sender As Object, e As EventArgs) Handles gbGM_plus_minus.MouseLeave
        frommain()
    End Sub
    Private Sub gbGBS_plus_minus_Enter(sender As Object, e As EventArgs) Handles gbGBS_plus_minus.MouseEnter
        frommain()
    End Sub
    Private Sub gbGBS_plus_minus_Leave(sender As Object, e As EventArgs) Handles gbGBS_plus_minus.MouseLeave
        frommain()
    End Sub

    Private Sub burgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GBR_btnplus_Click(sender As Object, e As EventArgs) Handles GBR_btnplus.Click
        counterGBR = add_item(counterGBR)
        GBQ_counter.Text = counterGBR
        valfromburgerGBR = GBQ_counter.Text

    End Sub

    Private Sub GBR_btnminus_Click(sender As Object, e As EventArgs) Handles GBR_btnminus.Click
        counterGBR = Minus_item(counterGBR)
        GBQ_counter.Text = counterGBR
        valfromburgerGBR = GBQ_counter.Text
    End Sub



    Public Function Minus_item(NumVal As Integer)
        If NumVal > 0 Then
            NumVal -= 1
        End If
        Return NumVal
    End Function

    Public Function add_item(NumVal As Integer)
        NumVal += 1
        Return NumVal
    End Function

    Private Sub frommain()
        If main.valfrommainGBR = -1 Then
            counterGBR = 0
            main.valfrommainGBR = 0
        End If

        If main.valfrommainPS = -1 Then
            counterPS = 0
            main.valfrommainPS = 0
        End If

        If main.valfrommainSO = -1 Then
            counterSO = 0
            main.valfrommainSO = 0
        End If

        If main.valfrommainSO = -1 Then
            counterSO = 0
            main.valfrommainSO = 0
        End If

        If main.valfrommainGM = -1 Then
            counterGM = 0
            main.valfrommainGM = 0
        End If

        If main.valfrommainGBS = -1 Then
            counterGBS = 0
            main.valfrommainGBS = 0
        End If

        If main.valfrommainBBQ = -1 Then
            counterBBQ = 0
            main.valfrommainBBQ = 0
        End If
    End Sub


End Class