using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_partial_2017_10_29.Startup))]
namespace asp_partial_2017_10_29
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
