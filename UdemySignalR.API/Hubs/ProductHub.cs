using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using UdemySignalR.API.Hubs;
using UdemySignalR.API.Models;

namespace UdemySignalR.API.Hubs
{
    public class ProductHub : Hub<IProductHub>
    {
        public async Task SendProduct(Product product)
        {
            await Clients.All.ReceiveProduct(product);
        }
    }
}
