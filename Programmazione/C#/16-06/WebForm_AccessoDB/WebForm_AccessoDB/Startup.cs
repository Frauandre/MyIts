using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_AccessoDB.Startup))]
namespace WebForm_AccessoDB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
