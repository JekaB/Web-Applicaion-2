using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Applicaion_2.Startup))]
namespace Web_Applicaion_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
