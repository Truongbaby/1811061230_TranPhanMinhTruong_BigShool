using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811061230_TranPhanMinhTruong_BigShool.Startup))]
namespace _1811061230_TranPhanMinhTruong_BigShool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
