Public Class managerates
    'role of the user based on permission granted 
    Public role As String
    'user at moment
    Public almsuser As String

    Private Sub managerates_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        homeform.f_mngrate = False
        close_all()
    End Sub

    Private Sub managerates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        homeform.f_mngrate = True
        effect_Permission()
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

    Private Sub mnu_mng_users_Click(sender As System.Object, e As System.EventArgs) Handles mnu_mng_users.Click
        manageusers.role = role
        manageusers.Show()
        Me.hide()
    End Sub

    Private Sub mnu_pay_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_pay_loan.Click
        loanpay.role = role
        loanpay.Show()
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
            Me.Close()
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

    Private Sub i_edit_Click(sender As System.Object, e As System.EventArgs) Handles i_edit.Click
        int_home.Enabled = True
        int_student.Enabled = True
        int_bridge.Enabled = True
        int_bank.Enabled = True
        int_ibank.Enabled = True
        int_business.Enabled = True
        int_comm.Enabled = True
        int_install.Enabled = True
        int_demand.Enabled = True
        int_personal.Enabled = True
        int_consumer.Enabled = True
        int_auto.Enabled = True
        int_estate.Enabled = True
        int_arrears.Enabled = True
        i_update.Enabled = True
    End Sub

    Dim intr_home As Double
    Dim intr_student As Double
    Dim intr_bridge As Double
    Dim intr_bank As Double
    Dim intr_ibank As Double
    Dim intr_business As Double
    Dim intr_comm As Double
    Dim intr_install As Double
    Dim intr_demand As Double
    Dim intr_personal As Double
    Dim intr_consumer As Double
    Dim intr_auto As Double
    Dim intr_estate As Double
    Dim intr_arrears As Double

    Private Sub i_update_Click(sender As System.Object, e As System.EventArgs) Handles i_update.Click
        intr_home = intr_home = intr_home = int_home.Text
        intr_student = int_student.Text
        intr_bridge = int_bridge.Text
        intr_bank = int_bank.Text
        intr_ibank = int_ibank.Text
        intr_business = int_business.Text
        intr_comm = int_comm.Text
        intr_install = int_install.Text
        intr_demand = int_demand.Text
        intr_personal = int_personal.Text
        intr_consumer = int_consumer.Text
        intr_auto = int_auto.Text
        intr_estate = int_estate.Text
        intr_arrears = int_arrears.Text
        'update them
    End Sub


End Class