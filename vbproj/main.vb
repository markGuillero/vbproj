
Public Class main


    Private currentchildform As Form

    'form
    Dim burg As New burgers
    Dim drin As New drink
    Dim chic As New chiken
    Dim pizz As New pizza

    'burgers pass
    Friend valfrommainGBR As String
    Friend valfrommainPS As String
    Friend valfrommainSO As String
    Friend valfrommainGM As String
    Friend valfrommainGBS As String
    Friend valfrommainBBQ As String

    'drink pass
    Friend valfrommainSprite As String
    Friend valfrommainPepsi As String
    Friend valfrommainRC As String
    Friend valfrommainCola As String
    Friend valfrommainAB As String
    Friend valfrommainSC As String
    Friend valfrommainDC As String
    Friend valfrommainVD As String

    'Chiken 
    Friend valfrommainCMS As String
    Friend valfrommainCGCT As String
    Friend valfrommainBC As String

    'Pizza
    Friend valfrommainH As String
    Friend valfrommainPep As String

    'utility
    Dim order1 As ListViewItem
    Dim counter As Integer = 0

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles Burgerbtn.Click
        openchildform(burg)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles drinkbtn.Click
        openchildform(drin)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles chicken.Click
        openchildform(chic)
    End Sub
    Private Sub pizza_Click(sender As Object, e As EventArgs) Handles pizza.Click
        openchildform(pizz)
    End Sub
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles Aboutbtn.Click
        openchildform(New About)
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        If currentchildform IsNot Nothing Then
            currentchildform.Hide()
        End If
    End Sub

    Private Sub openchildform(childform As Form)
        If currentchildform IsNot Nothing Then
            currentchildform.Hide()
        End If

        currentchildform = childform
        With childform
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            contentpnl.Controls.Add(childform)
            contentpnl.Tag = childform
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub visibleburger()
        'Grilled Mussels
        If burg.valfromburgerGM > 0 Then
            cbGM.Visible = True
            quantityGM.Text = burg.valfromburgerGM
            cbGM.Dock = DockStyle.Top
            cbGM.Size = New Size(257, 103)
        ElseIf burg.valfromburgerGM <= 0 Then
            cbGM.Visible = False
        End If

        'Pork Sisig
        If burg.valfromburgerPS > 0 Then
            cbPS.Visible = True
            quantiPS.Text = burg.valfromburgerPS
            cbPS.Dock = DockStyle.Top
            cbPS.Size = New Size(257, 103)
        ElseIf burg.valfromburgerPS <= 0 Then
            cbPS.Visible = False
        End If

        'Grilled Baby Ribs
        If burg.valfromburgerGBR > 0 Then
            gbGRB.Visible = True
            quantityGBR.Text = burg.valfromburgerGBR
            gbGRB.Dock = DockStyle.Top
            gbGRB.Size = New Size(257, 103)
        ElseIf burg.valfromburgerGBR <= 0 Then
            gbGRB.Visible = False
        End If

        'Saucy Oyster
        If burg.valfromburgerSO > 0 Then
            cbSO.Visible = True
            quantitySO.Text = burg.valfromburgerSO
            cbSO.Dock = DockStyle.Top
            cbSO.Size = New Size(257, 103)
        ElseIf burg.valfromburgerSO <= 0 Then
            cbSO.Visible = False
        End If

        'Grilled Butter Shrimp
        If burg.valfromburgerGBS > 0 Then
            gbGBS.Visible = True
            quantityGBS.Text = burg.valfromburgerGBS
            gbGBS.Dock = DockStyle.Top
            gbGBS.Size = New Size(257, 103)
        ElseIf burg.valfromburgerGBS <= 0 Then
            gbGBS.Visible = False
        End If

        'Porn BQQ
        If burg.valfromburgerBQQ > 0 Then
            gbBBQ.Visible = True
            quantityBBQ.Text = burg.valfromburgerBQQ
            gbBBQ.Dock = DockStyle.Top
            gbBBQ.Size = New Size(257, 103)
        ElseIf burg.valfromburgerBQQ <= 0 Then
            gbBBQ.Visible = False
        End If


    End Sub


    Public Sub visibledrinks()
        If drin.valfromcola > 0 Then
            gbcola.Visible = True
            q_lblcola.Text = drin.valfromcola
            gbcola.Dock = DockStyle.Top
            gbcola.Size = New Size(257, 103)
        ElseIf drin.valfromcola <= 0 Then
            gbcola.Visible = False
        End If

        If drin.valfrompepsi > 0 Then
            gbpepsi.Visible = True
            q_lblpepsi.Text = drin.valfrompepsi
            gbpepsi.Dock = DockStyle.Top
            gbpepsi.Size = New Size(257, 103)
        ElseIf drin.valfrompepsi <= 0 Then
            gbpepsi.Visible = False
        End If

        If drin.valfromsprite > 0 Then
            gbsprite.Visible = True
            q_lblsprite.Text = drin.valfromsprite
            gbsprite.Dock = DockStyle.Top
            gbsprite.Size = New Size(257, 103)
        ElseIf drin.valfromsprite <= 0 Then
            gbsprite.Visible = False
        End If

        If drin.valfromrc > 0 Then
            gbrc.Visible = True
            q_lblrc.Text = drin.valfromrc
            gbrc.Dock = DockStyle.Top
            gbrc.Size = New Size(257, 103)
        ElseIf drin.valfromrc <= 0 Then
            gbrc.Visible = False
        End If

        If drin.valfromAB > 0 Then
            gbAB.Visible = True
            quantityAB.Text = drin.valfromAB
            gbAB.Dock = DockStyle.Top
            gbAB.Size = New Size(257, 103)
        ElseIf drin.valfromAB <= 0 Then
            gbAB.Visible = False
        End If

        If drin.valfromSC > 0 Then
            gbSC.Visible = True
            quantitySC.Text = drin.valfromSC
            gbSC.Dock = DockStyle.Top
            gbSC.Size = New Size(257, 103)
        ElseIf drin.valfromSC <= 0 Then
            gbSC.Visible = False
        End If

        If drin.valfromDC > 0 Then
            gbDC.Visible = True
            quantityDC.Text = drin.valfromDC
            gbDC.Dock = DockStyle.Top
            gbDC.Size = New Size(257, 103)
        ElseIf drin.valfromDC <= 0 Then
            gbDC.Visible = False
        End If

        If drin.valfromVD > 0 Then
            gbVD.Visible = True
            quantityVD.Text = drin.valfromVD
            gbVD.Dock = DockStyle.Top
            gbVD.Size = New Size(257, 103)
        ElseIf drin.valfromVD <= 0 Then
            gbVD.Visible = False
        End If
    End Sub

    Public Sub visiblechicken()

        If chic.valfromBC > 0 Then
            gbBc.Visible = True
            q_lblBC.Text = chic.valfromBC
            gbBc.Dock = DockStyle.Top
            gbBc.Size = New Size(257, 103)
        ElseIf chic.valfromBC <= 0 Then
            gbBc.Visible = False
        End If

        If chic.valfromCgct > 0 Then
            gbcgct.Visible = True
            q_lblcgct.Text = chic.valfromCgct
            gbcgct.Dock = DockStyle.Top
            gbcgct.Size = New Size(257, 103)
        ElseIf chic.valfromCgct <= 0 Then
            gbcgct.Visible = False
        End If

        If chic.valfromCmsp > 0 Then
            gbcmp.Visible = True
            q_lblgmp.Text = chic.valfromCmsp
            gbcmp.Dock = DockStyle.Top
            gbcmp.Size = New Size(257, 103)
        ElseIf chic.valfromCmsp <= 0 Then
            gbcmp.Visible = False
        End If

    End Sub

    Public Sub visiblePizza()
        If pizz.valfromHawaiian > 0 Then
            gbH.Visible = True
            quantityH.Text = pizz.valfromHawaiian
            gbH.Dock = DockStyle.Top
            gbH.Size = New Size(257, 103)
        ElseIf pizz.valfromHawaiian <= 0 Then
            gbH.Visible = False
        End If

        If pizz.valfromPeperoni > 0 Then
            gbPep.Visible = True
            quantityPep.Text = pizz.valfromPeperoni
            gbPep.Dock = DockStyle.Top
            gbPep.Size = New Size(257, 103)
        ElseIf pizz.valfromPeperoni <= 0 Then
            gbPep.Visible = False
        End If
    End Sub

    Private Sub Addcart_Click(sender As Object, e As EventArgs) Handles Addcart.Click
        visibleburger()
        visibledrinks()
        visiblechicken()
        visiblePizza()
    End Sub

    'meal

    Private Sub xGBR_Click(sender As Object, e As EventArgs) Handles xGBR.Click
        valfrommainGBR = -1
        burg.valfromburgerGBR = 0
        burg.GBQ_counter.Text = burg.valfromburgerGBR
        visibleburger()
    End Sub

    Private Sub xgbPS_Click(sender As Object, e As EventArgs) Handles xgbPS.Click
        valfrommainPS = -1
        burg.valfromburgerPS = 0
        burg.PS_counter.Text = burg.valfromburgerPS
        visibleburger()
    End Sub

    Private Sub xgbSO_Click(sender As Object, e As EventArgs) Handles xgbSO.Click
        valfrommainSO = -1
        burg.valfromburgerSO = 0
        burg.SO_counter.Text = burg.valfromburgerSO
        visibleburger()
    End Sub

    Private Sub xgbGM_Click(sender As Object, e As EventArgs) Handles xgbGM.Click
        valfrommainGM = -1
        burg.valfromburgerGM = 0
        burg.GM_counter.Text = burg.valfromburgerGM
        visibleburger()
    End Sub

    Private Sub xgbGBS_Click(sender As Object, e As EventArgs) Handles xgbGBS.Click
        valfrommainGBS = -1
        burg.valfromburgerGBS = 0
        burg.GBS_counter.Text = burg.valfromburgerGBS
        visibleburger()
    End Sub

    Private Sub xgbBBQ_Click(sender As Object, e As EventArgs) Handles xgbBBQ.Click
        valfrommainBBQ = -1
        burg.valfromburgerBQQ = 0
        burg.BQQ_counter.Text = burg.valfromburgerBQQ
        visibleburger()
    End Sub

    'drink

    Private Sub exp_cola_Click(sender As Object, e As EventArgs) Handles exp_cola.Click
        valfrommainCola = -1
        drin.valfromcola = 0
        drin.CCola_counter.Text = drin.valfromcola

        visibledrinks()
    End Sub

    Private Sub exp_sprite_Click(sender As Object, e As EventArgs) Handles exp_sprite.Click
        valfrommainSprite = -1
        drin.valfromsprite = 0
        drin.sprite_counter.Text = drin.valfromsprite
        visibledrinks()
    End Sub

    Private Sub exp_pepsi_Click(sender As Object, e As EventArgs) Handles exp_pepsi.Click
        valfrommainPepsi = -1
        drin.valfrompepsi = 0
        drin.pepsi_counter.Text = drin.valfrompepsi
        visibledrinks()
    End Sub

    Private Sub exp_RC_Click(sender As Object, e As EventArgs) Handles exp_RC_.Click
        valfrommainRC = -1
        drin.valfromrc = 0
        drin.Rc_counter.Text = drin.valfromrc
        visibledrinks()
    End Sub

    Private Sub xgbAB_Click(sender As Object, e As EventArgs) Handles xgbAB.Click
        valfrommainAB = -1
        drin.valfromAB = 0
        drin.lblnumAB.Text = drin.valfromAB
        visibledrinks()
    End Sub

    Private Sub xgbSC_Click(sender As Object, e As EventArgs) Handles xgbSC.Click
        valfrommainSC = -1
        drin.valfromSC = 0
        drin.lblnumSC.Text = drin.valfromSC
        visibledrinks()
    End Sub

    Private Sub xgbDC_Click(sender As Object, e As EventArgs) Handles xgbDC.Click
        valfrommainDC = -1
        drin.valfromDC = 0
        drin.lblnumDC.Text = drin.valfromDC
        visibledrinks()
    End Sub

    Private Sub xgbVD_Click(sender As Object, e As EventArgs) Handles xgbVD.Click
        valfrommainVD = -1
        drin.valfromVD = 0
        drin.lblnumVD.Text = drin.valfromVD
        visibledrinks()
    End Sub
    'chicken X
    Private Sub exp_rc_Click_1(sender As Object, e As EventArgs) Handles exp_rc.Click
        valfrommainCMS = -1
        chic.valfromCmsp = 0
        chic.Cmsp_counter.Text = chic.valfromCmsp
        visiblechicken()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        valfrommainCGCT = -1
        chic.valfromCgct = 0
        chic.Cgct_counter.Text = chic.valfromCgct
        visiblechicken()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        valfrommainBC = -1
        chic.valfromBC = 0
        chic.BC_counter.Text = chic.valfromBC
        visiblechicken()
    End Sub

    Private Sub xgbH_Click(sender As Object, e As EventArgs) Handles xgbH.Click
        valfrommainH = -1
        pizz.valfromHawaiian = 0
        pizz.Hawaian_counter.Text = pizz.valfromHawaiian
        visiblePizza()
    End Sub

    Private Sub xgbPep_Click(sender As Object, e As EventArgs) Handles xgbPep.Click
        valfrommainPep = -1
        pizz.valfromPeperoni = 0
        pizz.peperoni_counter.Text = pizz.valfromPeperoni
        visiblePizza()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TimeChange_Tick(sender As Object, e As EventArgs) Handles TimeChange.Tick
        counter += 1
        If counter = 1 Then
            contentpnl.BackgroundImage = My.Resources._12
        ElseIf counter = 2 Then
            contentpnl.BackgroundImage = My.Resources._21
        ElseIf counter = 3 Then
            contentpnl.BackgroundImage = My.Resources._31
        ElseIf counter = 4 Then
            contentpnl.BackgroundImage = My.Resources._41
        ElseIf counter = 5 Then
            contentpnl.BackgroundImage = My.Resources._5
            counter = 0
        End If
    End Sub


    Private Sub test_MouseEnter(sender As Object, e As EventArgs)
        TimeChange.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimeUpdate.Enabled = True
        username.Text = mainlogin.TextBox1.Text
        visibleburger()
        visibledrinks()
        visiblechicken()
        visiblePizza()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        pickeduporder()
        pickuporderDrink()
        pickupOrderChiken()
        pickupOrderPizza()
        Me.Hide()
        TrackingLocation.Show()
    End Sub

    Dim GMP As Double = 450

    Public Sub pickeduporder()
        If burg.valfromburgerGM > 0 And cbGM.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Grilled Mussels")
            With order1
                .SubItems.Add(450 * burg.valfromburgerGM).ToString()
                .SubItems.Add(burg.valfromburgerGM)
            End With
        End If

        If burg.valfromburgerGBS > 0 And gbGBS.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Grilled Buttered Shrimp ")
            With order1
                .SubItems.Add(650 * burg.valfromburgerGBS).ToString()
                .SubItems.Add(burg.valfromburgerGBS)
            End With
        End If

        If burg.valfromburgerBQQ > 0 And gbBBQ.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Pork BBQ")
            With order1
                .SubItems.Add(120 * burg.valfromburgerBQQ).ToString()
                .SubItems.Add(burg.valfromburgerBQQ)
            End With
        End If

        If burg.valfromburgerSO > 0 And cbSO.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Saucy Oyster")
            With order1
                .SubItems.Add(120 * burg.valfromburgerSO).ToString()
                .SubItems.Add(burg.valfromburgerSO)
            End With
        End If

        If burg.valfromburgerGBR > 0 And gbGRB.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Grilled Baby Ribs")
            With order1
                .SubItems.Add(450 * burg.valfromburgerGBR).ToString()
                .SubItems.Add(burg.valfromburgerGBR)
            End With
        End If

        If burg.valfromburgerPS > 0 And cbPS.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Pork Sisig")
            With order1
                .SubItems.Add(180 * burg.valfromburgerPS).ToString()
                .SubItems.Add(burg.valfromburgerPS)
            End With
        End If
    End Sub

    Public Sub pickuporderDrink()
        If drin.valfromcola > 0 And gbcola.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Coca-Cola")
            With order1
                .SubItems.Add(20 * drin.valfromcola).ToString()
                .SubItems.Add(drin.valfromcola)
            End With
        End If

        If drin.valfrompepsi > 0 And gbpepsi.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Pepsi")
            With order1
                .SubItems.Add(20 * drin.valfrompepsi).ToString()
                .SubItems.Add(drin.valfrompepsi)
            End With
        End If

        If drin.valfromsprite > 0 And gbsprite.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Sprite")
            With order1
                .SubItems.Add(20 * drin.valfromsprite).ToString()
                .SubItems.Add(drin.valfromsprite)
            End With
        End If

        If drin.valfromrc > 0 And gbrc.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("RC cola")
            With order1
                .SubItems.Add(20 * drin.valfromrc).ToString()
                .SubItems.Add(drin.valfromrc)
            End With
        End If

        If drin.valfromAB > 0 And gbAB.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Almond Brittle")
            With order1
                .SubItems.Add(200 * drin.valfromAB).ToString()
                .SubItems.Add(drin.valfromAB)
            End With
        End If

        If drin.valfromSC > 0 And gbSC.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Salted Caramel")
            With order1
                .SubItems.Add(195 * drin.valfromSC).ToString()
                .SubItems.Add(drin.valfromSC)
            End With
        End If

        If drin.valfromDC > 0 And gbDC.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Dalgona Coffee")
            With order1
                .SubItems.Add(180 * drin.valfromDC).ToString()
                .SubItems.Add(drin.valfromDC)
            End With
        End If


        If drin.valfromVD > 0 And gbVD.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Vanila Drip")
            With order1
                .SubItems.Add(190 * drin.valfromVD).ToString()
                .SubItems.Add(drin.valfromVD)
            End With
        End If
    End Sub

    Public Sub pickupOrderChiken()
        If chic.valfromBC > 0 And gbBc.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Braised chicken")
            With order1
                .SubItems.Add(156 * chic.valfromBC).ToString()
                .SubItems.Add(chic.valfromBC)
            End With
        End If

        If chic.valfromCgct > 0 And gbcgct.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Crispy garlic chicken thigh")
            With order1
                .SubItems.Add(178 * chic.valfromCgct).ToString()
                .SubItems.Add(chic.valfromCgct)
            End With
        End If

        If chic.valfromCmsp > 0 And gbcmp.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Chicken with mushroom soup")
            With order1
                .SubItems.Add(220 * chic.valfromCmsp).ToString()
                .SubItems.Add(chic.valfromCmsp)
            End With
        End If
    End Sub

    Public Sub pickupOrderPizza()
        If pizz.valfromHawaiian > 0 And gbH.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Hawaian Pizza")
            With order1
                .SubItems.Add(160 * pizz.valfromHawaiian).ToString()
                .SubItems.Add(pizz.valfromHawaiian)
            End With
        End If

        If pizz.valfromPeperoni > 0 And gbPep.Visible = True Then
            order1 = TrackingLocation.lsorder.Items.Add("Pepperoni Pizza")
            With order1
                .SubItems.Add(180 * pizz.valfromPeperoni).ToString()
                .SubItems.Add(pizz.valfromPeperoni)
            End With
        End If
    End Sub

    Public Sub EnableOrder()
        If cbGM.Visible = True Or gbGBS.Visible = True Or gbBBQ.Visible = True Or cbSO.Visible = True Or gbGRB.Visible = True Or cbPS.Visible = True _
            Or gbcola.Visible = True Or gbpepsi.Visible = True Or gbsprite.Visible = True Or gbrc.Visible = True Or gbAB.Visible = True Or gbSC.Visible = True _
            Or gbDC.Visible = True Or gbDC.Visible = True Or gbVD.Visible = True Or gbBc.Visible = True Or gbcgct.Visible = True Or gbcmp.Visible = True _
            Or gbH.Visible = True Or gbPep.Visible = True Then
            IconButton1.Enabled = True
            IconButton1.BackColor = Color.FromArgb(0, 192, 0)
        Else
            IconButton1.Enabled = False
            IconButton1.BackColor = Color.Red
        End If
    End Sub



    Private Sub DateTimeUpdate_Tick(sender As Object, e As EventArgs) Handles DateTimeUpdate.Tick
        Label4.Text = Date.Now.ToString
        EnableOrder()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel6_MouseEnter(sender As Object, e As EventArgs) Handles Panel6.MouseEnter
        If cbGM.Visible = False And gbGBS.Visible = False And gbBBQ.Visible = False And cbSO.Visible = False And gbGRB.Visible = False And cbPS.Visible = False _
          And gbcola.Visible = False And gbpepsi.Visible = False And gbsprite.Visible = False And gbrc.Visible = False And gbAB.Visible = False And gbSC.Visible = False _
           And gbDC.Visible = False And gbDC.Visible = False And gbVD.Visible = False And gbBc.Visible = False And gbcgct.Visible = False And gbcmp.Visible = False _
           And gbH.Visible = False And gbPep.Visible = False Then

            MessageBox.Show("Place Order First", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
