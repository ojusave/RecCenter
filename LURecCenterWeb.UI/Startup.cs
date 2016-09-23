using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LURecCenterWeb.UI.Startup))]
namespace LURecCenterWeb.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
