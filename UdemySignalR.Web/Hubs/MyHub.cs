using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace UdemySignalR.Web.Hubs
{
    public class MyHub : Hub
    {
        public async Task SendMessage(string name)
        {
            await Clients.All.SendAsync("ReceiveMessage", name);
        }
    }
}
