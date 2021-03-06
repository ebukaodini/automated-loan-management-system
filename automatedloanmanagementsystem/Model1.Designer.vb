
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("c9d080ce-73fc-4301-97bf-831ae6bcb6e5")>
#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class loanmanagementsystemEntities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new loanmanagementsystemEntities object using the connection string found in the 'loanmanagementsystemEntities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=loanmanagementsystemEntities", "loanmanagementsystemEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new loanmanagementsystemEntities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "loanmanagementsystemEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new loanmanagementsystemEntities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "loanmanagementsystemEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property admins() As ObjectSet(Of admin)
        Get
            If (_admins Is Nothing) Then
                _admins = MyBase.CreateObjectSet(Of admin)("admins")
            End If
            Return _admins
        End Get
    End Property

    Private _admins As ObjectSet(Of admin)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property loans() As ObjectSet(Of loan)
        Get
            If (_loans Is Nothing) Then
                _loans = MyBase.CreateObjectSet(Of loan)("loans")
            End If
            Return _loans
        End Get
    End Property

    Private _loans As ObjectSet(Of loan)

    #End Region

    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the admins EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToadmins(ByVal admin As admin)
        MyBase.AddObject("admins", admin)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the loans EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToloans(ByVal loan As loan)
        MyBase.AddObject("loans", loan)
    End Sub

    #End Region

End Class

#End Region

#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="loanmanagementsystemModel", Name:="admin")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class admin
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new admin object.
    ''' </summary>
    ''' <param name="password">Initial value of the password property.</param>
    Public Shared Function Createadmin(password As Global.System.String) As admin
        Dim admin as admin = New admin
        admin.password = password
        Return admin
    End Function

    #End Region

    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property password() As Global.System.String
        Get
            Return _password
        End Get
        Set
            If (_password <> Value) Then
                OnpasswordChanging(value)
                ReportPropertyChanging("password")
                _password = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("password")
                OnpasswordChanged()
            End If
        End Set
    End Property

    Private _password As Global.System.String
    Private Partial Sub OnpasswordChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnpasswordChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property int_rate_personal() As Global.System.String
        Get
            Return _int_rate_personal
        End Get
        Set
            Onint_rate_personalChanging(value)
            ReportPropertyChanging("int_rate_personal")
            _int_rate_personal = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("int_rate_personal")
            Onint_rate_personalChanged()
        End Set
    End Property

    Private _int_rate_personal As Global.System.String
    Private Partial Sub Onint_rate_personalChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Onint_rate_personalChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property int_rate_home() As Global.System.String
        Get
            Return _int_rate_home
        End Get
        Set
            Onint_rate_homeChanging(value)
            ReportPropertyChanging("int_rate_home")
            _int_rate_home = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("int_rate_home")
            Onint_rate_homeChanged()
        End Set
    End Property

    Private _int_rate_home As Global.System.String
    Private Partial Sub Onint_rate_homeChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Onint_rate_homeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property int_rate_company() As Global.System.String
        Get
            Return _int_rate_company
        End Get
        Set
            Onint_rate_companyChanging(value)
            ReportPropertyChanging("int_rate_company")
            _int_rate_company = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("int_rate_company")
            Onint_rate_companyChanged()
        End Set
    End Property

    Private _int_rate_company As Global.System.String
    Private Partial Sub Onint_rate_companyChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Onint_rate_companyChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property int_rate_organisation() As Global.System.String
        Get
            Return _int_rate_organisation
        End Get
        Set
            Onint_rate_organisationChanging(value)
            ReportPropertyChanging("int_rate_organisation")
            _int_rate_organisation = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("int_rate_organisation")
            Onint_rate_organisationChanged()
        End Set
    End Property

    Private _int_rate_organisation As Global.System.String
    Private Partial Sub Onint_rate_organisationChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Onint_rate_organisationChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property mortgage() As Global.System.String
        Get
            Return _mortgage
        End Get
        Set
            OnmortgageChanging(value)
            ReportPropertyChanging("mortgage")
            _mortgage = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("mortgage")
            OnmortgageChanged()
        End Set
    End Property

    Private _mortgage As Global.System.String
    Private Partial Sub OnmortgageChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnmortgageChanged()
    End Sub

    #End Region

