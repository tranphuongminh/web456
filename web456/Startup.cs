using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web456.Startup))]
namespace web456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
