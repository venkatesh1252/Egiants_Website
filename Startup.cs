using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EgiantsWebsite.Startup))]
namespace EgiantsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
