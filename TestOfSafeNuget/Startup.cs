using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestOfSafeNuget.Startup))]
namespace TestOfSafeNuget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
