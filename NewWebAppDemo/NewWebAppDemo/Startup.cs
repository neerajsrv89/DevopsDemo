using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewWebAppDemo.Startup))]
namespace NewWebAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
