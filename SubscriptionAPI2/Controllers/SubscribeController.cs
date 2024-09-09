using Microsoft.AspNetCore.Mvc;

namespace EmailSubscriptionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] EmailRequest emailRequest)
        {
            var responseMessage = $"{emailRequest.Email} is now registered";
            return Ok(responseMessage);
        }
    }
    public class EmailRequest
    {
        public string Email { get; set; }
    }
}
