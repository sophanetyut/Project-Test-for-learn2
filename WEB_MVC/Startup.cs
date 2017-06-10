using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB_MVC.Startup))]
namespace WEB_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
