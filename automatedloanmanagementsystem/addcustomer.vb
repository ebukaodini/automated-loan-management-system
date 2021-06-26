Public Class addcustomer
    'role of the user based on permission granted
    Public role As String
    'user at moment
    Public almsuser As String
    
    Private Sub addcustomer_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        homeform.f_addcus = False
        close_all()
    End Sub

    Private Sub addcustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        homeform.f_addcus = True
        effect_Permission()
    End Sub

    'Navigation Links to other pages on permission
    Private Sub mnu_pay_loan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_pay_loan.Click
        loanpay.role = role
        loanpay.Show()
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
            loanpay.Close()
        End If
        If homeform.f_issloan = True Then
            issueloan.Close()
        End If
        If homeform.f_addcus = True Then
            Me.Close()
        End If
    End Sub

    Dim cus As String
    Dim email As String
    Dim tel As Integer
    Dim accno As Integer
    Dim addr As String
    Dim err As Boolean

    Private Sub c_add_Click(sender As System.Object, e As System.EventArgs) Handles c_add.Click
        'saves to the database
        If err = False Then
            'add to database
        Else
            'return error message
        End If
    End Sub

    Private Sub c_cusname_Leave(sender As System.Object, e As System.EventArgs) Handles c_cusname.Leave
        'validate presence
        If Trim(c_cusname.Text) = "" Then
            err = True
            c_cusname.Text = "Empty!!!"
        End If
    End Sub

    Private Sub c_accno_Leave(sender As System.Object, e As System.EventArgs) Handles c_accno.Leave
        'validate presence
        If Trim(c_accno.Text) = "" Then
            err = True
            c_accno.Text = "Empty!!!"
        End If
        'validate type
        If Not c_tel.Text.Contains("0") And Not c_tel.Text.Contains("1") And Not c_tel.Text.Contains("2") And Not c_tel.Text.Contains("3") And Not c_tel.Text.Contains("4") _
        And Not c_tel.Text.Contains("5") And Not c_tel.Text.Contains("6") And Not c_tel.Text.Contains("7") And Not c_tel.Text.Contains("8") And Not c_tel.Text.Contains("9") Then
            c_tel.Text = "Error!!!"
        End If
    End Sub

    Private Sub c_tel_Leave(sender As System.Object, e As System.EventArgs) Handles c_tel.Leave
        'validate presence
        If Trim(c_tel.Text) = "" Then
            err = True
            c_tel.Text = "Empty!!!"
        End If
        'validate type
        If Not c_tel.Text.Contains("0") And Not c_tel.Text.Contains("1") And Not c_tel.Text.Contains("2") And Not c_tel.Text.Contains("3") And Not c_tel.Text.Contains("4") _
        And Not c_tel.Text.Contains("5") And Not c_tel.Text.Contains("6") And Not c_tel.Text.Contains("7") And Not c_tel.Text.Contains("8") And Not c_tel.Text.Contains("9") Then
            c_tel.Text = "Error!!!"
        End If
        'validate length
        If c_tel.Text.Length < 11 Then
            c_tel.Text = "Error!!!"
        End If
    End Sub

    Private Sub c_email_Leave(sender As System.Object, e As System.EventArgs) Handles c_email.Leave
        'validate presence
        If Trim(c_email.Text) = "" Then
            err = True
            c_email.Text = "Empty!!!"
        End If
        'validate type
        If Not c_email.Text.Contains("@") And Not c_email.Text.Contains(".com") And Not c_email.Text.Contains(".net") And Not c_email.Text.Contains(".andg") And Not c_email.Text.Contains("biz") Then
            c_email.Text = "Error!!!"
        End If
        If c_email.Text.IndexOf("@") > c_email.Text.IndexOf(".com") And c_email.Text.IndexOf("@") > c_email.Text.IndexOf(".net") And c_email.Text.IndexOf("@") > c_email.Text.IndexOf(".andg") _
        And c_email.Text.IndexOf("@") > c_email.Text.IndexOf(".biz") Then
            c_email.Text = c_email.Text.IndexOf("@").ToString + " " + c_email.Text.IndexOf(".com").ToString + "Error!!!"
        End If
    End Sub

    Private Sub c_address_Leave(sender As System.Object, e As System.EventArgs) Handles c_address.Leave
        If Trim(c_address.Text) = "" Then
            err = True
            c_address.Text = "Empty!!!"
        End If
    End Sub
End Class