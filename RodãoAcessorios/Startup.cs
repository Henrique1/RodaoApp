using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RodãoAcessorios.Startup))]
namespace RodãoAcessorios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
