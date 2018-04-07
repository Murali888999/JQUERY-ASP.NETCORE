using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspdotNetCoreMVC.Startup))]
namespace AspdotNetCoreMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}