using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsTraining.Startup))]
namespace WebFormsTraining
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
