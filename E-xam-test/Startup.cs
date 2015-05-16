using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_xam_test.Startup))]
namespace E_xam_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
