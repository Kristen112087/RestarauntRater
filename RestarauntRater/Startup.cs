using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestarauntRater.Startup))]
namespace RestarauntRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
