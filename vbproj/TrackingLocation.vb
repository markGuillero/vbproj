Imports System.Text
Public Class TrackingLocation


    Dim houseNo As String = String.Empty
    Dim street As String = String.Empty
    Dim barangay As String = String.Empty
    Dim city As String = String.Empty
    Dim querryAdress As New StringBuilder()
    Public add As String
    Dim counter As Integer = 0
    Dim roomandfloor As String
    Dim TotalVal As Double
    Dim tmp As Decimal
    Public counting As Integer = 1

    Private Sub TrackingLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

        For n As Integer = 0 To lsorder.Items.Count - 1
            If Decimal.TryParse(lsorder.Items(n).SubItems(1).Text, tmp) Then
                TotalVal += tmp
            End If
        Next
        totalp.Text = Format(TotalVal.ToString, "Standard")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Search.Click
        Try
            If txthouseNo.Text = String.Empty And txtStreet.Text = String.Empty And txtbarangay.Text <> String.Empty And txtCity.Text <> String.Empty Then
                MessageBox.Show("Pls input the adress", "address", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                querryAdress.Append("http://maps.google.com/maps?q=")
                If txthouseNo.Text <> String.Empty Then
                    houseNo = txthouseNo.Text.Replace(" ", " ")
                    querryAdress.Append(houseNo + "" & "")
                    add += " " + houseNo
                End If

                If txtStreet.Text <> String.Empty Then
                    street = txtStreet.Text.Replace(" ", " ")
                    querryAdress.Append(street + "" & "")
                    add += " " + street
                End If

                If txtbarangay.Text <> String.Empty Then
                    barangay = txtbarangay.Text.Replace(" ", " ")
                    querryAdress.Append(barangay + "" & "")
                    add += " " + barangay
                End If

                If txtCity.Text <> String.Empty Then
                    city = txtCity.Text.Replace(" ", "+")
                    querryAdress.Append(city + "" & "")
                    add += " " + city
                End If

                If roomandfloor <> String.Empty Then
                    roomandfloor = txtroomfloor.Text
                End If
                WebBrowser2.Navigate(querryAdress.ToString)

                Search.Enabled = False
                Search.BackColor = Color.Red
                Order.Enabled = True
                Order.BackColor = Color.Green


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to get Map")
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Back.Click
        WebBrowser2.Navigate("about:blank")
        counter = 0
        querryAdress.Clear()
        txthouseNo.Text = ""
        txtStreet.Text = ""
        txtbarangay.Text = ""
        txtCity.Text = ""
        txtroomfloor.Text = ""
        Contact.Text = ""
        Search.Enabled = True
        Search.BackColor = Color.Green
        Order.Enabled = False
        Order.BackColor = Color.Red

        TotalVal = 0
        For n As Integer = 0 To lsorder.Items.Count - 1
            If Decimal.TryParse(lsorder.Items(n).SubItems(1).Text, tmp) Then
                TotalVal += tmp
            End If
        Next
        totalp.Text = Format(TotalVal.ToString, "Standard")
        lsorder.Items.Clear()


        Me.Hide()
        main.Show()
        TotalVal = 0
        main.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Order.Click
        If String.IsNullOrEmpty(txthouseNo.Text) And String.IsNullOrEmpty(txtStreet.Text) And String.IsNullOrEmpty(txtbarangay.Text) And String.IsNullOrEmpty(txtCity.Text) And String.IsNullOrEmpty(Contact.Text) Then
            MessageBox.Show("Pls input the adress", "address", MessageBoxButtons.OK, MessageBoxIcon.Information)
            WebBrowser1.Navigate("about:blank")
            counter = 0
            querryAdress.Clear()
            txthouseNo.Text = ""
            txtStreet.Text = ""
            txtbarangay.Text = ""
            txtCity.Text = ""
            txtroomfloor.Text = ""
            Contact.Text = ""
            Search.Enabled = True
            Search.BackColor = Color.Green
            Order.Enabled = False
            Order.BackColor = Color.Red
        Else
            If String.IsNullOrWhiteSpace(Contact.Text) Then
                MessageBox.Show("No Contact No. Detected", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Click Clear then input the Contact No", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Order.Enabled = False
                Order.BackColor = Color.Red
            Else
                Me.Hide()
                Recipt.Show()
                counting = 1
                WebBrowser1.Navigate("about:blank")
                counter = 0
                querryAdress.Clear()
                txthouseNo.Text = ""
                txtStreet.Text = ""
                txtbarangay.Text = ""
                txtCity.Text = ""
                txtroomfloor.Text = ""
                Contact.Text = ""
                TotalVal = 0
                totalp.Text = ""
                lsorder.Items.Clear()
                Search.Enabled = True
                Search.BackColor = Color.Green
                Order.Enabled = False
                Order.BackColor = Color.Red
            End If

        End If

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        WebBrowser1.Navigate("about:blank")
        counter = 0
        querryAdress.Clear()
        txthouseNo.Text = ""
        txtStreet.Text = ""
        txtbarangay.Text = ""
        txtCity.Text = ""
        txtroomfloor.Text = ""
        Contact.Text = ""
        Search.Enabled = True
        Search.BackColor = Color.Green
        Order.Enabled = False
        Order.BackColor = Color.Red
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For n As Integer = 0 To lsorder.Items.Count - 1
            If Decimal.TryParse(lsorder.Items(n).SubItems(1).Text, tmp) Then
                TotalVal += tmp
            End If
        Next
        totalp.Text = Format(TotalVal.ToString, "Standard")
        TotalVal = 0
        Me.Refresh()
    End Sub
End Class