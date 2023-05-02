<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrackingLocation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackingLocation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txthouseNo = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Contact = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Order = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.totalp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.lsorder = New System.Windows.Forms.ListView()
        Me.Food = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtroomfloor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbarangay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, -79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "House number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Street"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "City"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, -83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 3
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(144, 74)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(210, 20)
        Me.txtStreet.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(144, 153)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(210, 20)
        Me.txtCity.TabIndex = 4
        '
        'txthouseNo
        '
        Me.txthouseNo.Location = New System.Drawing.Point(144, 33)
        Me.txthouseNo.Name = "txthouseNo"
        Me.txthouseNo.Size = New System.Drawing.Size(210, 20)
        Me.txthouseNo.TabIndex = 1
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Lime
        Me.Search.Location = New System.Drawing.Point(338, 293)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(114, 40)
        Me.Search.TabIndex = 7
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Clear)
        Me.Panel1.Controls.Add(Me.Contact)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Order)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Back)
        Me.Panel1.Controls.Add(Me.lsorder)
        Me.Panel1.Controls.Add(Me.txtroomfloor)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtbarangay)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txthouseNo)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtStreet)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(888, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 950)
        Me.Panel1.TabIndex = 8
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Lime
        Me.Clear.Location = New System.Drawing.Point(182, 293)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(107, 40)
        Me.Clear.TabIndex = 22
        Me.Clear.Text = "Clear Address"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Contact
        '
        Me.Contact.Location = New System.Drawing.Point(144, 234)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(210, 20)
        Me.Contact.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Contact No."
        '
        'Order
        '
        Me.Order.BackColor = System.Drawing.Color.Red
        Me.Order.Enabled = False
        Me.Order.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order.ForeColor = System.Drawing.Color.Black
        Me.Order.Location = New System.Drawing.Point(36, 867)
        Me.Order.Name = "Order"
        Me.Order.Size = New System.Drawing.Size(415, 56)
        Me.Order.TabIndex = 19
        Me.Order.Text = "Place Order"
        Me.Order.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.totalp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 758)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 71)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'totalp
        '
        Me.totalp.AutoSize = True
        Me.totalp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalp.Location = New System.Drawing.Point(210, 25)
        Me.totalp.Name = "totalp"
        Me.totalp.Size = New System.Drawing.Size(199, 26)
        Me.totalp.TabIndex = 20
        Me.totalp.Text = "Total Price Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total Price :"
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Lime
        Me.Back.Location = New System.Drawing.Point(16, 293)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(107, 40)
        Me.Back.TabIndex = 17
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'lsorder
        '
        Me.lsorder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Food, Me.Quantity, Me.Price})
        Me.lsorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsorder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lsorder.GridLines = True
        Me.lsorder.HideSelection = False
        Me.lsorder.Location = New System.Drawing.Point(36, 420)
        Me.lsorder.Name = "lsorder"
        Me.lsorder.Scrollable = False
        Me.lsorder.Size = New System.Drawing.Size(416, 316)
        Me.lsorder.TabIndex = 16
        Me.lsorder.UseCompatibleStateImageBehavior = False
        Me.lsorder.View = System.Windows.Forms.View.Details
        '
        'Food
        '
        Me.Food.Text = "Food"
        Me.Food.Width = 137
        '
        'Quantity
        '
        Me.Quantity.DisplayIndex = 2
        Me.Quantity.Text = "Price"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Quantity.Width = 151
        '
        'Price
        '
        Me.Price.DisplayIndex = 1
        Me.Price.Text = "Quantity"
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Price.Width = 118
        '
        'txtroomfloor
        '
        Me.txtroomfloor.Location = New System.Drawing.Point(144, 191)
        Me.txtroomfloor.Name = "txtroomfloor"
        Me.txtroomfloor.Size = New System.Drawing.Size(210, 20)
        Me.txtroomfloor.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Room and Floor No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "barangay"
        '
        'txtbarangay
        '
        Me.txtbarangay.Location = New System.Drawing.Point(144, 111)
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(210, 20)
        Me.txtbarangay.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(163, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 39)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ORDER"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WebBrowser2)
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 950)
        Me.Panel2.TabIndex = 9
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(888, 950)
        Me.WebBrowser2.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(888, 950)
        Me.WebBrowser1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TrackingLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 950)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TrackingLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txthouseNo As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label6 As Label
    Friend WithEvents txtroomfloor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbarangay As TextBox
    Friend WithEvents lsorder As ListView
    Friend WithEvents Food As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Back As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents totalp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Order As Button
    Friend WithEvents Contact As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Clear As Button
    Friend WithEvents WebBrowser2 As WebBrowser
End Class
