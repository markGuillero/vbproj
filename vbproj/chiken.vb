Public Class chiken
    Dim cmsp_no As Integer = 0, Cgct_no = 0, BC = 0

    Friend valfromCmsp As String
    Friend valfromCgct As String
    Friend valfromBC As String

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

    Private Sub Cmsp_plus_Click(sender As Object, e As EventArgs) Handles Cmsp_plus.Click
        cmsp_no = add_item(cmsp_no)
        Cmsp_counter.Text = cmsp_no
        valfromCmsp = Cmsp_counter.Text
    End Sub

    Private Sub Cmsp_minus_Click(sender As Object, e As EventArgs) Handles Cmsp_minus.Click
        cmsp_no = Minus_item(cmsp_no)
        Cmsp_counter.Text = cmsp_no
        valfromCmsp = Cmsp_counter.Text
    End Sub

    Private Sub Cgct_minus_Click(sender As Object, e As EventArgs) Handles Cgct_minus.Click
        Cgct_no = Minus_item(Cgct_no)
        Cgct_counter.Text = Cgct_no
        valfromCgct = Cgct_counter.Text
    End Sub

    Private Sub Cgct_plus_Click(sender As Object, e As EventArgs) Handles Cgct_plus.Click
        Cgct_no = add_item(Cgct_no)
        Cgct_counter.Text = Cgct_no
        valfromCgct = Cgct_counter.Text
    End Sub

    Private Sub chiken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BC_minus_Click(sender As Object, e As EventArgs) Handles BC_minus.Click
        BC = Minus_item(BC)
        BC_counter.Text = BC
        valfromBC = BC_counter.Text
    End Sub

    Private Sub BC_plus_Click(sender As Object, e As EventArgs) Handles BC_plus.Click
        BC = add_item(BC)
        BC_counter.Text = BC
        valfromBC = BC_counter.Text
    End Sub

    Private Sub frommain()
        If main.valfrommainCMS = -1 Then
            main.valfrommainCMS = 0
            cmsp_no = 0
        End If

        If main.valfrommainCGCT = -1 Then
            main.valfrommainCGCT = 0
            Cgct_no = 0
        End If

        If main.valfrommainBC = -1 Then
            main.valfrommainBC = 0
            BC = 0
        End If
    End Sub

    Private Sub gbCMSP_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbCMSP_plus_minus.MouseEnter
        frommain()
    End Sub

    Private Sub gbCMSP_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbCMSP_plus_minus.MouseLeave
        frommain()
    End Sub

    Private Sub gbCGCT_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbCGCT_plus_minus.MouseEnter
        frommain()
    End Sub

    Private Sub gbCGCT_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbCGCT_plus_minus.MouseLeave
        frommain()
    End Sub

    Private Sub gbBC_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbBC_plus_minus.MouseEnter
        frommain()
    End Sub

    Private Sub gbBC_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbBC_plus_minus.MouseLeave
        frommain()
    End Sub
End Class