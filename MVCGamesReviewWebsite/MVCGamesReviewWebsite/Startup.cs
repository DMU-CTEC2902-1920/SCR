using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGamesReviewWebsite.Startup))]
namespace MVCGamesReviewWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
