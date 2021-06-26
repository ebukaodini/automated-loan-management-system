<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerates
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
        Me.pan_int_rate = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.int_arrears = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.i_update = New System.Windows.Forms.Button()
        Me.int_home = New System.Windows.Forms.NumericUpDown()
        Me.i_edit = New System.Windows.Forms.Button()
        Me.int_auto = New System.Windows.Forms.NumericUpDown()
        Me.int_consumer = New System.Windows.Forms.NumericUpDown()
        Me.int_personal = New System.Windows.Forms.NumericUpDown()
        Me.int_demand = New System.Windows.Forms.NumericUpDown()
        Me.int_estate = New System.Windows.Forms.NumericUpDown()
        Me.int_install = New System.Windows.Forms.NumericUpDown()
        Me.int_comm = New System.Windows.Forms.NumericUpDown()
        Me.int_business = New System.Windows.Forms.NumericUpDown()
        Me.int_ibank = New System.Windows.Forms.NumericUpDown()
        Me.int_bank = New System.Windows.Forms.NumericUpDown()
        Me.int_bridge = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.r_gntr_contact = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.int_student = New System.Windows.Forms.NumericUpDown()
        Me.mainmenu.SuspendLayout()
        Me.pan_int_rate.SuspendLayout()
        CType(Me.int_arrears, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_auto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_consumer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_demand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_estate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_install, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_comm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_business, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_ibank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_bank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_bridge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.int_student, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mainmenu.TabIndex = 6
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
        'pan_int_rate
        '
        Me.pan_int_rate.AutoScroll = True
        Me.pan_int_rate.BackColor = System.Drawing.Color.Snow
        Me.pan_int_rate.Controls.Add(Me.Label3)
        Me.pan_int_rate.Controls.Add(Me.int_arrears)
        Me.pan_int_rate.Controls.Add(Me.Label2)
        Me.pan_int_rate.Controls.Add(Me.Label1)
        Me.pan_int_rate.Controls.Add(Me.i_update)
        Me.pan_int_rate.Controls.Add(Me.int_home)
        Me.pan_int_rate.Controls.Add(Me.i_edit)
        Me.pan_int_rate.Controls.Add(Me.int_auto)
        Me.pan_int_rate.Controls.Add(Me.int_consumer)
        Me.pan_int_rate.Controls.Add(Me.int_personal)
        Me.pan_int_rate.Controls.Add(Me.int_demand)
        Me.pan_int_rate.Controls.Add(Me.int_estate)
        Me.pan_int_rate.Controls.Add(Me.int_install)
        Me.pan_int_rate.Controls.Add(Me.int_comm)
        Me.pan_int_rate.Controls.Add(Me.int_business)
        Me.pan_int_rate.Controls.Add(Me.int_ibank)
        Me.pan_int_rate.Controls.Add(Me.int_bank)
        Me.pan_int_rate.Controls.Add(Me.int_bridge)
        Me.pan_int_rate.Controls.Add(Me.Label15)
        Me.pan_int_rate.Controls.Add(Me.Label12)
        Me.pan_int_rate.Controls.Add(Me.Label13)
        Me.pan_int_rate.Controls.Add(Me.Label14)
        Me.pan_int_rate.Controls.Add(Me.Label9)
        Me.pan_int_rate.Controls.Add(Me.Label10)
        Me.pan_int_rate.Controls.Add(Me.Label11)
        Me.pan_int_rate.Controls.Add(Me.Label6)
        Me.pan_int_rate.Controls.Add(Me.Label7)
        Me.pan_int_rate.Controls.Add(Me.Label8)
        Me.pan_int_rate.Controls.Add(Me.Label22)
        Me.pan_int_rate.Controls.Add(Me.Label23)
        Me.pan_int_rate.Controls.Add(Me.Label24)
        Me.pan_int_rate.Controls.Add(Me.r_gntr_contact)
        Me.pan_int_rate.Controls.Add(Me.Label5)
        Me.pan_int_rate.Controls.Add(Me.int_student)
        Me.pan_int_rate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_int_rate.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_int_rate.Location = New System.Drawing.Point(0, 25)
        Me.pan_int_rate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_int_rate.Name = "pan_int_rate"
        Me.pan_int_rate.Size = New System.Drawing.Size(929, 483)
        Me.pan_int_rate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(473, 635)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 24)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "***"
        '
        'int_arrears
        '
        Me.int_arrears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_arrears.DecimalPlaces = 2
        Me.int_arrears.Enabled = False
        Me.int_arrears.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_arrears.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_arrears.Location = New System.Drawing.Point(209, 763)
        Me.int_arrears.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_arrears.Name = "int_arrears"
        Me.int_arrears.Size = New System.Drawing.Size(222, 30)
        Me.int_arrears.TabIndex = 15
        Me.int_arrears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_arrears.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 764)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Arrears"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(859, 912)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Odini"
        Me.Label1.Visible = False
        '
        'i_update
        '
        Me.i_update.BackColor = System.Drawing.SystemColors.Control
        Me.i_update.Enabled = False
        Me.i_update.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.i_update.FlatAppearance.BorderSize = 2
        Me.i_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.i_update.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.i_update.Location = New System.Drawing.Point(316, 811)
        Me.i_update.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.i_update.Name = "i_update"
        Me.i_update.Size = New System.Drawing.Size(93, 29)
        Me.i_update.TabIndex = 0
        Me.i_update.TabStop = False
        Me.i_update.Text = "Update"
        Me.i_update.UseVisualStyleBackColor = False
        '
        'int_home
        '
        Me.int_home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_home.DecimalPlaces = 2
        Me.int_home.Enabled = False
        Me.int_home.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_home.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_home.Location = New System.Drawing.Point(212, 97)
        Me.int_home.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_home.Name = "int_home"
        Me.int_home.Size = New System.Drawing.Size(222, 30)
        Me.int_home.TabIndex = 2
        Me.int_home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_home.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'i_edit
        '
        Me.i_edit.BackColor = System.Drawing.Color.SteelBlue
        Me.i_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.i_edit.FlatAppearance.BorderSize = 2
        Me.i_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.i_edit.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i_edit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.i_edit.Location = New System.Drawing.Point(209, 811)
        Me.i_edit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.i_edit.Name = "i_edit"
        Me.i_edit.Size = New System.Drawing.Size(93, 29)
        Me.i_edit.TabIndex = 1
        Me.i_edit.Text = "Edit"
        Me.i_edit.UseVisualStyleBackColor = False
        '
        'int_auto
        '
        Me.int_auto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_auto.DecimalPlaces = 2
        Me.int_auto.Enabled = False
        Me.int_auto.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_auto.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_auto.Location = New System.Drawing.Point(212, 658)
        Me.int_auto.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_auto.Name = "int_auto"
        Me.int_auto.Size = New System.Drawing.Size(222, 30)
        Me.int_auto.TabIndex = 13
        Me.int_auto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_auto.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_consumer
        '
        Me.int_consumer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_consumer.DecimalPlaces = 2
        Me.int_consumer.Enabled = False
        Me.int_consumer.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_consumer.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_consumer.Location = New System.Drawing.Point(212, 607)
        Me.int_consumer.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_consumer.Name = "int_consumer"
        Me.int_consumer.Size = New System.Drawing.Size(222, 30)
        Me.int_consumer.TabIndex = 12
        Me.int_consumer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_consumer.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_personal
        '
        Me.int_personal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_personal.DecimalPlaces = 2
        Me.int_personal.Enabled = False
        Me.int_personal.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_personal.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_personal.Location = New System.Drawing.Point(212, 554)
        Me.int_personal.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_personal.Name = "int_personal"
        Me.int_personal.Size = New System.Drawing.Size(222, 30)
        Me.int_personal.TabIndex = 11
        Me.int_personal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_personal.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_demand
        '
        Me.int_demand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_demand.DecimalPlaces = 2
        Me.int_demand.Enabled = False
        Me.int_demand.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_demand.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_demand.Location = New System.Drawing.Point(212, 505)
        Me.int_demand.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_demand.Name = "int_demand"
        Me.int_demand.Size = New System.Drawing.Size(222, 30)
        Me.int_demand.TabIndex = 10
        Me.int_demand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_demand.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_estate
        '
        Me.int_estate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_estate.DecimalPlaces = 2
        Me.int_estate.Enabled = False
        Me.int_estate.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_estate.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_estate.Location = New System.Drawing.Point(212, 709)
        Me.int_estate.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_estate.Name = "int_estate"
        Me.int_estate.Size = New System.Drawing.Size(222, 30)
        Me.int_estate.TabIndex = 14
        Me.int_estate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_estate.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_install
        '
        Me.int_install.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_install.DecimalPlaces = 2
        Me.int_install.Enabled = False
        Me.int_install.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_install.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_install.Location = New System.Drawing.Point(212, 454)
        Me.int_install.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_install.Name = "int_install"
        Me.int_install.Size = New System.Drawing.Size(222, 30)
        Me.int_install.TabIndex = 9
        Me.int_install.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_install.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_comm
        '
        Me.int_comm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_comm.DecimalPlaces = 2
        Me.int_comm.Enabled = False
        Me.int_comm.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_comm.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_comm.Location = New System.Drawing.Point(212, 403)
        Me.int_comm.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_comm.Name = "int_comm"
        Me.int_comm.Size = New System.Drawing.Size(222, 30)
        Me.int_comm.TabIndex = 8
        Me.int_comm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_comm.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_business
        '
        Me.int_business.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_business.DecimalPlaces = 2
        Me.int_business.Enabled = False
        Me.int_business.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_business.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_business.Location = New System.Drawing.Point(212, 352)
        Me.int_business.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_business.Name = "int_business"
        Me.int_business.Size = New System.Drawing.Size(222, 30)
        Me.int_business.TabIndex = 7
        Me.int_business.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_business.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_ibank
        '
        Me.int_ibank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_ibank.DecimalPlaces = 2
        Me.int_ibank.Enabled = False
        Me.int_ibank.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_ibank.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_ibank.Location = New System.Drawing.Point(212, 301)
        Me.int_ibank.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_ibank.Name = "int_ibank"
        Me.int_ibank.Size = New System.Drawing.Size(222, 30)
        Me.int_ibank.TabIndex = 6
        Me.int_ibank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_ibank.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_bank
        '
        Me.int_bank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_bank.DecimalPlaces = 2
        Me.int_bank.Enabled = False
        Me.int_bank.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_bank.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_bank.Location = New System.Drawing.Point(212, 250)
        Me.int_bank.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_bank.Name = "int_bank"
        Me.int_bank.Size = New System.Drawing.Size(222, 30)
        Me.int_bank.TabIndex = 5
        Me.int_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_bank.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'int_bridge
        '
        Me.int_bridge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_bridge.DecimalPlaces = 2
        Me.int_bridge.Enabled = False
        Me.int_bridge.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_bridge.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_bridge.Location = New System.Drawing.Point(212, 199)
        Me.int_bridge.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_bridge.Name = "int_bridge"
        Me.int_bridge.Size = New System.Drawing.Size(222, 30)
        Me.int_bridge.TabIndex = 4
        Me.int_bridge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_bridge.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(16, 710)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 24)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Real  Estate Loan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(16, 659)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Automobile Loan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(16, 608)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Consumer Loan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(16, 557)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Personal Loan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 506)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Demand Loan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(16, 455)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Installation Loan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(16, 404)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Commercial Loan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 353)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Business Loan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 302)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Inter Bank Loan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 251)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Bank Loan"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(16, 200)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 24)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Bridge Loan"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(16, 149)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 24)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Student Loan"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(16, 98)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 24)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Home Loan"
        '
        'r_gntr_contact
        '
        Me.r_gntr_contact.AutoSize = True
        Me.r_gntr_contact.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_gntr_contact.ForeColor = System.Drawing.SystemColors.ControlText
        Me.r_gntr_contact.Location = New System.Drawing.Point(205, 855)
        Me.r_gntr_contact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.r_gntr_contact.Name = "r_gntr_contact"
        Me.r_gntr_contact.Size = New System.Drawing.Size(40, 24)
        Me.r_gntr_contact.TabIndex = 0
        Me.r_gntr_contact.Text = "***"
        Me.r_gntr_contact.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(7, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 49)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Interest  Rates"
        '
        'int_student
        '
        Me.int_student.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.int_student.DecimalPlaces = 2
        Me.int_student.Enabled = False
        Me.int_student.Font = New System.Drawing.Font("Calibri Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int_student.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.int_student.Location = New System.Drawing.Point(212, 148)
        Me.int_student.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.int_student.Name = "int_student"
        Me.int_student.Size = New System.Drawing.Size(222, 30)
        Me.int_student.TabIndex = 3
        Me.int_student.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.int_student.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'managerates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(929, 508)
        Me.Controls.Add(Me.pan_int_rate)
        Me.Controls.Add(Me.mainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "managerates"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Loan Management System - Manage Interest Rates"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainmenu.ResumeLayout(False)
        Me.mainmenu.PerformLayout()
        Me.pan_int_rate.ResumeLayout(False)
        Me.pan_int_rate.PerformLayout()
        CType(Me.int_arrears, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_auto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_consumer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_demand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_estate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_install, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_comm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_business, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_ibank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_bank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_bridge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.int_student, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pan_int_rate As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents i_update As System.Windows.Forms.Button
    Friend WithEvents int_home As System.Windows.Forms.NumericUpDown
    Friend WithEvents i_edit As System.Windows.Forms.Button
    Friend WithEvents int_auto As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_consumer As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_personal As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_demand As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_estate As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_install As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_comm As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_business As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_ibank As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_bank As System.Windows.Forms.NumericUpDown
    Friend WithEvents int_bridge As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents r_gntr_contact As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents int_student As System.Windows.Forms.NumericUpDown
    Friend WithEvents mnu_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents int_arrears As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
