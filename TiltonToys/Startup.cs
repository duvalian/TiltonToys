using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiltonToys.Startup))]
namespace TiltonToys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
