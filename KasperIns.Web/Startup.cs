using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KasperIns.Web.Startup))]
namespace KasperIns.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
