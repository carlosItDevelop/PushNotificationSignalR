using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PushNotification.Web.Startup))]
namespace PushNotification.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
