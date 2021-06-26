<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loanpay
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
        Me.p_amt_paid = New System.Windows.Forms.NumericUpDown()
        Me.p_receiver = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.p_bal = New System.Windows.Forms.Label()
        Me.p_amt_due = New System.Windows.Forms.Label()
        Me.p_xtra = New System.Windows.Forms.Label()
        Me.p_total_cost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.p_emi_id = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p_l_id = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.p_btn_pay = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mainmenu.SuspendLayout()
        Me.pan_edit.SuspendLayout()
        CType(Me.p_amt_paid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mainmenu.Size = New System.Drawing.Size(919, 25)
        Me.mainmenu.TabIndex = 3
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
        Me.pan_edit.Controls.Add(Me.p_amt_paid)
        Me.pan_edit.Controls.Add(Me.p_receiver)
        Me.pan_edit.Controls.Add(Me.Label12)
        Me.pan_edit.Controls.Add(Me.p_bal)
        Me.pan_edit.Controls.Add(Me.p_amt_due)
        Me.pan_edit.Controls.Add(Me.p_xtra)
        Me.pan_edit.Controls.Add(Me.p_total_cost)
        Me.pan_edit.Controls.Add(Me.Label3)
        Me.pan_edit.Controls.Add(Me.Label2)
        Me.pan_edit.Controls.Add(Me.p_emi_id)
        Me.pan_edit.Controls.Add(Me.Label1)
        Me.pan_edit.Controls.Add(Me.p_l_id)
        Me.pan_edit.Controls.Add(Me.Label10)
        Me.pan_edit.Controls.Add(Me.Label9)
        Me.pan_edit.Controls.Add(Me.Label8)
        Me.pan_edit.Controls.Add(Me.Label7)
        Me.pan_edit.Controls.Add(Me.p_btn_pay)
        Me.pan_edit.Controls.Add(Me.Label14)
        Me.pan_edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_edit.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_edit.Location = New System.Drawing.Point(0, 25)
        Me.pan_edit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_edit.Name = "pan_edit"
        Me.pan_edit.Size = New System.Drawing.Size(919, 483)
        Me.pan_edit.TabIndex = 8
        '
        'p_amt_paid
        '
        Me.p_amt_paid.BackColor = System.Drawing.SystemColors.Window
        Me.p_amt_paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_amt_paid.DecimalPlaces = 2
        Me.p_amt_paid.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_amt_paid.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.p_amt_paid.Location = New System.Drawing.Point(177, 349)
        Me.p_amt_paid.Maximum = New Decimal(New Integer() {50000000, 0, 0, 0})
        Me.p_amt_paid.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.p_amt_paid.Name = "p_amt_paid"
        Me.p_amt_paid.Size = New System.Drawing.Size(160, 30)
        Me.p_amt_paid.TabIndex = 3
        Me.p_amt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.p_amt_paid.ThousandsSeparator = True
        Me.p_amt_paid.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'p_receiver
        '
        Me.p_receiver.AutoSize = True
        Me.p_receiver.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_receiver.ForeColor = System.Drawing.Color.Black
        Me.p_receiver.Location = New System.Drawing.Point(164, 455)
        Me.p_receiver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.p_receiver.Name = "p_receiver"
        Me.p_receiver.Size = New System.Drawing.Size(40, 24)
        Me.p_receiver.TabIndex = 67
        Me.p_receiver.Text = "***"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(12, 455)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 24)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Received By"
        '
        'p_bal
        '
        Me.p_bal.AutoSize = True
        Me.p_bal.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_bal.ForeColor = System.Drawing.Color.Black
        Me.p_bal.Location = New System.Drawing.Point(164, 404)
        Me.p_bal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.p_bal.Name = "p_bal"
        Me.p_bal.Size = New System.Drawing.Size(40, 24)
        Me.p_bal.TabIndex = 65
        Me.p_bal.Text = "***"
        '
        'p_amt_due
        '
        Me.p_amt_due.AutoSize = True
        Me.p_amt_due.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_amt_due.ForeColor = System.Drawing.Color.Black
        Me.p_amt_due.Location = New System.Drawing.Point(164, 195)
        Me.p_amt_due.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.p_amt_due.Name = "p_amt_due"
        Me.p_amt_due.Size = New System.Drawing.Size(40, 24)
        Me.p_amt_due.TabIndex = 64
        Me.p_amt_due.Text = "***"
        '
        'p_xtra
        '
        Me.p_xtra.AutoSize = True
        Me.p_xtra.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_xtra.ForeColor = System.Drawing.Color.Black
        Me.p_xtra.Location = New System.Drawing.Point(164, 246)
        Me.p_xtra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.p_xtra.Name = "p_xtra"
        Me.p_xtra.Size = New System.Drawing.Size(40, 24)
        Me.p_xtra.TabIndex = 63
        Me.p_xtra.Text = "***"
        '
        'p_total_cost
        '
        Me.p_total_cost.AutoSize = True
        Me.p_total_cost.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_total_cost.ForeColor = System.Drawing.Color.Black
        Me.p_total_cost.Location = New System.Drawing.Point(164, 297)
        Me.p_total_cost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.p_total_cost.Name = "p_total_cost"
        Me.p_total_cost.Size = New System.Drawing.Size(40, 24)
        Me.p_total_cost.TabIndex = 62
        Me.p_total_cost.Text = "***"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 297)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Total Cost (N)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 404)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Balance (N)"
        '
        'p_emi_id
        '
        Me.p_emi_id.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_emi_id.FormattingEnabled = True
        Me.p_emi_id.Items.AddRange(New Object() {"Customer Name", "Account No."})
        Me.p_emi_id.Location = New System.Drawing.Point(168, 137)
        Me.p_emi_id.Name = "p_emi_id"
        Me.p_emi_id.Size = New System.Drawing.Size(169, 31)
        Me.p_emi_id.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "EMI ID"
        '
        'p_l_id
        '
        Me.p_l_id.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_l_id.FormattingEnabled = True
        Me.p_l_id.Items.AddRange(New Object() {"Customer Name", "Account No."})
        Me.p_l_id.Location = New System.Drawing.Point(168, 79)
        Me.p_l_id.Name = "p_l_id"
        Me.p_l_id.Size = New System.Drawing.Size(169, 31)
        Me.p_l_id.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(11, 81)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 24)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Loan ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(12, 350)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 24)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Amount Paid (N)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 246)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 24)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Extra Charges (N)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(11, 195)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 24)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Amount Due (N)"
        '
        'p_btn_pay
        '
        Me.p_btn_pay.BackColor = System.Drawing.Color.SteelBlue
        Me.p_btn_pay.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.p_btn_pay.FlatAppearance.BorderSize = 2
        Me.p_btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p_btn_pay.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_btn_pay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p_btn_pay.Location = New System.Drawing.Point(168, 515)
        Me.p_btn_pay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.p_btn_pay.Name = "p_btn_pay"
        Me.p_btn_pay.Size = New System.Drawing.Size(120, 38)
        Me.p_btn_pay.TabIndex = 4
        Me.p_btn_pay.Text = "Pay"
        Me.p_btn_pay.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri Light", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(7, 14)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(250, 49)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Loan Payment"
        '
        'loanpay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(919, 508)
        Me.Controls.Add(Me.pan_edit)
        Me.Controls.Add(Me.mainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "loanpay"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Loan Management System - Loan Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainmenu.ResumeLayout(False)
        Me.mainmenu.PerformLayout()
        Me.pan_edit.ResumeLayout(False)
        Me.pan_edit.PerformLayout()
        CType(Me.p_amt_paid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_query As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_home As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_logout As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents p_l_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents p_btn_pay As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents p_emi_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents p_receiver As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents p_bal As System.Windows.Forms.Label
    Friend WithEvents p_amt_due As System.Windows.Forms.Label
    Friend WithEvents p_xtra As System.Windows.Forms.Label
    Friend WithEvents p_total_cost As System.Windows.Forms.Label
    Friend WithEvents p_amt_paid As System.Windows.Forms.NumericUpDown
End Class
