using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SystemBuildWebApplication.Startup))]
namespace SystemBuildWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
