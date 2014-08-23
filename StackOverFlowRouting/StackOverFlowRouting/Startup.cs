using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StackOverFlowRouting.Startup))]
namespace StackOverFlowRouting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
