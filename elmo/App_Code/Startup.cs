using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(elmo.Startup))]
namespace elmo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
