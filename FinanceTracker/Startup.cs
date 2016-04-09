using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceTracker.Startup))]
namespace FinanceTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
