using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGetHub.Startup))]
namespace TestGetHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
