using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_CommerceWebApp.WebUI.Startup))]
namespace e_CommerceWebApp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
