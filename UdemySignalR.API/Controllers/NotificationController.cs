using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using UdemySignalR.API.Hubs;

namespace UdemySignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        //IHubContext ile istediğimiz yerde clientlara mesaj gönderebiliriz.
        private readonly IHubContext<MyHub> _hubContext;

        public NotificationController(IHubContext<MyHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet("{teamCount}")]
        public async Task<IActionResult> IndexTask(int teamCount)
        {
            await _hubContext.Clients.All.SendAsync("Notify", $"Arkadaşlar takım {teamCount} kişi olacaktır.");
            return Ok();
        }
    }
}
