using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(theGreatTree.Startup))]
namespace theGreatTree
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
