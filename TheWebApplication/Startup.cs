using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheWebApplication.Startup))]
namespace TheWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
