using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCVSTOGitHub.Startup))]
namespace MVCVSTOGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
