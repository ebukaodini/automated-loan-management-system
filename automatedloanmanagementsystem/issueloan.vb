Public Class issueloan
    'role of the user based on permission granted
    Public role As String
    'user at moment
    Public almsuser As String

    Private Sub issueloan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        homeform.f_issloan = True
        effect_Permission()
        add_cus_id()
        add_loan_type()
    End Sub

    Private Sub issueloan_FormClosed(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        homeform.f_issloan = False
        close_all()
    End Sub

    'Navigation Links to other pages on permission
    Private Sub mnu_add_customer_Click(sender As System.Object, e As System.EventArgs) Handles mnu_add_customer.Click
        addcustomer.role = role
        addcustomer.Show()
        Me.hide()
    End Sub

    Private Sub mnu_home_Click(sender As System.Object, e As System.EventArgs) Handles mnu_home.Click
        homeform.role = role
        homeform.Show()
        Me.Hide()
    End Sub

    Private Sub mnu_pay_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_pay_loan.Click
        loanpay.role = role
        loanpay.Show()
        Me.Hide()
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
        If homeform.f_homeform = True Then
            homeform.Close()
        End If
        If homeform.f_mngcus = True Then
            managecustomer.Close()
        End If
        If homeform.f_mnguser = True Then
            manageusers.Close()
        End If
        If homeform.f_mngloan = True Then
            manageloan.Close()
        End If
        If homeform.f_mngrate = True Then
            managerates.Close()
        End If
        If homeform.f_loanpay = True Then
            loanpay.Close()
        End If
        If homeform.f_issloan = True Then
            Me.Close()
        End If
        If homeform.f_addcus = True Then
            addcustomer.Close()
        End If
    End Sub

    'adding the values of a combo box
    Private Sub add_cus_id()
        g_cus_pick.Items.Clear()
        g_cus_pick.Items.Add("Customer001")
        g_cus_pick.Items.Add("Customer002")
        g_cus_pick.Items.Add("Customer003")
    End Sub

    Private Sub add_loan_type()
        l_type.Items.Clear()
        l_type.Items.Add("Home Loan")
        l_type.Items.Add("Student Loan")
        l_type.Items.Add("Bridge Loan")
        l_type.Items.Add("Bank Loan")
        l_type.Items.Add("Inter-Bank Loan")
        l_type.Items.Add("Business Loan")
        l_type.Items.Add("Commercial Loan")
        l_type.Items.Add("Installation Loan")
        l_type.Items.Add("Demand Loan")
        l_type.Items.Add("Personal Loan")
        l_type.Items.Add("Consumer Loan")
        l_type.Items.Add("Automobile Loan")
        l_type.Items.Add("Real-Estate Loan")
    End Sub

    Dim g_err As Boolean
    Dim s_err As Boolean
    Dim gname As String
    Dim gtel As String
    Dim gemail As String
    Dim gaddress As String

    Dim sname As String
    Dim sval As String
    Dim sdetail As String

    Dim gid As Integer
    Dim sid As Integer
    Dim cid As Integer

    Dim l_err As Boolean
    Dim lname As String
    Dim ltype As String
    Dim intr As Decimal
    Dim amt As Decimal
    Dim ltenure As Integer
    Dim linst As Integer
    Dim liss As String
    Dim lexp As String
    Dim lrep As String
    Dim lintr As Decimal
    Dim lcost As Decimal
    Dim lemi As Decimal
    Dim lemino As Integer
    Dim lissuer As String

    Private Sub g_cus_pick_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles g_cus_pick.SelectedIndexChanged
        'update id
        cus_id.Text = cid
        lbl_cus_name.Text = g_cus_pick.Text
    End Sub

    Private Sub g_cus_pick_TextChanged(sender As System.Object, e As System.EventArgs) Handles g_cus_pick.TextChanged
        'update id
        cus_id.Text = cid
        lbl_cus_name.Text = g_cus_pick.Text
    End Sub

    Private Sub g_name_Leave(sender As System.Object, e As System.EventArgs) Handles g_name.Leave
        'validate presence
        If Trim(g_name.Text) = "" Then
            g_err = True
            g_name.Text = "Empty!!!"
        End If
    End Sub

    Private Sub g_tel_Leave(sender As System.Object, e As System.EventArgs) Handles g_tel.Leave
        'validate presence
        If Trim(g_tel.Text) = "" Then
            g_err = True
            g_tel.Text = "Empty!!!"
        End If
        'validate type
        If Not g_tel.Text.Contains("0") And Not g_tel.Text.Contains("1") And Not g_tel.Text.Contains("2") And Not g_tel.Text.Contains("3") And Not g_tel.Text.Contains("4") _
        And Not g_tel.Text.Contains("5") And Not g_tel.Text.Contains("6") And Not g_tel.Text.Contains("7") And Not g_tel.Text.Contains("8") And Not g_tel.Text.Contains("9") Then
            g_tel.Text = "Error!!!"
        End If
        'validate length
        If g_tel.Text.Length < 11 Then
            g_tel.Text = "Error!!!"
        End If
    End Sub

    Private Sub g_email_Leave(sender As System.Object, e As System.EventArgs) Handles g_email.Leave
        'validate presence
        If Trim(g_email.Text) = "" Then
            g_err = True
            g_email.Text = "Empty!!!"
        End If
        'validate type
        If Not g_email.Text.Contains("@") And Not g_email.Text.Contains(".com") And Not g_email.Text.Contains(".net") And Not g_email.Text.Contains(".andg") And Not g_email.Text.Contains("biz") Then
            g_email.Text = "Error!!!"
        End If
        If g_email.Text.IndexOf("@") > g_email.Text.IndexOf(".com") And g_email.Text.IndexOf("@") > g_email.Text.IndexOf(".net") And g_email.Text.IndexOf("@") > g_email.Text.IndexOf(".andg") _
        And g_email.Text.IndexOf("@") > g_email.Text.IndexOf(".biz") Then
            g_email.Text = g_email.Text.IndexOf("@").ToString + " " + g_email.Text.IndexOf(".com").ToString + "Error!!!"
        End If
    End Sub

    Private Sub g_address_Leave(sender As System.Object, e As System.EventArgs) Handles g_address.Leave
        'validate presence
        If Trim(g_address.Text) = "" Then
            g_err = True
            g_address.Text = "Empty!!!"
        End If
    End Sub

    Private Sub s_name_Leave(sender As System.Object, e As System.EventArgs) Handles s_name.Leave
        'validate presence
        If Trim(s_name.Text) = "" Then
            s_err = True
            s_name.Text = "Empty!!!"
        End If
    End Sub

    Private Sub s_val_Leave(sender As System.Object, e As System.EventArgs) Handles s_val.Leave
        'validate presence
        If Trim(s_val.Text) = "" Then
            s_err = True
            s_val.Text = "Empty!!!"
        End If
    End Sub

    Private Sub s_detail_Leave(sender As System.Object, e As System.EventArgs) Handles s_detail.Leave
        'validate presence
        If Trim(s_detail.Text) = "" Then
            s_err = True
            s_detail.Text = "Empty!!!"
        End If
    End Sub

    Private Sub btn_add_gua_Click(sender As System.Object, e As System.EventArgs) Handles btn_add_gua.Click
        If g_err = False Then
            gname = g_name.Text
            gtel = g_tel.Text
            gemail = g_email.Text
            gaddress = g_address.Text
            gua_id.Text = gid
            'add to database
        Else
            'return error message
        End If
    End Sub

    Private Sub btn_add_sec_Click(sender As System.Object, e As System.EventArgs) Handles btn_add_sec.Click
        If s_err = False Then

            Dim sname = s_name.Text
            Dim sval = s_val.Text
            Dim gdetail = s_detail.Text
            sec_id.Text = sid
            'add to database
        Else
            'return error message
        End If
    End Sub


    Private Sub l_name_Leave(sender As System.Object, e As System.EventArgs) Handles l_name.Leave
        'validate presence
        If Trim(g_tel.Text) = "" Then
            g_err = True
            g_tel.Text = "Empty!!!"
        End If
        'validate type
    End Sub

    Private Sub l_type_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l_type.SelectedIndexChanged
        'get interest rate from database
        Dim rate As Decimal = 3.5
        l_intr.Text = rate
    End Sub

    Private Sub l_amount_Leave(sender As System.Object, e As System.EventArgs) Handles l_amount.Leave
        'validate presence
        If Trim(l_amount.Text) = "" Then
            l_err = True
            l_amount.Text = "Empty!!!"
        End If
    End Sub

    Private Sub l_tenure_Leave(sender As System.Object, e As System.EventArgs) Handles l_tenure.Leave
        'validate presence
        If Trim(l_tenure.Text) = "" Then
            l_err = True
            l_tenure.Text = "Empty!!!"
        End If
    End Sub

    Private Sub l_issued_ValueChanged(sender As System.Object, e As System.EventArgs) Handles l_issued.ValueChanged
        liss = l_issued.Text
    End Sub

    Private Sub l_expire_ValueChanged(sender As System.Object, e As System.EventArgs) Handles l_expire.ValueChanged
        lexp = l_expire.Text
    End Sub

    Private Sub l_repay_ValueChanged(sender As System.Object, e As System.EventArgs) Handles l_repay.ValueChanged
        lrep = l_repay.Text
    End Sub

    Private Sub btn_issue_Click(sender As System.Object, e As System.EventArgs) Handles btn_issue.Click
        If l_err = False Then
            'lname = l_name.Text
            'ltype = l_type.Text
            'intr = l_intr.Text
            'amt = l_amount.Text
            'ltenure = l_tenure.Text
            'liss = l_issued.Text
            'lexp = l_expire.Text
            'lrep = l_repay.Text
            'lintr = l_interest.Text
            'lcost = l_cost.Text
            'lemi = l_emi.Text
            'lemino = l_emi_no.Text
            'lissuer = user.Text
            'linst = l_no_inst.Text
            'gid()
            'sid()
            'cid()
            'add to database
        Else
            'return error message
        End If
    End Sub

    Private Sub calc_mng_emi()
        lemi = CDec((l_amount.Text * l_intr.Text / 1200.0 * (1 + l_intr.Text / 1200.0) ^ (l_no_inst.Text * l_tenure.Text)) / _
            ((1 + l_intr.Text / 1200.0) ^ (l_no_inst.Text * l_tenure.Text) - 1.0))
        lemino = l_no_inst.Text * l_tenure.Text
        lcost = CDec(l_no_inst.Text * l_tenure.Text * lemi)
        lintr = CDec(lcost - l_amount.Text)

        'converting to 2 decimal places
        lemi = Decimal.Round(lemi, 2)
        lcost = Decimal.Round(lcost, 2)
        lintr = Decimal.Round(lintr, 2)
        lname = l_name.Text
        ltype = l_type.Text
        intr = l_intr.Text
        amt = l_amount.Text
        ltenure = l_tenure.Text
        liss = l_issued.Text
        lexp = l_expire.Text
        lrep = l_repay.Text
        lissuer = almsuser
        linst = l_no_inst.Text

        'returning values to page
        l_emi.Text = lemi
        l_emi_no.Text = lemino
        l_cost.Text = lcost
        l_interest.Text = lintr
        user.Text = lissuer
    End Sub

    Private Sub calc_mng_Click(sender As System.Object, e As System.EventArgs) Handles calc.Click
        calc_mng_emi()
    End Sub
End Class