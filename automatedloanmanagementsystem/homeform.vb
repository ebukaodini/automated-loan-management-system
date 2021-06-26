
Public Class homeform
    Private m_cn As New SqlConnection()
    Private m_da As SqlDataAdapter
    Private m_cb As SqlCommandBuilder
    Private m_datatable As New DataTable
    Private m_rowposition As Integer = 0

    'role of the user based on permission granted
    Public role As String = "administrator" 'assumed role
    'user at moment
    Public almsuser As String
    'to hold values of the pages open
    Public f_homeform As New Boolean
    Public f_mngcus As New Boolean
    Public f_mnguser As New Boolean
    Public f_mngloan As New Boolean
    Public f_mngrate As New Boolean
    Public f_loanpay As New Boolean
    Public f_issloan As New Boolean
    Public f_addcus As New Boolean

    Private Sub homeform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'm_cn.ConnectionString = "Data Source =. \SQLEXPRESS; AttachDbFilename = C:\Program Files\Microsoft SQL Server\MSSQL10_50.EBUKA\MSSQL\Template Data\master.mdf; Integrated Security= True; Connect Timeout = 30" '; User Instance= True"
        'm_cn.Open()
        'm_da = New SqlDataAdapter("Select * From loans", m_cn)
        'm_cb = New SqlCommandBuilder(m_da)
        'm_da.Fill(m_datatable)
        Me.f_homeform = True
        effect_Permission()
    End Sub

    Private Sub homeform_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        m_cn.Close()
        m_cn.Dispose()
        Me.f_homeform = False
        close_all()
    End Sub

    'Navigation Links to other pages on permission
    Private Sub mnu_add_customer_Click(sender As System.Object, e As System.EventArgs) Handles mnu_add_customer.Click
        addcustomer.role = role
        addcustomer.Show()
        Me.hide()
    End Sub

    Private Sub mnu_pay_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_pay_loan.Click
        loanpay.role = role
        loanpay.Show()
        Me.Hide()
    End Sub

    Private Sub mnu_iss_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_iss_loan.Click
        issueloan.role = role
        issueloan.Show()
        Me.hide()
    End Sub

    Private Sub mnu_mng_customer_Click(sender As System.Object, e As System.EventArgs) Handles mnu_mng_customer.Click
        managecustomer.role = role
        managecustomer.Show()
        Me.hide()
    End Sub

    Private Sub mnu_mng_loans_Click(sender As System.Object, e As System.EventArgs) Handles mnu_mng_loans.Click
        manageloan.role = role
        manageloan.Show()
        Me.hide()
    End Sub

    Private Sub mnu_mng_users_Click(sender As System.Object, e As System.EventArgs) Handles mnu_mng_users.Click
        manageusers.role = role
        manageusers.Show()
        Me.hide()
    End Sub

    Private Sub mnu_mng_rates_Click(sender As System.Object, e As System.EventArgs) Handles mnu_mng_rates.Click
        managerates.role = role
        managerates.Show()
        Me.hide()
    End Sub

    Private Sub mnu_logout_Click(sender As System.Object, e As System.EventArgs) Handles mnu_logout.Click
        ALMSlogin.Show()
        Me.Hide()
    End Sub

    Private Sub mnu_about_Click(sender As System.Object, e As System.EventArgs) Handles mnu_about.Click
        about.ShowDialog()
    End Sub

    Private Sub mnu_exit_Click(sender As System.Object, e As System.EventArgs) Handles mnu_exit.Click
        Me.Close()
    End Sub

   Private Sub effect_Permission()
        If role = "cashier" Then
            'mnu_add_customer
            Me.mnu_add_customer.Visible = False
            'mnu_iss_loan
            Me.mnu_iss_loan.Visible = False
            'mnu_mng_customer
            Me.mnu_mng_customer.Visible = False
            'mnu_mng_loans
            Me.mnu_mng_loans.Visible = False
            'mnu_mng_users
            Me.mnu_mng_users.Visible = False
            'mnu_mng_rates
            Me.mnu_mng_rates.Visible = False
        ElseIf role = "supervisor" Then
            'mnu_mng_users
            Me.mnu_mng_users.Visible = False
            'mnu_mng_rates
            Me.mnu_mng_rates.Visible = False
        ElseIf role = "administrator" Then
        End If
    End Sub

    Private Sub close_all()
        If Me.f_homeform = True Then
            Me.Close()
        End If
        If Me.f_mngcus = True Then
            managecustomer.Close()
        End If
        If Me.f_mnguser = True Then
            manageusers.Close()
        End If
        If Me.f_mngloan = True Then
            manageloan.Close()
        End If
        If Me.f_mngrate = True Then
            managerates.Close()
        End If
        If Me.f_loanpay = True Then
            loanpay.Close()
        End If
        If Me.f_issloan = True Then
            issueloan.Close()
        End If
        If Me.f_addcus = True Then
            addcustomer.Close()
        End If
        ALMSlogin.Show()
    End Sub

    Dim filter As String
    Dim txt As String
    Private Sub draw_column(filter, txt)
        '' All that is needed to draw out the listview
        'adding the columns with q_result as name of listview
        'Me.q_result.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.cus_address, Me.contact, Me.email, Me.acc_mng_no})

        'necessary edit for column properties
        'email
        '
        'Me.email.Text = "E-mail"
        'Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        'Me.email.Width = 150
        '
        'PROTOTYPE
        'adding the items and the subitems
        'Dim list As New ListViewItem("nah")
        ''list.Items.Add("nah")
        'list.SubItems.Add("bla")
        'list.SubItems.Add("blabla")
        'list.SubItems.Add("blablabla")
        'list.SubItems.Add("blablablabla")
        'list.SubItems.Add("blablablablabla")
        'q_result.Items.AddRange(New ListViewItem() {list})

        ''trial
        q_result.Items.Clear()
        If txt = "" Then ' this deals with query on diff categories
            If filter = "Customer" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("Customer")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
            If filter = "Loans" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("Loans")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
            If filter = "Payments" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("Payments")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
            If filter = "Interest Rates" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("Interest Rates")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
            If filter = "EMI" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("EMI")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
            If filter = "Guarantor" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("Guarantor")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
            If filter = "Security" Then
                Dim list As New ListViewItem("nah")
                list.SubItems.Add("Security")
                q_result.Items.AddRange(New ListViewItem() {list})
            End If
        Else ' this deals with inouted text queries
            Dim list As New ListViewItem(filter.ToString)
            list.SubItems.Add(txt)
            q_result.Items.AddRange(New ListViewItem() {list})
        End If
    End Sub

    Private Sub q_go_Click(sender As System.Object, e As System.EventArgs) Handles q_go.Click
        If q_filter.Text = "Customer" Then
            draw_column("Customer", q_search.Text)
        End If
        If q_filter.Text = "Loans" Then
            draw_column("Loans", q_search.Text)
        End If
        If q_filter.Text = "Payments" Then
            draw_column("Payments", q_search.Text)
        End If
        If q_filter.Text = "Interest Rates" Then
            draw_column("Interest Rates", q_search.Text)
        End If
        If q_filter.Text = "EMI" Then
            draw_column("EMI", q_search.Text)
        End If
        If q_filter.Text = "Guarantor" Then
            draw_column("Guarantor", q_search.Text)
        End If
        If q_filter.Text = "Security" Then
            draw_column("Security", q_search.Text)
        End If

    End Sub
End Class