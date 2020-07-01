using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Necolads.Startup))]
namespace Necolads
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
