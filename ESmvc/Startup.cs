using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESmvc.Startup))]
namespace ESmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
