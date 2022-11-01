using System;
using Microsoft.AspNetCore.Mvc;
using MessengerServer.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessengerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessengerController : ControllerBase
    {
        static List<Message> ListOfMessages = new List<Message>();
        //public MessengerController()
        //{
        //    for (byte i = 0; i < 5; i++) ListOfMessages.Add(new Message());
            
        //}
        
        // GET api/<MessengerController>
        [HttpGet("{id}")]
        public async Task<List<Message>> Get(int id)
        {
            string[] outputText = new string[ListOfMessages.Count-id];


            if (id >= 0 && ListOfMessages.Count > id)
            {
                //int counter = 0;
                //for(int i = id; i < ListOfMessages.Count; i++)
                //{
                //    outputText[counter] = ListOfMessages[i].ToString();

                //    counter++;
                //}
                List < Message > messages= new List<Message>();
                for (int i = id; i < ListOfMessages.Count; i++)
                {
                    messages.Add(ListOfMessages[i]);
                }
                Console.WriteLine("New get request");
                return messages;
            }



            //Async
            //if (id >= 0 && ListOfMessages.Count > id)
            //{
            //    string[] textJson = new string[1];
            //    Console.WriteLine("New GET Request");
            //    using (var stream = new MemoryStream())
            //    {
            //        await JsonSerializer.SerializeAsync(stream, ListOfMessages[id], ListOfMessages[id].GetType());
            //        stream.Position = 0;
            //        using var reader = new StreamReader(stream);
            //        textJson[0] = await reader.ReadToEndAsync();
            //        return textJson;
            //    }
            //}

            //UTF8Bytes
            //if (id >= 0 && ListOfMessages.Count > id)
            //{
            //    string[] textJson = new string[1];
            //    Console.WriteLine("New GET Request");
            //    //await JsonSerializer.SerializeAsync(stream, ListOfMessages[id], ListOfMessages[id].GetType());
            //    textJson[0] = Encoding.UTF8.GetString(JsonSerializer.SerializeToUtf8Bytes(ListOfMessages[id], ListOfMessages[id].GetType()));
            //    return textJson;
            //}

            return null;
        }

        // POST api/<MessengerController>
        [HttpPost]
        public IActionResult Post([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            try
            {
                ListOfMessages.Add(msg);
                Console.WriteLine("Add new message");
                return Ok();
            }catch(Exception ex) {Console.WriteLine(ex.ToString()); return BadRequest(); }
            
        }
    }
}
