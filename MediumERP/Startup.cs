using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediumERP.Startup))]
namespace MediumERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
