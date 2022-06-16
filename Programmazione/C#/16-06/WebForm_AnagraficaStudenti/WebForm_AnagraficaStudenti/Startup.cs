using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_AnagraficaStudenti.Startup))]
namespace WebForm_AnagraficaStudenti
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
