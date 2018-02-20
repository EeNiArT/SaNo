using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sanon.Startup))]
namespace Sanon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
