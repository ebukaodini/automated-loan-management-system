<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageloan
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
        Me.pan_issue = New System.Windows.Forms.Panel()
        Me.calc = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.l_no_inst = New System.Windows.Forms.ComboBox()
        Me.loan_id = New System.Windows.Forms.Label()
        Me.l_name = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.l_interest = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_cus_name = New System.Windows.Forms.Label()
        Me.cus_id = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbl_cus_accno = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.l_emi_no = New System.Windows.Forms.Label()
        Me.l_emi = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.l_cost = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_add_sec = New System.Windows.Forms.Button()
        Me.sec_id = New System.Windows.Forms.Label()
        Me.s_val = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.s_detail = New System.Windows.Forms.TextBox()
        Me.s_name = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_add_gua = New System.Windows.Forms.Button()
        Me.g_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gua_id = New System.Windows.Forms.Label()
        Me.g_tel = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.g_address = New System.Windows.Forms.TextBox()
        Me.g_name = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.l_repay = New System.Windows.Forms.DateTimePicker()
        Me.g_cus_pick = New System.Windows.Forms.ComboBox()
        Me.l_intr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.l_type = New System.Windows.Forms.ComboBox()
        Me.l_amount = New System.Windows.Forms.NumericUpDown()
        Me.l_tenure = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_issue = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mainmenu.SuspendLayout()
        Me.pan_issue.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.l_amount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.l_tenure, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pan_issue
        '
        Me.pan_issue.AutoScroll = True
        Me.pan_issue.BackColor = System.Drawing.Color.Snow
        Me.pan_issue.Controls.Add(Me.calc)
        Me.pan_issue.Controls.Add(Me.Label15)
        Me.pan_issue.Controls.Add(Me.l_no_inst)
        Me.pan_issue.Controls.Add(Me.loan_id)
        Me.pan_issue.Controls.Add(Me.l_name)
        Me.pan_issue.Controls.Add(Me.Label13)
        Me.pan_issue.Controls.Add(Me.l_interest)
        Me.pan_issue.Controls.Add(Me.Label18)
        Me.pan_issue.Controls.Add(Me.lbl_cus_name)
        Me.pan_issue.Controls.Add(Me.cus_id)
        Me.pan_issue.Controls.Add(Me.Label29)
        Me.pan_issue.Controls.Add(Me.lbl_cus_accno)
        Me.pan_issue.Controls.Add(Me.user)
        Me.pan_issue.Controls.Add(Me.Label26)
        Me.pan_issue.Controls.Add(Me.l_emi_no)
        Me.pan_issue.Controls.Add(Me.l_emi)
        Me.pan_issue.Controls.Add(Me.Label23)
        Me.pan_issue.Controls.Add(Me.l_cost)
        Me.pan_issue.Controls.Add(Me.Label21)
        Me.pan_issue.Controls.Add(Me.Label12)
        Me.pan_issue.Controls.Add(Me.GroupBox2)
        Me.pan_issue.Controls.Add(Me.Label4)
        Me.pan_issue.Controls.Add(Me.GroupBox1)
        Me.pan_issue.Controls.Add(Me.l_repay)
        Me.pan_issue.Controls.Add(Me.g_cus_pick)
        Me.pan_issue.Controls.Add(Me.l_intr)
        Me.pan_issue.Controls.Add(Me.Label14)
        Me.pan_issue.Controls.Add(Me.l_type)
        Me.pan_issue.Controls.Add(Me.l_amount)
        Me.pan_issue.Controls.Add(Me.l_tenure)
        Me.pan_issue.Controls.Add(Me.Label6)
        Me.pan_issue.Controls.Add(Me.Label10)
        Me.pan_issue.Controls.Add(Me.Label3)
        Me.pan_issue.Controls.Add(Me.btn_issue)
        Me.pan_issue.Controls.Add(Me.Label7)
        Me.pan_issue.Controls.Add(Me.Label2)
        Me.pan_issue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_issue.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_issue.Location = New System.Drawing.Point(0, 25)
        Me.pan_issue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_issue.Name = "pan_issue"
        Me.pan_issue.Padding = New System.Windows.Forms.Padding(5)
        Me.pan_issue.Size = New System.Drawing.Size(939, 493)
        Me.pan_issue.TabIndex = 4
        '
        'calc
        '
        Me.calc.BackColor = System.Drawing.Color.SteelBlue
        Me.calc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.calc.FlatAppearance.BorderSize = 2
        Me.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.calc.Location = New System.Drawing.Point(230, 803)
        Me.calc.Margin = New System.Windows.Forms.Padding(20)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(149, 38)
        Me.calc.TabIndex = 30
        Me.calc.Text = "Calculate"
        Me.calc.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(12, 535)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 24)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Payment Interval"
        '
        'l_no_inst
        '
        Me.l_no_inst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.l_no_inst.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_no_inst.FormattingEnabled = True
        Me.l_no_inst.Items.AddRange(New Object() {"12", "6", "4", "3", "2"})
        Me.l_no_inst.Location = New System.Drawing.Point(230, 540)
        Me.l_no_inst.Name = "l_no_inst"
        Me.l_no_inst.Size = New System.Drawing.Size(222, 31)
        Me.l_no_inst.TabIndex = 28
        '
        'loan_id
        '
        Me.loan_id.AutoSize = True
        Me.loan_id.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_id.ForeColor = System.Drawing.Color.Green
        Me.loan_id.Location = New System.Drawing.Point(760, 67)
        Me.loan_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.loan_id.Name = "loan_id"
        Me.loan_id.Size = New System.Drawing.Size(27, 24)
        Me.loan_id.TabIndex = 27
        Me.loan_id.Text = "ID"
        '
        'l_name
        '
        Me.l_name.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_name.FormattingEnabled = True
        Me.l_name.Items.AddRange(New Object() {"Customer Name", "Account No."})
        Me.l_name.Location = New System.Drawing.Point(586, 60)
        Me.l_name.Name = "l_name"
        Me.l_name.Size = New System.Drawing.Size(169, 31)
        Me.l_name.TabIndex = 3
        Me.l_name.Text = "Select Loan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(481, 62)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 24)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Loan Name"
        '
        'l_interest
        '
        Me.l_interest.AutoSize = True
        Me.l_interest.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_interest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.l_interest.Location = New System.Drawing.Point(230, 629)
        Me.l_interest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_interest.Name = "l_interest"
        Me.l_interest.Size = New System.Drawing.Size(40, 24)
        Me.l_interest.TabIndex = 23
        Me.l_interest.Text = "***"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(12, 617)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 24)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Total Interest (N)"
        '
        'lbl_cus_name
        '
        Me.lbl_cus_name.AutoSize = True
        Me.lbl_cus_name.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cus_name.ForeColor = System.Drawing.Color.Green
        Me.lbl_cus_name.Location = New System.Drawing.Point(691, 378)
        Me.lbl_cus_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cus_name.Name = "lbl_cus_name"
        Me.lbl_cus_name.Size = New System.Drawing.Size(40, 24)
        Me.lbl_cus_name.TabIndex = 21
        Me.lbl_cus_name.Text = "***"
        '
        'cus_id
        '
        Me.cus_id.AutoSize = True
        Me.cus_id.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cus_id.ForeColor = System.Drawing.Color.Green
        Me.cus_id.Location = New System.Drawing.Point(327, 67)
        Me.cus_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cus_id.Name = "cus_id"
        Me.cus_id.Size = New System.Drawing.Size(27, 24)
        Me.cus_id.TabIndex = 20
        Me.cus_id.Text = "ID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Green
        Me.Label29.Location = New System.Drawing.Point(530, 410)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(109, 24)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "Account No."
        '
        'lbl_cus_accno
        '
        Me.lbl_cus_accno.AutoSize = True
        Me.lbl_cus_accno.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cus_accno.ForeColor = System.Drawing.Color.Green
        Me.lbl_cus_accno.Location = New System.Drawing.Point(691, 410)
        Me.lbl_cus_accno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cus_accno.Name = "lbl_cus_accno"
        Me.lbl_cus_accno.Size = New System.Drawing.Size(40, 24)
        Me.lbl_cus_accno.TabIndex = 17
        Me.lbl_cus_accno.Text = "***"
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.SystemColors.ControlText
        Me.user.Location = New System.Drawing.Point(230, 743)
        Me.user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(40, 24)
        Me.user.TabIndex = 15
        Me.user.Text = "***"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(12, 740)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 24)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Granted By"
        '
        'l_emi_no
        '
        Me.l_emi_no.AutoSize = True
        Me.l_emi_no.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_emi_no.ForeColor = System.Drawing.SystemColors.ControlText
        Me.l_emi_no.Location = New System.Drawing.Point(485, 699)
        Me.l_emi_no.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_emi_no.Name = "l_emi_no"
        Me.l_emi_no.Size = New System.Drawing.Size(40, 24)
        Me.l_emi_no.TabIndex = 13
        Me.l_emi_no.Text = "***"
        '
        'l_emi
        '
        Me.l_emi.AutoSize = True
        Me.l_emi.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_emi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.l_emi.Location = New System.Drawing.Point(230, 705)
        Me.l_emi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_emi.Name = "l_emi"
        Me.l_emi.Size = New System.Drawing.Size(40, 24)
        Me.l_emi.TabIndex = 11
        Me.l_emi.Text = "***"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(12, 699)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 24)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "EMI (N)"
        '
        'l_cost
        '
        Me.l_cost.AutoSize = True
        Me.l_cost.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.l_cost.Location = New System.Drawing.Point(230, 667)
        Me.l_cost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_cost.Name = "l_cost"
        Me.l_cost.Size = New System.Drawing.Size(40, 24)
        Me.l_cost.TabIndex = 9
        Me.l_cost.Text = "***"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(12, 658)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 24)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Total Cost (N)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(12, 576)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 24)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Repay date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_add_sec)
        Me.GroupBox2.Controls.Add(Me.sec_id)
        Me.GroupBox2.Controls.Add(Me.s_val)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.s_detail)
        Me.GroupBox2.Controls.Add(Me.s_name)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(489, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 270)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security Detail"
        '
        'btn_add_sec
        '
        Me.btn_add_sec.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_add_sec.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_add_sec.FlatAppearance.BorderSize = 2
        Me.btn_add_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_sec.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_sec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add_sec.Location = New System.Drawing.Point(86, 234)
        Me.btn_add_sec.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_add_sec.Name = "btn_add_sec"
        Me.btn_add_sec.Size = New System.Drawing.Size(93, 29)
        Me.btn_add_sec.TabIndex = 14
        Me.btn_add_sec.Text = "Update"
        Me.btn_add_sec.UseVisualStyleBackColor = False
        '
        'sec_id
        '
        Me.sec_id.AutoSize = True
        Me.sec_id.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec_id.ForeColor = System.Drawing.Color.Green
        Me.sec_id.Location = New System.Drawing.Point(183, 234)
        Me.sec_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sec_id.Name = "sec_id"
        Me.sec_id.Size = New System.Drawing.Size(27, 24)
        Me.sec_id.TabIndex = 0
        Me.sec_id.Text = "ID"
        '
        's_val
        '
        Me.s_val.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_val.Location = New System.Drawing.Point(86, 58)
        Me.s_val.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.s_val.Multiline = True
        Me.s_val.Name = "s_val"
        Me.s_val.Size = New System.Drawing.Size(222, 29)
        Me.s_val.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 63)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 24)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Value"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(7, 28)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 24)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Name"
        '
        's_detail
        '
        Me.s_detail.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_detail.Location = New System.Drawing.Point(86, 96)
        Me.s_detail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.s_detail.Multiline = True
        Me.s_detail.Name = "s_detail"
        Me.s_detail.Size = New System.Drawing.Size(289, 132)
        Me.s_detail.TabIndex = 12
        '
        's_name
        '
        Me.s_name.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_name.Location = New System.Drawing.Point(86, 26)
        Me.s_name.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.s_name.Multiline = True
        Me.s_name.Name = "s_name"
        Me.s_name.Size = New System.Drawing.Size(222, 29)
        Me.s_name.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 95)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 24)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 453)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Amount (N)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_add_gua)
        Me.GroupBox1.Controls.Add(Me.g_email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.gua_id)
        Me.GroupBox1.Controls.Add(Me.g_tel)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.g_address)
        Me.GroupBox1.Controls.Add(Me.g_name)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 263)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guarantor's Detail"
        '
        'btn_add_gua
        '
        Me.btn_add_gua.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_add_gua.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_add_gua.FlatAppearance.BorderSize = 2
        Me.btn_add_gua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_gua.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_gua.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add_gua.Location = New System.Drawing.Point(140, 230)
        Me.btn_add_gua.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_add_gua.Name = "btn_add_gua"
        Me.btn_add_gua.Size = New System.Drawing.Size(93, 29)
        Me.btn_add_gua.TabIndex = 9
        Me.btn_add_gua.Text = "Update"
        Me.btn_add_gua.UseVisualStyleBackColor = False
        '
        'g_email
        '
        Me.g_email.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_email.Location = New System.Drawing.Point(140, 93)
        Me.g_email.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.g_email.Multiline = True
        Me.g_email.Name = "g_email"
        Me.g_email.Size = New System.Drawing.Size(222, 29)
        Me.g_email.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(7, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email"
        '
        'gua_id
        '
        Me.gua_id.AutoSize = True
        Me.gua_id.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gua_id.ForeColor = System.Drawing.Color.Green
        Me.gua_id.Location = New System.Drawing.Point(237, 230)
        Me.gua_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gua_id.Name = "gua_id"
        Me.gua_id.Size = New System.Drawing.Size(27, 24)
        Me.gua_id.TabIndex = 16
        Me.gua_id.Text = "ID"
        '
        'g_tel
        '
        Me.g_tel.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_tel.Location = New System.Drawing.Point(140, 58)
        Me.g_tel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.g_tel.Multiline = True
        Me.g_tel.Name = "g_tel"
        Me.g_tel.Size = New System.Drawing.Size(222, 29)
        Me.g_tel.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(5, 60)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 24)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Telephone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'g_address
        '
        Me.g_address.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_address.Location = New System.Drawing.Point(140, 126)
        Me.g_address.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.g_address.Multiline = True
        Me.g_address.Name = "g_address"
        Me.g_address.Size = New System.Drawing.Size(283, 98)
        Me.g_address.TabIndex = 8
        '
        'g_name
        '
        Me.g_name.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_name.Location = New System.Drawing.Point(140, 26)
        Me.g_name.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.g_name.Multiline = True
        Me.g_name.Name = "g_name"
        Me.g_name.Size = New System.Drawing.Size(222, 29)
        Me.g_name.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(7, 128)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 24)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Address"
        '
        'l_repay
        '
        Me.l_repay.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_repay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.l_repay.Location = New System.Drawing.Point(230, 585)
        Me.l_repay.MinDate = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.l_repay.Name = "l_repay"
        Me.l_repay.Size = New System.Drawing.Size(222, 30)
        Me.l_repay.TabIndex = 18
        '
        'g_cus_pick
        '
        Me.g_cus_pick.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_cus_pick.FormattingEnabled = True
        Me.g_cus_pick.Items.AddRange(New Object() {"Customer Name", "Account No."})
        Me.g_cus_pick.Location = New System.Drawing.Point(153, 60)
        Me.g_cus_pick.Name = "g_cus_pick"
        Me.g_cus_pick.Size = New System.Drawing.Size(169, 31)
        Me.g_cus_pick.TabIndex = 1
        Me.g_cus_pick.Text = "Select Customer"
        '
        'l_intr
        '
        Me.l_intr.AutoSize = True
        Me.l_intr.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_intr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.l_intr.Location = New System.Drawing.Point(230, 414)
        Me.l_intr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_intr.Name = "l_intr"
        Me.l_intr.Size = New System.Drawing.Size(40, 24)
        Me.l_intr.TabIndex = 0
        Me.l_intr.Text = "***"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(12, 412)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Interest Rate/Year (%)"
        '
        'l_type
        '
        Me.l_type.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_type.FormattingEnabled = True
        Me.l_type.Items.AddRange(New Object() {"Home Loan", "Student Loan", "Bridge Loan", "Bank Loan", "Inter-Bank Loan", "Business Loan", "Commercial Loan", "Installation Loan", "Demand Loan", "Personal Loan", "Consumer Loan", "Automobile Loan", "Real-Estate Loan"})
        Me.l_type.Location = New System.Drawing.Point(230, 369)
        Me.l_type.Name = "l_type"
        Me.l_type.Size = New System.Drawing.Size(222, 31)
        Me.l_type.TabIndex = 15
        '
        'l_amount
        '
        Me.l_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l_amount.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_amount.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.l_amount.Location = New System.Drawing.Point(230, 452)
        Me.l_amount.Maximum = New Decimal(New Integer() {50000000, 0, 0, 0})
        Me.l_amount.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.l_amount.Name = "l_amount"
        Me.l_amount.Size = New System.Drawing.Size(222, 30)
        Me.l_amount.TabIndex = 16
        Me.l_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.l_amount.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'l_tenure
        '
        Me.l_tenure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l_tenure.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_tenure.Location = New System.Drawing.Point(230, 496)
        Me.l_tenure.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.l_tenure.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.l_tenure.Name = "l_tenure"
        Me.l_tenure.Size = New System.Drawing.Size(222, 30)
        Me.l_tenure.TabIndex = 17
        Me.l_tenure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.l_tenure.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 371)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Loan Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(12, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(529, 378)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer name"
        '
        'btn_issue
        '
        Me.btn_issue.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_issue.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_issue.FlatAppearance.BorderSize = 2
        Me.btn_issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_issue.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_issue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_issue.Location = New System.Drawing.Point(230, 847)
        Me.btn_issue.Margin = New System.Windows.Forms.Padding(20)
        Me.btn_issue.Name = "btn_issue"
        Me.btn_issue.Size = New System.Drawing.Size(149, 38)
        Me.btn_issue.TabIndex = 19
        Me.btn_issue.Text = "Grant Loan"
        Me.btn_issue.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 494)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tenure (Years)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(4, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 49)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Manage Loan"
        '
        'manageloan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(939, 518)
        Me.Controls.Add(Me.pan_issue)
        Me.Controls.Add(Me.mainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "manageloan"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Loan Management System -  Manage Loan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainmenu.ResumeLayout(False)
        Me.mainmenu.PerformLayout()
        Me.pan_issue.ResumeLayout(False)
        Me.pan_issue.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.l_amount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.l_tenure, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pan_issue As System.Windows.Forms.Panel
    Friend WithEvents l_interest As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_cus_name As System.Windows.Forms.Label
    Friend WithEvents cus_id As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lbl_cus_accno As System.Windows.Forms.Label
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents l_emi_no As System.Windows.Forms.Label
    Friend WithEvents l_emi As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents l_cost As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents l_repay As System.Windows.Forms.DateTimePicker
    Friend WithEvents l_intr As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents l_type As System.Windows.Forms.ComboBox
    Friend WithEvents l_amount As System.Windows.Forms.NumericUpDown
    Friend WithEvents l_tenure As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_issue As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents l_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add_sec As System.Windows.Forms.Button
    Friend WithEvents sec_id As System.Windows.Forms.Label
    Friend WithEvents s_val As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents s_detail As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add_gua As System.Windows.Forms.Button
    Friend WithEvents g_email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gua_id As System.Windows.Forms.Label
    Friend WithEvents g_address As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents g_cus_pick As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents loan_id As System.Windows.Forms.Label
    Friend WithEvents s_name As System.Windows.Forms.TextBox
    Friend WithEvents g_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents g_name As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents l_no_inst As System.Windows.Forms.ComboBox
    Friend WithEvents calc As System.Windows.Forms.Button
End Class
