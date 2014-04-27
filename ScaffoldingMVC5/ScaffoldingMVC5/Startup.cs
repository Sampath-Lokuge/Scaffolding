using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScaffoldingMVC5.Startup))]
namespace ScaffoldingMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
