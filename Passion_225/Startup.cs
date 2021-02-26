using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Passion_225.Startup))]
namespace Passion_225
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
