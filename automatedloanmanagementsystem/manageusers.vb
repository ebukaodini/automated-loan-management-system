Public Class manageusers
    'role of the user based on permission granted
    Public role As String
    'user at moment
    Public almsuser As String

    Private Sub manageusers_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        homeform.f_mnguser = False
        close_all()
    End Sub

    Private Sub manageusers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        homeform.f_mnguser = True
        effect_Permission()
        add_user()
        draw_listview()
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

    Private Sub mnu_pay_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_pay_loan.Click
        loanpay.role = role
        loanpay.Show()
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
            Me.Close()
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

    Dim err As Boolean
    Dim _role As String
    Dim pword As String
    Dim barred As String
    Dim _user As String

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
        u_result.Items.AddRange(New ListViewItem() {list})
    End Sub

    'adding the values of a combo box
    Private Sub add_user()
        u_uname.Items.Clear()
        u_uname.Items.Add("User001")
        u_uname.Items.Add("User002")
        u_uname.Items.Add("User003")
    End Sub

    Private Sub u_mng_update_Click(sender As System.Object, e As System.EventArgs) Handles u_mng_update.Click
        'saves to the database
        If err = False Then
            'barred = u_bar.Text
            'pword = u_pword.Text
            '_user = u_uname.Text
            '_role = u_role.Text
            'add to database
        Else
            'return error message
        End If
    End Sub
End Class