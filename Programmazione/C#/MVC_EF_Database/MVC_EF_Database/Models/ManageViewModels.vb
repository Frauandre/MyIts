Imports System.ComponentModel.DataAnnotations
Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security

Public Class IndexViewModel
    Public Property HasPassword As Boolean
    Public Property Logins As IList(Of UserLoginInfo)
    Public Property PhoneNumber As String
    Public Property TwoFactor As Boolean
    Public Property BrowserRemembered As Boolean
End Class

Public Class ManageLoginsViewModel
    Public Property CurrentLogins As IList(Of UserLoginInfo)
    Public Property OtherLogins As IList(Of AuthenticationDescription)
End Class

Public Class FactorViewModel
    Public Property Purpose As String
End Class

Public Class SetPasswordViewModel
    <Required>
    <StringLength(100, ErrorMessage:="La lunghezza di {0} deve essere di almeno {2} caratteri.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nuova password")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Conferma nuova password")>
    <Compare("NewPassword", ErrorMessage:="La nuova password e la password di conferma non corrispondono.")>
    Public Property ConfirmPassword As String
End Class

Public Class ChangePasswordViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Password corrente")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="La lunghezza di {0} deve essere di almeno {2} caratteri.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nuova password")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Conferma nuova password")>
    <Compare("NewPassword", ErrorMessage:="La nuova password e la password di conferma non corrispondono.")>
    Public Property ConfirmPassword As String
End Class

Public Class AddPhoneNumberViewModel
    <Required>
    <Phone>
    <Display(Name:="Numero di telefono")>
    Public Property Number As String
End Class

Public Class VerifyPhoneNumberViewModel
    <Required>
    <Display(Name:="Codice")>
    Public Property Code As String

    <Required>
    <Phone>
    <Display(Name:="Numero di telefono")>
    Public Property PhoneNumber As String
End Class

Public Class ConfigureTwoFactorViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
End Class