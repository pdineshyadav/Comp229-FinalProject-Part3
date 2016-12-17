using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamProject2_Part3Final.Startup))]
namespace TeamProject2_Part3Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
