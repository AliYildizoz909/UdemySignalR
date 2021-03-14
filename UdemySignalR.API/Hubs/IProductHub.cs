using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemySignalR.API.Models;

namespace UdemySignalR.API.Hubs
{
    public interface IProductHub
    {
        Task ReceiveProduct(Product product);
        Task ReceiveProduct2(Product product);
        Task ReceiveProduct3(Product product);
    }
}
