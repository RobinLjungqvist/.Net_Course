using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture1webformsdemo.Startup))]
namespace Lecture1webformsdemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
