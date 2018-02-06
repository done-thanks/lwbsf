using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LWBSF_Ramp2.Startup))]
namespace LWBSF_Ramp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
