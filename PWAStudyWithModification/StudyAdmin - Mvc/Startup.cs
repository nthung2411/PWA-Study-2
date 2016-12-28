using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyAdmin___Mvc.Startup))]
namespace StudyAdmin___Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
