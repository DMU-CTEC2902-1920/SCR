using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameReviewWebsite.Startup))]
namespace GameReviewWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
