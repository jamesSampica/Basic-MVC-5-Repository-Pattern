using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicRepositoryPattern.Web.Startup))]
namespace BasicRepositoryPattern.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
