@Code
    ViewBag.Title = "Conferma reimpostazione password"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
</hgroup>
<div>
    <p>
        Reimpostazione password completata. @Html.ActionLink("Fare clic qui per eseguire l'accesso", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
