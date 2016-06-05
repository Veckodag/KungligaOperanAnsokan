using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KungligaOperanAnsokan.Startup))]
namespace KungligaOperanAnsokan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
