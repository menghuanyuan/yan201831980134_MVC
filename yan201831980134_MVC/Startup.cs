using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yan201831980134_MVC.Startup))]
namespace yan201831980134_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
