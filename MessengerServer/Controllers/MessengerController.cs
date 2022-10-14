using System;
using Microsoft.AspNetCore.Mvc;
using MessengerServer.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessengerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessengerController : ControllerBase
    {
        static List<Message> ListOfMessages = new List<Message>();
        // GET api/<MessengerController>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string outputText = "Not found";

            if (id >= 0 && ListOfMessages.Count > id)
            {
                outputText = JsonConvert.SerializeObject(ListOfMessages[id]).ToString();
                Console.WriteLine("New GET Request");
            }
            Console.WriteLine(outputText);
            return outputText;
        }

        // POST api/<MessengerController>
        [HttpPost]
        public IActionResult Post([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }

            ListOfMessages.Add(msg);
            Console.WriteLine("Add new message");
            return Ok();
        }
    }
}
