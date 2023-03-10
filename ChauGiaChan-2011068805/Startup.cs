using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChauGiaChan_2011068805.Startup))]
namespace ChauGiaChan_2011068805
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
