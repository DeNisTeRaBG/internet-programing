using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Telefonen_Ukazatel.Startup))]
namespace Telefonen_Ukazatel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
