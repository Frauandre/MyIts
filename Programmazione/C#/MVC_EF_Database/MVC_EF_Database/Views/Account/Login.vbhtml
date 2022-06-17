@ModelType LoginViewModel
@Code
    ViewBag.Title = "Accedi"
End Code

<h2>@ViewBag.Title.</h2>
<div class="row">
    <div class="col-md-8">
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With { .ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>
                <h4>Utilizzare un account locale per eseguire l'accesso.</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <div class="checkbox">
                            @Html.CheckBoxFor(Function(m) m.RememberMe)
                            @Html.LabelFor(Function(m) m.RememberMe)
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Accedi" class="btn btn-default" />
                    </div>
                </div>
                <p>
                    @Html.ActionLink("Esegui registrazione come nuovo utente", "Register")
                </p>
                @* Abilitare questa opzione dopo aver abilitato la conferma dell'account per la funzionalità di reimpostazione della password
                    <p>
                        @Html.ActionLink("Password dimenticata?", "ForgotPassword")
                    </p>*@
                </text>
            End Using
        </section>
    </div>
    <div class="col-md-4">
        <section id="socialLoginForm">
            @Html.Partial("_ExternalLoginsListPartial", New ExternalLoginListViewModel With {.ReturnUrl = ViewBag.ReturnUrl})
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
