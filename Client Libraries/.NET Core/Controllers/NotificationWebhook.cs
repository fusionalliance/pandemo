using Client.Library.PublicAPI.External.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.Library.PublicAPI.External.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        // GET
        [HttpPost]
        public IActionResult Post(WebNotification notification)
        {
            return Ok();
        }
    }
}