End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="loanmanagementsystemModel", Name:="loan")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class loan
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new loan object.
    ''' </summary>
    ''' <param name="loan_name">Initial value of the loan_name property.</param>
    ''' <param name="loan_type">Initial value of the loan_type property.</param>
    ''' <param name="amount">Initial value of the amount property.</param>
    ''' <param name="tenure">Initial value of the tenure property.</param>
    ''' <param name="issued">Initial value of the issued property.</param>
    ''' <param name="repaydate">Initial value of the repaydate property.</param>
    ''' <param name="emi">Initial value of the emi property.</param>
    ''' <param name="interest">Initial value of the interest property.</param>
    ''' <param name="cost">Initial value of the cost property.</param>
    ''' <param name="status">Initial value of the status property.</param>
    Public Shared Function Createloan(loan_name As Global.System.String, loan_type As Global.System.String, amount As Global.System.Decimal, tenure As Global.System.Int64, issued As Global.System.DateTime, repaydate As Global.System.DateTime, emi As Global.System.Decimal, interest As Global.System.Decimal, cost As Global.System.Decimal, status As Global.System.String) As loan
        Dim loan as loan = New loan
        loan.loan_name = loan_name
        loan.loan_type = loan_type
        loan.amount = amount
        loan.tenure = tenure
        loan.issued = issued
        loan.repaydate = repaydate
        loan.emi = emi
        loan.interest = interest
        loan.cost = cost
        loan.status = status
        Return loan
    End Function

    #End Region

    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property customer_name() As Global.System.String
        Get
            Return _customer_name
        End Get
        Set
            Oncustomer_nameChanging(value)
            ReportPropertyChanging("customer_name")
            _customer_name = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("customer_name")
            Oncustomer_nameChanged()
        End Set
    End Property

    Private _customer_name As Global.System.String
    Private Partial Sub Oncustomer_nameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Oncustomer_nameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property loan_name() As Global.System.String
        Get
            Return _loan_name
        End Get
        Set
            If (_loan_name <> Value) Then
                Onloan_nameChanging(value)
                ReportPropertyChanging("loan_name")
                _loan_name = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("loan_name")
                Onloan_nameChanged()
            End If
        End Set
    End Property

    Private _loan_name As Global.System.String
    Private Partial Sub Onloan_nameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Onloan_nameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property loan_type() As Global.System.String
        Get
            Return _loan_type
        End Get
        Set
            Onloan_typeChanging(value)
            ReportPropertyChanging("loan_type")
            _loan_type = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("loan_type")
            Onloan_typeChanged()
        End Set
    End Property

    Private _loan_type As Global.System.String
    Private Partial Sub Onloan_typeChanging(value As Global.System.String)
    End Sub

    Private Partial Sub Onloan_typeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property amount() As Global.System.Decimal
        Get
            Return _amount
        End Get
        Set
            OnamountChanging(value)
            ReportPropertyChanging("amount")
            _amount = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("amount")
            OnamountChanged()
        End Set
    End Property

    Private _amount As Global.System.Decimal
    Private Partial Sub OnamountChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OnamountChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property tenure() As Global.System.Int64
        Get
            Return _tenure
        End Get
        Set
            OntenureChanging(value)
            ReportPropertyChanging("tenure")
            _tenure = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("tenure")
            OntenureChanged()
        End Set
    End Property

    Private _tenure As Global.System.Int64
    Private Partial Sub OntenureChanging(value As Global.System.Int64)
    End Sub

    Private Partial Sub OntenureChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property issued() As Global.System.DateTime
        Get
            Return _issued
        End Get
        Set
            OnissuedChanging(value)
            ReportPropertyChanging("issued")
            _issued = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("issued")
            OnissuedChanged()
        End Set
    End Property

    Private _issued As Global.System.DateTime
    Private Partial Sub OnissuedChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnissuedChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property repaydate() As Global.System.DateTime
        Get
            Return _repaydate
        End Get
        Set
            OnrepaydateChanging(value)
            ReportPropertyChanging("repaydate")
            _repaydate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("repaydate")
            OnrepaydateChanged()
        End Set
    End Property

    Private _repaydate As Global.System.DateTime
    Private Partial Sub OnrepaydateChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnrepaydateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property emi() As Global.System.Decimal
        Get
            Return _emi
        End Get
        Set
            OnemiChanging(value)
            ReportPropertyChanging("emi")
            _emi = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("emi")
            OnemiChanged()
        End Set
    End Property

    Private _emi As Global.System.Decimal
    Private Partial Sub OnemiChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OnemiChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property interest() As Global.System.Decimal
        Get
            Return _interest
        End Get
        Set
            OninterestChanging(value)
            ReportPropertyChanging("interest")
            _interest = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("interest")
            OninterestChanged()
        End Set
    End Property

    Private _interest As Global.System.Decimal
    Private Partial Sub OninterestChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OninterestChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property cost() As Global.System.Decimal
        Get
            Return _cost
        End Get
        Set
            OncostChanging(value)
            ReportPropertyChanging("cost")
            _cost = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("cost")
            OncostChanged()
        End Set
    End Property

    Private _cost As Global.System.Decimal
    Private Partial Sub OncostChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OncostChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property status() As Global.System.String
        Get
            Return _status
        End Get
        Set
            OnstatusChanging(value)
            ReportPropertyChanging("status")
            _status = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("status")
            OnstatusChanged()
        End Set
    End Property

    Private _status As Global.System.String
    Private Partial Sub OnstatusChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnstatusChanged()
    End Sub

    #End Region

End Class

#End Region


