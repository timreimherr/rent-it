using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rent_It.Startup))]
namespace Rent_It
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
