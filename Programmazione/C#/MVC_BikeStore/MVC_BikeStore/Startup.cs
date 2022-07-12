using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BikeStore.Startup))]
namespace MVC_BikeStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
