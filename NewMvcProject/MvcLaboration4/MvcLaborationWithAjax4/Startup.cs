using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLaborationWithAjax4.Startup))]
namespace MvcLaborationWithAjax4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
