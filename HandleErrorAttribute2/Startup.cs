using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandleErrorAttribute2.Startup))]
namespace HandleErrorAttribute2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
