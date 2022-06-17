@ModelType IndexViewModel
@Code
    ViewBag.Title = "Gestisci"
End Code

<h2>@ViewBag.Title.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Cambiare le impostazioni dell'account</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Password:</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Cambia password", "ChangePassword")
            Else
                @Html.ActionLink("Crea", "SetPassword")
            End If
            ]
        </dd>
        <dt>Account di accesso esterni:</dt>
        <dd>
            @Model.Logins.Count [
            @Html.ActionLink("Gestisci", "ManageLogins") ]
        </dd>
        @*
            È possibile usare i numeri di telefono come secondo fattore di verifica in un sistema di autenticazione a due fattori.
             
             Vedere <a href="https://go.microsoft.com/fwlink/?LinkId=403804">questo articolo</a>
                per informazioni su come configurare l'applicazione ASP.NET per il supporto dell'autenticazione a due fattori usando gli SMS.
             
             Rimuovere i commenti dal blocco seguente dopo aver configurato l'autenticazione a due fattori
        *@
        @* 
            <dt>Numero di telefono:</dt>
            <dd>
                @(If(Model.PhoneNumber, "None"))
                @If (Model.PhoneNumber <> Nothing) Then
                    @<br />
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                    @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                        @Html.AntiForgeryToken
                        @<text>[<input type="submit" value="Rimuovi" class="btn-link" />]</text>
                    End Using
                Else
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                End If
            </dd>
        *@
        <dt>Autenticazione a due fattori:</dt>
        <dd>
            <p>
                Non sono configurati provider di autenticazione a due fattori. Vedere <a href="https://go.microsoft.com/fwlink/?LinkId=403804">questo articolo</a>
                per informazioni su come configurare l'applicazione ASP.NET per il supporto dell'autenticazione a due fattori.
            </p>
            @*
                @If Model.TwoFactor Then
                    @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Attivato
                      <input type="submit" value="Disabilita" class="btn btn-link" />
                      </text>
                    End Using
                Else
                    @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Disabilitata
                      <input type="submit" value="Abilita" class="btn btn-link" />
                      </text>
                    End Using
                End If
	     *@
        </dd>
    </dl>
</div>
