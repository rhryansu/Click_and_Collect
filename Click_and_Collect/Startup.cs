using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Click_and_Collect.Startup))]
namespace Click_and_Collect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
