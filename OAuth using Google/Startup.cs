using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuth_using_Google.Startup))]
namespace OAuth_using_Google
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
