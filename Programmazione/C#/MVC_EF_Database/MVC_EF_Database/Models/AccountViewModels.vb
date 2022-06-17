Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Posta elettronica")>
    Public Property Email As String
End Class

Public Class ExternalLoginListViewModel
    Public Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl As String
    Public Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider As String
    
    <Required>
    <Display(Name:="Codice")>
    Public Property Code As String
    
    Public Property ReturnUrl As String
    
    <Display(Name:="Memorizzare questo browser?")>
    Public Property RememberBrowser As Boolean

    Public Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:="Posta elettronica")>
    Public Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Posta elettronica")>
    <EmailAddress>
    Public Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password As String

    <Display(Name:="Memorizza account")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Posta elettronica")>
    Public Property Email As String

    <Required>
    <StringLength(100, ErrorMessage:="La lunghezza di {0} deve essere di almeno {2} caratteri.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Conferma password")>
    <Compare("Password", ErrorMessage:="La password e la password di conferma non corrispondono.")>
    Public Property ConfirmPassword As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Posta elettronica")>
    Public Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="La lunghezza di {0} deve essere di almeno {2} caratteri.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Conferma password")>
    <Compare("Password", ErrorMessage:="La password e la password di conferma non corrispondono.")>
    Public Property ConfirmPassword() As String

    Public Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Posta elettronica")>
    Public Property Email() As String
End Class
