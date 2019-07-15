using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DokkanStore.Startup))]
namespace DokkanStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
