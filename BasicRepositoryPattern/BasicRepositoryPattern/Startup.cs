using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicRepositoryPattern.Startup))]
namespace BasicRepositoryPattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
