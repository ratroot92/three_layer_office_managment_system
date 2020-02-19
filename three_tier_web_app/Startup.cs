using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(three_tier_web_app.Startup))]
namespace three_tier_web_app
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
