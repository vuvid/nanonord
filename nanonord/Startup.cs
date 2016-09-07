using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nanonord.Startup))]
namespace nanonord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
