using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewKunskapsKontroll.Startup))]
namespace NewKunskapsKontroll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
