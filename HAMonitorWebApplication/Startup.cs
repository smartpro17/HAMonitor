using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAMonitorWebApplication.Startup))]
namespace HAMonitorWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
