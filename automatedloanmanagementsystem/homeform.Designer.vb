<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainmenu = New System.Windows.Forms.MenuStrip()
        Me.mnu_query = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_home = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_sep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_pay_loan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_add_customer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_iss_loan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_mng_customer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_mng_loans = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_mng_users = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_mng_rates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.q_filter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.q_go = New System.Windows.Forms.Button()
        Me.q_search = New System.Windows.Forms.TextBox()
        Me.pan_customers = New System.Windows.Forms.Panel()
        Me.q_result = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cus_address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.acc_mng_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mainmenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pan_customers.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainmenu
        '
        Me.mainmenu.BackColor = System.Drawing.Color.SteelBlue
        Me.mainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_query, Me.mnu_pay_loan, Me.mnu_add_customer, Me.mnu_iss_loan, Me.mnu_mng_customer, Me.mnu_mng_loans, Me.mnu_mng_users, Me.mnu_mng_rates, Me.mnu_help})
        Me.mainmenu.Location = New System.Drawing.Point(0, 0)
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.mainmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mainmenu.Size = New System.Drawing.Size(939, 25)
        Me.mainmenu.TabIndex = 2
        Me.mainmenu.Text = "MenuStrip1"
        '
        'mnu_query
        '
        Me.mnu_query.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_home, Me.mnu_logout, Me.mnu_sep, Me.mnu_exit})
        Me.mnu_query.Name = "mnu_query"
        Me.mnu_query.Size = New System.Drawing.Size(85, 19)
        Me.mnu_query.Text = "ALMS &Query"
        '
        'mnu_home
        '
        Me.mnu_home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_home.Name = "mnu_home"
        Me.mnu_home.Size = New System.Drawing.Size(117, 22)
        Me.mnu_home.Text = "&Home"
        '
        'mnu_logout
        '
        Me.mnu_logout.Name = "mnu_logout"
        Me.mnu_logout.Size = New System.Drawing.Size(117, 22)
        Me.mnu_logout.Text = "&Log Out"
        '
        'mnu_sep
        '
        Me.mnu_sep.Name = "mnu_sep"
        Me.mnu_sep.Size = New System.Drawing.Size(114, 6)
        '
        'mnu_exit
        '
        Me.mnu_exit.Name = "mnu_exit"
        Me.mnu_exit.Size = New System.Drawing.Size(117, 22)
        Me.mnu_exit.Text = "E&xit"
        '
        'mnu_pay_loan
        '
        Me.mnu_pay_loan.Name = "mnu_pay_loan"
        Me.mnu_pay_loan.Size = New System.Drawing.Size(95, 19)
        Me.mnu_pay_loan.Text = "Loan &Payment"
        '
        'mnu_add_customer
        '
        Me.mnu_add_customer.Name = "mnu_add_customer"
        Me.mnu_add_customer.Size = New System.Drawing.Size(96, 19)
        Me.mnu_add_customer.Text = "&Add Customer"
        '
        'mnu_iss_loan
        '
        Me.mnu_iss_loan.Name = "mnu_iss_loan"
        Me.mnu_iss_loan.Size = New System.Drawing.Size(74, 19)
        Me.mnu_iss_loan.Text = "&Issue Loan"
        '
        'mnu_mng_customer
        '
        Me.mnu_mng_customer.Name = "mnu_mng_customer"
        Me.mnu_mng_customer.Size = New System.Drawing.Size(122, 19)
        Me.mnu_mng_customer.Text = "Manage &Customers"
        '
        'mnu_mng_loans
        '
        Me.mnu_mng_loans.Name = "mnu_mng_loans"
        Me.mnu_mng_loans.Size = New System.Drawing.Size(96, 19)
        Me.mnu_mng_loans.Text = "Manage &Loans"
        '
        'mnu_mng_users
        '
        Me.mnu_mng_users.Name = "mnu_mng_users"
        Me.mnu_mng_users.Size = New System.Drawing.Size(93, 19)
        Me.mnu_mng_users.Text = "Manage &Users"
        '
        'mnu_mng_rates
        '
        Me.mnu_mng_rates.Name = "mnu_mng_rates"
        Me.mnu_mng_rates.Size = New System.Drawing.Size(93, 19)
        Me.mnu_mng_rates.Text = "Manage &Rates"
        '
        'mnu_help
        '
        Me.mnu_help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_about})
        Me.mnu_help.Name = "mnu_help"
        Me.mnu_help.Size = New System.Drawing.Size(44, 19)
        Me.mnu_help.Text = "&Help"
        '
        'mnu_about
        '
        Me.mnu_about.Name = "mnu_about"
        Me.mnu_about.Size = New System.Drawing.Size(325, 22)
        Me.mnu_about.Text = "&About  Automated Loan Management Software"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.SplitContainer1.Panel1.Controls.Add(Me.q_filter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.q_go)
        Me.SplitContainer1.Panel1.Controls.Add(Me.q_search)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.pan_customers)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(939, 493)
        Me.SplitContainer1.SplitterDistance = 83
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'q_filter
        '
        Me.q_filter.BackColor = System.Drawing.Color.SteelBlue
        Me.q_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.q_filter.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_filter.FormattingEnabled = True
        Me.q_filter.Items.AddRange(New Object() {"Customer", "Loans", "Payments", "Interest Rates", "EMI", "Guarantor", "Security"})
        Me.q_filter.Location = New System.Drawing.Point(92, 43)
        Me.q_filter.Name = "q_filter"
        Me.q_filter.Size = New System.Drawing.Size(172, 31)
        Me.q_filter.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Query"
        '
        'q_go
        '
        Me.q_go.BackColor = System.Drawing.Color.SteelBlue
        Me.q_go.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.q_go.FlatAppearance.BorderSize = 2
        Me.q_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.q_go.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_go.ForeColor = System.Drawing.SystemColors.ControlText
        Me.q_go.Location = New System.Drawing.Point(270, 45)
        Me.q_go.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.q_go.Name = "q_go"
        Me.q_go.Size = New System.Drawing.Size(93, 29)
        Me.q_go.TabIndex = 3
        Me.q_go.Text = "Search"
        Me.q_go.UseVisualStyleBackColor = False
        '
        'q_search
        '
        Me.q_search.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_search.Location = New System.Drawing.Point(92, 8)
        Me.q_search.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.q_search.Multiline = True
        Me.q_search.Name = "q_search"
        Me.q_search.Size = New System.Drawing.Size(271, 29)
        Me.q_search.TabIndex = 1
        '
        'pan_customers
        '
        Me.pan_customers.AutoScroll = True
        Me.pan_customers.BackColor = System.Drawing.Color.Snow
        Me.pan_customers.Controls.Add(Me.q_result)
        Me.pan_customers.Controls.Add(Me.Label3)
        Me.pan_customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_customers.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_customers.Location = New System.Drawing.Point(0, 0)
        Me.pan_customers.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_customers.Name = "pan_customers"
        Me.pan_customers.Size = New System.Drawing.Size(939, 406)
        Me.pan_customers.TabIndex = 1
        '
        'q_result
        '
        Me.q_result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q_result.BackColor = System.Drawing.Color.Snow
        Me.q_result.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.cus_address, Me.contact, Me.email, Me.acc_mng_no})
        Me.q_result.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q_result.FullRowSelect = True
        Me.q_result.GridLines = True
        Me.q_result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.q_result.HideSelection = False
        Me.q_result.HoverSelection = True
        Me.q_result.Location = New System.Drawing.Point(3, 52)
        Me.q_result.Name = "q_result"
        Me.q_result.Size = New System.Drawing.Size(929, 351)
        Me.q_result.TabIndex = 0
        Me.q_result.TabStop = False
        Me.q_result.TileSize = New System.Drawing.Size(428, 70)
        Me.q_result.UseCompatibleStateImageBehavior = False
        Me.q_result.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "S/N"
        Me.ColumnHeader1.Width = 47
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'cus_address
        '
        Me.cus_address.Text = "Address"
        Me.cus_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cus_address.Width = 150
        '
        'contact
        '
        Me.contact.Text = "Contact"
        Me.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.contact.Width = 120
        '
        'email
        '
        Me.email.Text = "E-mail"
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.email.Width = 150
        '
        'acc_mng_no
        '
        Me.acc_mng_no.Text = "Account No."
        Me.acc_mng_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.acc_mng_no.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(2, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 49)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Results"
        '
        'homeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(939, 518)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "homeform"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Loan Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainmenu.ResumeLayout(False)
        Me.mainmenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pan_customers.ResumeLayout(False)
        Me.pan_customers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_query As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_home As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_customer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_loans As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_users As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_rates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_about As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_pay_loan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_add_customer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_iss_loan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pan_customers As System.Windows.Forms.Panel
    Friend WithEvents q_go As System.Windows.Forms.Button
    Friend WithEvents q_result As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cus_address As System.Windows.Forms.ColumnHeader
    Friend WithEvents contact As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents acc_mng_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents q_search As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mnu_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents q_filter As System.Windows.Forms.ComboBox
End Class
