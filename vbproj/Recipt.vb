Public Class Recipt

    Dim separator As String = "*******************************************************"
    Dim logo As String = "         CASA DE PINAS"
    Dim des As String = "Description"
    Dim dash As String = "..................................."
    Dim pricing As String = "Price"
    Dim lvldesc As String
    Dim complete As String
    Dim counter As Integer

    Dim address As String = TrackingLocation.add
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(complete, font, Brushes.Black, 200, 200)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Recipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        counter = 1
        PrintPriv()
        'meal
        main.quantityGM.Text = 0
        main.quantiPS.Text = 0
        main.quantityGBR.Text = 0
        main.quantitySO.Text = 0
        main.quantityGBS.Text = 0
        main.quantityBBQ.Text = 0

        'drinks
        main.q_lblcola.Text = 0
        main.q_lblpepsi.Text = 0
        main.q_lblsprite.Text = 0
        main.q_lblrc.Text = 0
        main.quantityAB.Text = 0
        main.quantitySC.Text = 0
        main.quantityDC.Text = 0
        main.quantityVD.Text = 0

        'Chiken
        main.q_lblBC.Text = 0
        main.q_lblcgct.Text = 0
        main.q_lblgmp.Text = 0

        'Pizza
        main.quantityH.Text = 0
        main.quantityPep.Text = 0

        'If TrackingLocation.counting = 1 Then
        '    PrintPriv()
        '    'Recipt_Load(e, e)
        '    TrackingLocation.counting = 0
        'End If
        Me.Close()
    End Sub

    Public Sub PrintPriv()
        For n As Integer = 0 To TrackingLocation.lsorder.Items.Count - 1
            lvldesc = lvldesc + TrackingLocation.lsorder.Items(n).Text + "(" + TrackingLocation.lsorder.Items(n).SubItems(2).Text + ")" + dash + TrackingLocation.lsorder.Items(n).SubItems(1).Text + vbCrLf
        Next
        complete = separator + vbCrLf + vbTab + logo + vbCrLf + separator + vbCrLf + "Contact No: " + TrackingLocation.Contact.Text + vbCrLf _
            + "Address : " + TrackingLocation.txthouseNo.Text + vbCrLf + TrackingLocation.txtStreet.Text + vbCrLf + TrackingLocation.txtbarangay.Text + vbCrLf + TrackingLocation.txtCity.Text _
            + vbCrLf + TrackingLocation.txtroomfloor.Text _
        + vbCrLf + vbCrLf + des + vbTab + vbTab + vbTab + "  " + pricing + vbCrLf + vbCrLf + lvldesc + separator + vbCrLf + vbCrLf + main.Label4.Text + vbTab + vbTab + vbTab + vbCrLf + "Total Price  " + TrackingLocation.totalp.Text

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        'If TrackingLocation.counting = 1 Then
        '    PrintPriv()
        '    PrintPreviewDialog1.Document = PrintDocument1
        '    PrintPreviewDialog1.ShowDialog()
        '    TrackingLocation.counting = 0
        '    Timer1.Stop()
        'End If
    End Sub
End Class