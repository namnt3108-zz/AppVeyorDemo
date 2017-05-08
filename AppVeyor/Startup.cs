using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppVeyor.Startup))]
namespace AppVeyor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
