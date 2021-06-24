using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThirdTryMVC.Startup))]
namespace ThirdTryMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
