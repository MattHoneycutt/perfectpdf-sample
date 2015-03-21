using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PerfectPDF.SampleWeb.Startup))]
namespace PerfectPDF.SampleWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
