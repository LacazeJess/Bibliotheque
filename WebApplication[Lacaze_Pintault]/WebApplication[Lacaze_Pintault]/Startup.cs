using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication_Lacaze_Pintault_.Startup))]
namespace WebApplication_Lacaze_Pintault_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
