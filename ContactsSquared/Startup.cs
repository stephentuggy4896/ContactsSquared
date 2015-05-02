using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsSquared.Startup))]
namespace ContactsSquared
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
