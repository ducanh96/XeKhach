using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XeKhach.Startup))]
namespace XeKhach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
