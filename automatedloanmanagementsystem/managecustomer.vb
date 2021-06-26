Public Class managecustomer
    'role of the user based on permission granted
    Public role As String
    'user at moment
    Public almsuser As String
    
    Private Sub managecustomer_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        homeform.f_mngcus = False
        close_all()
    End Sub

    Private Sub managecustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        homeform.f_mngcus = True
        effect_Permission()
        draw_listview()
        add_cus_id()
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

    Private Sub mnu_iss_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_iss_loan.Click
        issueloan.role = role
        issueloan.Show()
        Me.hide()
    End Sub

    Private Sub mnu_pay_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_pay_loan.Click
        loanpay.role = role
        loanpay.Show()
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
            Me.Close()
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
            issueloan.Close()
        End If
        If homeform.f_addcus = True Then
            addcustomer.Close()
        End If
    End Sub

    Private Sub draw_listview()
        'PROTOTYPE
        'adding the items and the subitems
        Dim list As New ListViewItem("nah")
        'list.Items.Add("nah")
        list.SubItems.Add("bla")
        list.SubItems.Add("blabla")
        list.SubItems.Add("blablabla")
        list.SubItems.Add("blablablabla")
        list.SubItems.Add("blablablablabla")
        c_result.Items.AddRange(New ListViewItem() {list})
    End Sub

    'adding the values of a combo box
    Private Sub add_cus_id()
        cus_mng_pick.Items.Clear()
        cus_mng_pick.Items.Add("Customer001")
        cus_mng_pick.Items.Add("Customer002")
        cus_mng_pick.Items.Add("Customer003")
    End Sub

    Dim err As Boolean
    Private Sub cus_mng_pick_Leave(sender As System.Object, e As System.EventArgs) Handles cus_mng_pick.Leave
        'validate presence
        If Trim(cus_mng_pick.Text) = "" Then
            Err = True
            cus_mng_pick.Text = "Empty!!!"
        End If
    End Sub

    Private Sub c_mng_accno_Leave(sender As System.Object, e As System.EventArgs) Handles c_mng_accno.Leave
        'validate presence
        If Trim(c_mng_accno.Text) = "" Then
            err = True
            c_mng_accno.Text = "Empty!!!"
        End If
        'validate type
        If Not c_mng_accno.Text.Contains("0") And Not c_mng_accno.Text.Contains("1") And Not c_mng_accno.Text.Contains("2") And Not c_mng_accno.Text.Contains("3") And Not c_mng_accno.Text.Contains("4") _
        And Not c_mng_accno.Text.Contains("5") And Not c_mng_accno.Text.Contains("6") And Not c_mng_accno.Text.Contains("7") And Not c_mng_accno.Text.Contains("8") And Not c_mng_accno.Text.Contains("9") Then
            c_mng_accno.Text = "Error!!!"
        End If
    End Sub

    Private Sub c_mng_tel_Leave(sender As System.Object, e As System.EventArgs) Handles c_mng_tel.Leave
        'validate presence
        If Trim(c_mng_tel.Text) = "" Then
            err = True
            c_mng_tel.Text = "Empty!!!"
        End If
        'validate type
        If Not c_mng_tel.Text.Contains("0") And Not c_mng_tel.Text.Contains("1") And Not c_mng_tel.Text.Contains("2") And Not c_mng_tel.Text.Contains("3") And Not c_mng_tel.Text.Contains("4") _
        And Not c_mng_tel.Text.Contains("5") And Not c_mng_tel.Text.Contains("6") And Not c_mng_tel.Text.Contains("7") And Not c_mng_tel.Text.Contains("8") And Not c_mng_tel.Text.Contains("9") Then
            c_mng_tel.Text = "Error!!!"
        End If
        'validate length
        If c_mng_tel.Text.Length < 11 Then
            c_mng_tel.Text = "Error!!!"
        End If
    End Sub

    Private Sub c_mng_email_Leave(sender As System.Object, e As System.EventArgs) Handles c_mng_email.Leave
        'validate presence
        If Trim(c_mng_email.Text) = "" Then
            err = True
            c_mng_email.Text = "Empty!!!"
        End If
        'validate type
        If Not c_mng_email.Text.Contains("@") And Not c_mng_email.Text.Contains(".com") And Not c_mng_email.Text.Contains(".net") And Not c_mng_email.Text.Contains(".andg") And Not c_mng_email.Text.Contains("biz") Then
            c_mng_email.Text = "Error!!!"
        End If
        If c_mng_email.Text.IndexOf("@") > c_mng_email.Text.IndexOf(".com") And c_mng_email.Text.IndexOf("@") > c_mng_email.Text.IndexOf(".net") And c_mng_email.Text.IndexOf("@") > c_mng_email.Text.IndexOf(".andg") _
        And c_mng_email.Text.IndexOf("@") > c_mng_email.Text.IndexOf(".biz") Then
            c_mng_email.Text = c_mng_email.Text.IndexOf("@").ToString + " " + c_mng_email.Text.IndexOf(".com").ToString + "Error!!!"
        End If
    End Sub

    Private Sub c_mng_address_Leave(sender As System.Object, e As System.EventArgs) Handles c_mng_address.Leave
        If Trim(c_mng_address.Text) = "" Then
            err = True
            c_mng_address.Text = "Empty!!!"
        End If
    End Sub

    Dim cid As Integer
    Private Sub cus_mng_pick_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cus_mng_pick.SelectedIndexChanged
        cus_id.Text = cid
    End Sub

    Private Sub c_mng_update_Click(sender As System.Object, e As System.EventArgs) Handles c_mng_update.Click
        'saves to the database
        If err = False Then
            'add to database
        Else
            'return error message
        End If
    End Sub
End Class