using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniStore.Startup))]
namespace UniStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
