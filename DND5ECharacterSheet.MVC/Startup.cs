using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DND5ECharacterSheet.MVC.Startup))]
namespace DND5ECharacterSheet.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
