using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LyVanTrieu_BigSchool.Startup))]
namespace LyVanTrieu_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
