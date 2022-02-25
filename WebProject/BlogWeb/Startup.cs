using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogWeb.Startup))]
namespace BlogWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
