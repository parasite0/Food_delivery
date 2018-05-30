using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodDelivery.Web.Startup))]
namespace FoodDelivery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
