<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managecustomer
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
        Me.pan_edit = New System.Windows.Forms.Panel()
        Me.c_result = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cus_address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.acc_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cus_id = New System.Windows.Forms.Label()
        Me.cus_mng_pick = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.c_mng_accno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c_mng_email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c_mng_tel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c_mng_address = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.c_mng_update = New System.Windows.Forms.Button()
        Me.mainmenu.SuspendLayout()
        Me.pan_edit.SuspendLayout()
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
        Me.mainmenu.Size = New System.Drawing.Size(929, 25)
        Me.mainmenu.TabIndex = 5
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
        'pan_edit
        '
        Me.pan_edit.AutoScroll = True
        Me.pan_edit.BackColor = System.Drawing.Color.Snow
        Me.pan_edit.Controls.Add(Me.c_result)
        Me.pan_edit.Controls.Add(Me.cus_id)
        Me.pan_edit.Controls.Add(Me.cus_mng_pick)
        Me.pan_edit.Controls.Add(Me.Label10)
        Me.pan_edit.Controls.Add(Me.c_mng_accno)
        Me.pan_edit.Controls.Add(Me.Label9)
        Me.pan_edit.Controls.Add(Me.c_mng_email)
        Me.pan_edit.Controls.Add(Me.Label8)
        Me.pan_edit.Controls.Add(Me.c_mng_tel)
        Me.pan_edit.Controls.Add(Me.Label7)
        Me.pan_edit.Controls.Add(Me.c_mng_address)
        Me.pan_edit.Controls.Add(Me.Label6)
        Me.pan_edit.Controls.Add(Me.Label14)
        Me.pan_edit.Controls.Add(Me.c_mng_update)
        Me.pan_edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_edit.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_edit.Location = New System.Drawing.Point(0, 25)
        Me.pan_edit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_edit.Name = "pan_edit"
        Me.pan_edit.Size = New System.Drawing.Size(929, 483)
        Me.pan_edit.TabIndex = 6
        '
        'c_result
        '
        Me.c_result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c_result.BackColor = System.Drawing.Color.Snow
        Me.c_result.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.cus_address, Me.contact, Me.email, Me.acc_no})
        Me.c_result.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_result.FullRowSelect = True
        Me.c_result.GridLines = True
        Me.c_result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.c_result.HideSelection = False
        Me.c_result.HoverSelection = True
        Me.c_result.Location = New System.Drawing.Point(12, 440)
        Me.c_result.Name = "c_result"
        Me.c_result.Size = New System.Drawing.Size(905, 31)
        Me.c_result.TabIndex = 46
        Me.c_result.TabStop = False
        Me.c_result.TileSize = New System.Drawing.Size(428, 70)
        Me.c_result.UseCompatibleStateImageBehavior = False
        Me.c_result.View = System.Windows.Forms.View.Details
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
        Me.cus_address.Width = 154
        '
        'contact
        '
        Me.contact.Text = "Contact"
        Me.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.contact.Width = 98
        '
        'email
        '
        Me.email.Text = "E-mail"
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.email.Width = 150
        '
        'acc_no
        '
        Me.acc_no.Text = "Account No."
        Me.acc_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.acc_no.Width = 150
        '
        'cus_id
        '
        Me.cus_id.AutoSize = True
        Me.cus_id.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cus_id.ForeColor = System.Drawing.Color.Green
        Me.cus_id.Location = New System.Drawing.Point(341, 92)
        Me.cus_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cus_id.Name = "cus_id"
        Me.cus_id.Size = New System.Drawing.Size(27, 24)
        Me.cus_id.TabIndex = 45
        Me.cus_id.Text = "ID"
        '
        'cus_mng_pick
        '
        Me.cus_mng_pick.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cus_mng_pick.FormattingEnabled = True
        Me.cus_mng_pick.Items.AddRange(New Object() {"Customer Name", "Account No."})
        Me.cus_mng_pick.Location = New System.Drawing.Point(167, 85)
        Me.cus_mng_pick.Name = "cus_mng_pick"
        Me.cus_mng_pick.Size = New System.Drawing.Size(169, 31)
        Me.cus_mng_pick.TabIndex = 1
        Me.cus_mng_pick.Text = "Select Customer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(17, 87)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 24)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Customer"
        '
        'c_mng_accno
        '
        Me.c_mng_accno.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_mng_accno.Location = New System.Drawing.Point(168, 129)
        Me.c_mng_accno.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.c_mng_accno.Multiline = True
        Me.c_mng_accno.Name = "c_mng_accno"
        Me.c_mng_accno.Size = New System.Drawing.Size(222, 29)
        Me.c_mng_accno.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(17, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Account Number"
        '
        'c_mng_email
        '
        Me.c_mng_email.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_mng_email.Location = New System.Drawing.Point(167, 220)
        Me.c_mng_email.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.c_mng_email.Multiline = True
        Me.c_mng_email.Name = "c_mng_email"
        Me.c_mng_email.Size = New System.Drawing.Size(222, 29)
        Me.c_mng_email.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(21, 222)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 24)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "E-mail"
        '
        'c_mng_tel
        '
        Me.c_mng_tel.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_mng_tel.Location = New System.Drawing.Point(167, 171)
        Me.c_mng_tel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.c_mng_tel.Multiline = True
        Me.c_mng_tel.Name = "c_mng_tel"
        Me.c_mng_tel.Size = New System.Drawing.Size(222, 29)
        Me.c_mng_tel.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(17, 173)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 24)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Telephone"
        '
        'c_mng_address
        '
        Me.c_mng_address.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_mng_address.Location = New System.Drawing.Point(167, 272)
        Me.c_mng_address.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.c_mng_address.Multiline = True
        Me.c_mng_address.Name = "c_mng_address"
        Me.c_mng_address.Size = New System.Drawing.Size(393, 102)
        Me.c_mng_address.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(21, 274)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri Light", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(7, 14)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(320, 49)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Manage Customer"
        '
        'c_mng_update
        '
        Me.c_mng_update.BackColor = System.Drawing.Color.SteelBlue
        Me.c_mng_update.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.c_mng_update.FlatAppearance.BorderSize = 2
        Me.c_mng_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c_mng_update.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_mng_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c_mng_update.Location = New System.Drawing.Point(167, 380)
        Me.c_mng_update.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.c_mng_update.Name = "c_mng_update"
        Me.c_mng_update.Size = New System.Drawing.Size(158, 38)
        Me.c_mng_update.TabIndex = 7
        Me.c_mng_update.TabStop = False
        Me.c_mng_update.Text = "Update Account"
        Me.c_mng_update.UseVisualStyleBackColor = False
        '
        'managecustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(929, 508)
        Me.Controls.Add(Me.pan_edit)
        Me.Controls.Add(Me.mainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "managecustomer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Loan Management System - Manage Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainmenu.ResumeLayout(False)
        Me.mainmenu.PerformLayout()
        Me.pan_edit.ResumeLayout(False)
        Me.pan_edit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_query As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_home As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_pay_loan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_add_customer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_iss_loan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_customer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_loans As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_users As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mng_rates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_about As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pan_edit As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents c_mng_update As System.Windows.Forms.Button
    Friend WithEvents mnu_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents c_mng_accno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents c_mng_email As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c_mng_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents c_mng_address As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cus_id As System.Windows.Forms.Label
    Friend WithEvents cus_mng_pick As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents c_result As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cus_address As System.Windows.Forms.ColumnHeader
    Friend WithEvents contact As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents acc_no As System.Windows.Forms.ColumnHeader
End Class
