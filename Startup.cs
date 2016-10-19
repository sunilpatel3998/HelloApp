using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloApp.Startup))]
namespace HelloApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
