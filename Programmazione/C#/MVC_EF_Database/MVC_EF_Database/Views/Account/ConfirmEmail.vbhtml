@Code
    ViewBag.Title = "Conferma e-mail"
End Code

<h2>@ViewBag.Title.</h2>
<div>
    <p>
        Grazie per aver confermato l'indirizzo e-mail. @Html.ActionLink("Fare clic qui per accedere", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
