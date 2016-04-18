using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVD_MvcCodeFirst.Startup))]
namespace DVD_MvcCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
