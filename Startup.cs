using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbStuff.Startup))]
namespace dbStuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
