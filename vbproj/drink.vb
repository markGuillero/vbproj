Public Class drink
    Dim pepsinum As Integer = 0, spriteNum = 0, colaNum = 0, rcNum = 0
    Dim Ab As Integer = 0, SC = 0, DC = 0, Vd = 0

    'beverages

    Friend valfromsprite As String
    Friend valfrompepsi As String
    Friend valfromrc As String
    Friend valfromcola As String

    'milk shakes
    Friend valfromAB As String
    Friend valfromSC As String
    Friend valfromDC As String
    Friend valfromVD As String

    Private Sub sprite_minus_Click(sender As Object, e As EventArgs) Handles sprite_minus.Click
        spriteNum = Minus_item(spriteNum)
        sprite_counter.Text = spriteNum
        valfromsprite = sprite_counter.Text
    End Sub

    Private Sub sprite_plus_Click(sender As Object, e As EventArgs) Handles sprite_plus.Click
        spriteNum = add_item(spriteNum)
        sprite_counter.Text = spriteNum
        valfromsprite = sprite_counter.Text
    End Sub

    Private Sub pepsi_minus_Click(sender As Object, e As EventArgs) Handles pepsi_minus.Click
        pepsinum = Minus_item(pepsinum)
        pepsi_counter.Text = pepsinum
        valfrompepsi = pepsi_counter.Text
    End Sub

    Private Sub pepsi_plus_Click(sender As Object, e As EventArgs) Handles pepsi_plus.Click
        pepsinum = add_item(pepsinum)
        pepsi_counter.Text = pepsinum
        valfrompepsi = pepsi_counter.Text
    End Sub

    Private Sub Rc_minus_Click(sender As Object, e As EventArgs) Handles Rc_minus.Click
        rcNum = Minus_item(rcNum)
        Rc_counter.Text = rcNum
        valfromrc = Rc_counter.Text
    End Sub

    Private Sub Rc_plus_Click(sender As Object, e As EventArgs) Handles Rc_plus.Click
        rcNum = add_item(rcNum)
        Rc_counter.Text = rcNum
        valfromrc = Rc_counter.Text
    End Sub

    Private Sub CCola_minus_Click(sender As Object, e As EventArgs) Handles CCola_minus.Click
        colaNum = Minus_item(colaNum)
        CCola_counter.Text = colaNum
        valfromcola = CCola_counter.Text
    End Sub

    Private Sub CCola_plus_Click(sender As Object, e As EventArgs) Handles CCola_plus.Click
        colaNum = add_item(colaNum)
        CCola_counter.Text = colaNum
        valfromcola = CCola_counter.Text
    End Sub

    Private Sub Ab_minus_Click(sender As Object, e As EventArgs) Handles Ab_minus.Click
        Ab = Minus_item(Ab)
        lblnumAB.Text = Ab
        valfromAB = lblnumAB.Text
    End Sub

    Private Sub Ab_plus_Click(sender As Object, e As EventArgs) Handles Ab_plus.Click
        Ab = add_item(Ab)
        lblnumAB.Text = Ab
        valfromAB = lblnumAB.Text
    End Sub

    Private Sub Sc_minus_Click(sender As Object, e As EventArgs) Handles Sc_minus.Click
        SC = Minus_item(SC)
        lblnumSC.Text = SC
        valfromSC = lblnumSC.Text
    End Sub

    Private Sub Sc_plus_Click(sender As Object, e As EventArgs) Handles Sc_plus.Click
        SC = add_item(SC)
        lblnumSC.Text = SC
        valfromSC = lblnumSC.Text
    End Sub

    Private Sub Vd_plus_Click(sender As Object, e As EventArgs) Handles Vd_plus.Click
        Vd = add_item(Vd)
        lblnumVD.Text = Vd
        valfromVD = lblnumVD.Text
    End Sub

    Private Sub Dc_minus_Click(sender As Object, e As EventArgs) Handles Dc_minus.Click
        DC = Minus_item(DC)
        lblnumDC.Text = DC
        valfromDC = lblnumDC.Text
    End Sub

    Private Sub Dc_plus_Click(sender As Object, e As EventArgs) Handles Dc_plus.Click
        DC = add_item(DC)
        lblnumDC.Text = DC
        valfromDC = lblnumDC.Text
    End Sub



    Private Sub Vd_minus_Click(sender As Object, e As EventArgs) Handles Vd_minus.Click
        Vd = Minus_item(Vd)
        lblnumVD.Text = Vd
        valfromVD = lblnumVD.Text
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

    Private Sub drink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub frommaindrink()
        If main.valfrommainCola = -1 Then
            main.valfrommainCola = 0
            colaNum = 0
        End If

        If main.valfrommainSprite = -1 Then
            spriteNum = 0
            main.valfrommainSprite = 0
        End If

        If main.valfrommainPepsi = -1 Then
            pepsinum = 0
            main.valfrommainPepsi = 0
        End If

        If main.valfrommainRC = -1 Then
            rcNum = 0
            main.valfrommainRC = 0
        End If

        If main.valfrommainAB = -1 Then
            Ab = 0
            main.valfrommainAB = 0
        End If

        If main.valfrommainSC = -1 Then
            SC = 0
            main.valfrommainSC = 0
        End If

        If main.valfrommainDC = -1 Then
            DC = 0
            main.valfrommainDC = 0
        End If

        If main.valfrommainVD = -1 Then
            Vd = 0
            main.valfrommainVD = 0
        End If
    End Sub

    Private Sub gbCola_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbCola_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbCola_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbCola_plus_minus.MouseLeave
        frommaindrink()
    End Sub

    Private Sub gbSprite_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbSprite_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbSprite_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbSprite_plus_minus.MouseLeave
        frommaindrink()
    End Sub

    Private Sub gbPepsi_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbPepsi_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbPepsi_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbPepsi_plus_minus.MouseLeave
        frommaindrink()
    End Sub

    Private Sub gbRC_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbRC_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbRC_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbRC_plus_minus.MouseLeave
        frommaindrink()
    End Sub

    Private Sub gbAB_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbAB_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbAB_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbAB_plus_minus.MouseLeave
        frommaindrink()
    End Sub

    Private Sub gbSC_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbSC_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbSC_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbSC_plus_minus.MouseLeave
        frommaindrink()
    End Sub
    Private Sub gbDC_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbDC_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbDC_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbSC_plus_minus.MouseLeave
        frommaindrink()
    End Sub
    Private Sub gbVD_plus_minus_MouseEnter(sender As Object, e As EventArgs) Handles gbVD_plus_minus.MouseEnter
        frommaindrink()
    End Sub

    Private Sub gbVD_plus_minus_MouseLeave(sender As Object, e As EventArgs) Handles gbVD_plus_minus.MouseLeave
        frommaindrink()
    End Sub
End Class