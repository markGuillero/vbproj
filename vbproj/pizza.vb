Public Class pizza
    Dim pep_np As Integer = 0, Hawai_no = 0

    Friend valfromHawaiian As String
    Friend valfromPeperoni As String


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

    Private Sub Hawaiian_minus_Click(sender As Object, e As EventArgs) Handles Hawaiian_minus.Click
        Hawai_no = Minus_item(Hawai_no)
        Hawaian_counter.Text = Hawai_no
        valfromHawaiian = Hawaian_counter.Text
    End Sub

    Private Sub Hawaiian_plus_Click(sender As Object, e As EventArgs) Handles Hawaiian_plus.Click
        Hawai_no = add_item(Hawai_no)
        Hawaian_counter.Text = Hawai_no
        valfromHawaiian = Hawaian_counter.Text
    End Sub

    Private Sub peperoni_minus_Click(sender As Object, e As EventArgs) Handles peperoni_minus.Click
        pep_np = Minus_item(pep_np)
        peperoni_counter.Text = pep_np
        valfromPeperoni = peperoni_counter.Text
    End Sub

    Private Sub pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub peperoni_plus_Click(sender As Object, e As EventArgs) Handles peperoni_plus.Click
        pep_np = add_item(pep_np)
        peperoni_counter.Text = pep_np
        valfromPeperoni = peperoni_counter.Text
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub frommain()
        If main.valfrommainH = -1 Then
            main.valfrommainH = 0
            Hawai_no = 0
        End If

        If main.valfrommainPep = -1 Then
            main.valfrommainPep = 0
            pep_np = 0
        End If
    End Sub

    Private Sub GroupBox5_MouseEnter(sender As Object, e As EventArgs) Handles GroupBox5.MouseEnter
        frommain()
    End Sub
    Private Sub GroupBox5_MouseLeave(sender As Object, e As EventArgs) Handles GroupBox5.MouseLeave
        frommain()
    End Sub

    Private Sub GroupBox3_MouseEnter(sender As Object, e As EventArgs) Handles GroupBox3.MouseEnter
        frommain()
    End Sub

    Private Sub GroupBox3_MouseLeave(sender As Object, e As EventArgs) Handles GroupBox3.MouseLeave
        frommain()
    End Sub
End Class