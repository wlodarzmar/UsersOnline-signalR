using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace UsersOnline_SignalR
{
    public class UsersHub : Hub
    {
        private static List<string> usersOnline = new List<string>();

        public override Task OnConnected()
        {
            usersOnline.Add(Context.User.Identity.Name);
            Notify();
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            usersOnline.Remove(Context.User.Identity.Name);
            Notify();
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            usersOnline.Add(Context.User.Identity.Name);
            Notify();
            return base.OnReconnected();
        }

        private static void Notify()
        {
            GlobalHost.ConnectionManager.GetHubContext<UsersHub>().Clients.All.usersOnline(usersOnline);
        }

    }
}