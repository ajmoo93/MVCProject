using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testovning.Startup))]
namespace Testovning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
