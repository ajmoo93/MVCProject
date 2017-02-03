using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLaboration4.Startup))]
namespace MvcLaboration4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
