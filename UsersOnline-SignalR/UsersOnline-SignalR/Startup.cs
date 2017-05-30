using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsersOnline_SignalR.Startup))]
namespace UsersOnline_SignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
