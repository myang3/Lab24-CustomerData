using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab24_CustomerData.Startup))]
namespace Lab24_CustomerData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
