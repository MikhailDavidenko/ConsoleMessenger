using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessengerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessengerController : ControllerBase
    {       
        // GET api/<MessengerController>
        [HttpGet]
        public string Get()
        {
            return "Server is running..";
        }

        // POST api/<MessengerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
