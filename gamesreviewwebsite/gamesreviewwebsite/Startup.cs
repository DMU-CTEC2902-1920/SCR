using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gamesreviewwebsite.Startup))]
namespace gamesreviewwebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
