@ModelType ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code
<h4>Utilizzare un altro servizio per eseguire l'accesso.</h4>
<hr />
@If loginProviders.Count() = 0 Then
    @<div>
          <p>
              Non sono configurati servizi di autenticazione esterni. Vedere <a href="https://go.microsoft.com/fwlink/?LinkId=403804">questo articolo</a>
              per informazioni su come configurare l'applicazione ASP.NET per il supporto dell'accesso tramite servizi esterni.
          </p>
    </div>
Else
    @Using Html.BeginForm("ExternalLogin", "Account", New With {.ReturnUrl = Model.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<div id="socialLoginList">
           <p>
               @For Each p As AuthenticationDescription In loginProviders
                   @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Accedi con l'account @p.Caption">@p.AuthenticationType</button>
               Next
           </p>
        </div>
    End Using
End If
