using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotSoAzure.Startup))]
namespace NotSoAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
