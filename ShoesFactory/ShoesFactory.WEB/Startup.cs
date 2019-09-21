using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoesFactory.WEB.Startup))]
namespace ShoesFactory.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
