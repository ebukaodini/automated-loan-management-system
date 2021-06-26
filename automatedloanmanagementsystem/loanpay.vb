Public Class loanpay
    'role of the user based on permission granted
    Public role As String
    'user at moment
    Public almsuser As String
    
    Private Sub loanpay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        homeform.f_loanpay = True
        effect_Permission()
        p_receiver.Text = almsuser
        add_loan_id()
    End Sub

    Private Sub loanpay_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        homeform.f_loanpay = False
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
            Me.Close()
        End If
        If homeform.f_issloan = True Then
            issueloan.Close()
        End If
        If homeform.f_addcus = True Then
            addcustomer.Close()
        End If
    End Sub

    'adding the values of a combo box
    Private Sub add_loan_id()
        p_l_id.Items.Clear()
        Dim txt As String = "Loan001"
        p_l_id.Items.Add(txt)
    End Sub

    Private Sub add_emi_id()
        p_emi_id.Items.Clear()
        Dim txt As String
        txt = "EMI001"
        p_emi_id.Items.Add(txt)
    End Sub

    Private Sub p_l_id_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles p_l_id.SelectedIndexChanged
        add_emi_id()
    End Sub

    Dim due As Decimal
    Dim xtra As Decimal
    Dim cost As Decimal
    Dim paid As Decimal
    Dim bal As Decimal

    Private Sub p_emi_id_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles p_emi_id.SelectedIndexChanged
        'draw out the amountdue, xtra charge and total cost on the labels
        p_amt_due.Text = due
        p_xtra.Text = xtra
        p_total_cost.Text = cost
    End Sub

    Private Sub p_amt_paid_ValueChanged(sender As System.Object, e As System.EventArgs) Handles p_amt_paid.ValueChanged
        'do the subtraction and get the balance
        paid = p_amt_paid.Text
        bal = cost - paid
        p_bal.Text = bal
    End Sub

    Private Sub p_amt_paid_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles p_amt_paid.KeyUp
        'do the subtraction and get the balance
        paid = p_amt_paid.Text
        bal = cost - paid
        p_bal.Text = bal
    End Sub

    Private Sub p_btn_pay_Click(sender As System.Object, e As System.EventArgs) Handles p_btn_pay.Click
        'saves back to the database with the details required
    End Sub

End Class