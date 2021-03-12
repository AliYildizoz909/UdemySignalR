using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.API.Hubs
{
    public class MyHub : Hub
    {
        //Client her istek yaptığında bu sınıf tekrar oluşacağından static tanımlanmayan tüm veriler sıfırlanacaktır.
        public static List<string> Names { get; set; } = new List<string>();

        //Tüm metotlar public ve async olmalıdır
        public async Task SendName(string name)
        {
            //Client propu tüm clientları temsil ediyor
            //All.SendAsync metodu ise bu huba bağlı tüm clientlarda çalışacak metodu ve metodun parametresini alır ve clientta çalıştırır.
            Names.Add(name);
            await Clients.All.SendAsync("ReceiveName", name);
        }
        public async Task GetNames()
        {
            await Clients.All.SendAsync("ReceiveNames", Names);
        }
    }
}
