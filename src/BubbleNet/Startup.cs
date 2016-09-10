using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BubbleNet.Startup))]
namespace BubbleNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
