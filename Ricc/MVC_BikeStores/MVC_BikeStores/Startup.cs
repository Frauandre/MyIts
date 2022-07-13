using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BikeStores.Startup))]
namespace MVC_BikeStores
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
