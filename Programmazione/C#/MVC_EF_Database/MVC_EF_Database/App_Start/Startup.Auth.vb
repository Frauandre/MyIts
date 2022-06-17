Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.Google
Imports Owin

Partial Public Class Startup
    ' Per altre informazioni su come configurare l'autenticazione, vedere https://go.microsoft.com/fwlink/?LinkId=301864
    Public Sub ConfigureAuth(app As IAppBuilder)
        ' Configurare il contesto di database, la gestione utenti e la gestione accessi in modo da usare un'unica istanza per richiesta
        app.CreatePerOwinContext(AddressOf ApplicationDbContext.Create)
        app.CreatePerOwinContext(Of ApplicationUserManager)(AddressOf ApplicationUserManager.Create)
        app.CreatePerOwinContext(Of ApplicationSignInManager)(AddressOf ApplicationSignInManager.Create)

        ' Consentire all'applicazione di utilizzare un cookie per memorizzare informazioni relative all'utente connesso
        ' e per memorizzare temporaneamente le informazioni relative a un utente che accede tramite un provider di accesso di terze parti
        ' Configura il cookie di accesso
        ' OnValidateIdentity consente all'applicazione di convalidare l'indicatore di sicurezza quando l'utente esegue l'accesso.
        ' Questa funzionalità di sicurezza è utile quando si cambia una password o si aggiungono i dati di un account di accesso esterno all'account personale.
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .Provider = New CookieAuthenticationProvider() With {
                .OnValidateIdentity = SecurityStampValidator.OnValidateIdentity(Of ApplicationUserManager, ApplicationUser)(
                    validateInterval:=TimeSpan.FromMinutes(30),
                    regenerateIdentity:=Function(manager, user) user.GenerateUserIdentityAsync(manager))},
            .LoginPath = New PathString("/Account/Login")})

        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' Consente all'applicazione di memorizzare temporaneamente le informazioni dell'utente durante la verifica del secondo fattore nel processo di autenticazione a due fattori.
        app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5))

        ' Consente all'applicazione di memorizzare il secondo fattore di verifica dell'accesso, ad esempio il numero di telefono o l'indirizzo e-mail.
        ' Una volta selezionata questa opzione, il secondo passaggio di verifica durante la procedura di accesso viene memorizzato sul dispositivo usato per accedere.
        ' È simile all'opzione RememberMe disponibile durante l'accesso.
        app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie)

        ' Rimuovere il commento dalle seguenti righe per abilitare l'accesso con provider di accesso di terze parti
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:="",
        '    clientSecret:="")

        'app.UseTwitterAuthentication(
        '   consumerKey:="",
        '   consumerSecret:="")

        'app.UseFacebookAuthentication(
        '   appId:="",
        '   appSecret:="")

        'app.UseGoogleAuthentication(New GoogleOAuth2AuthenticationOptions() With {
        '   .ClientId = "",
        '   .ClientSecret = ""})
    End Sub
End Class
