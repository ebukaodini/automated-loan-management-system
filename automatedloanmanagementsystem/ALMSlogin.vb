Public Class ALMSlogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    '''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''
    Public user As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        user = "Ebuka"
        
        homeform.Show()
        homeform.almsuser = user
        loanpay.almsuser = user
        issueloan.almsuser = user
        addcustomer.almsuser = user
        managerates.almsuser = user
        manageloan.almsuser = user
        managecustomer.almsuser = user
        manageusers.almsuser = user

        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ALMSlogin_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_all()
    End Sub

    Private Sub ALMSlogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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
            addcustomer.Close()
        End If
    End Sub
End Class
