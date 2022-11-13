using System;
using Microsoft.AspNetCore.Mvc;
using MessengerServer.Models;
using System.Collections.Generic;
using MessengerServer.Interfaces;
//using Newtonsoft.Json;
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
        private IMessages MessageRep;
        public MessengerController(IMessages messages)
        {
            MessageRep = messages;
        }

        // GET api/<MessengerController>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            


            if (id >= 0)
            {
               
                List < Message > msgs= new List<Message>();
                //Message m;
                //int counter = id;
                //do
                //{
                //    m = MessageRep.GetMessages(id);
                //    if (m != null)
                //    {
                //        msgs.Add(m);
                //    }
                //} while (m != null);
                msgs = MessageRep.GetMessages(id);
                Console.WriteLine("New get request");
                
                return Ok(msgs);
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

            return BadRequest();
        }

       

        // POST api/<MessengerController>
        [HttpPost]
        public IActionResult AddMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            try
            {
                //ListOfMessages.Add(msg);
                MessageRep.AddMessage(msg);
                Console.WriteLine("Add new message");
                return Ok();
            }catch(Exception ex) {Console.WriteLine(ex.ToString()); return BadRequest(); }
            
        }

        //UTF8
        //[HttpGet]
        //[Route("GetM/{id}")]
        //public  string GetMes(int id)
        //{
        //    string messages = "";


        //    //UTF8Bytes
        //    if (id >= 0 && ListOfMessages.Count > id)
        //    {
        //        Console.WriteLine("New GET Request");
        //        //await JsonSerializer.SerializeAsync(stream, ListOfMessages[id], ListOfMessages[id].GetType());
        //        for (int i = id; i < ListOfMessages.Count; i++)
        //        {
        //            messages += Encoding.UTF8.GetString(JsonSerializer.SerializeToUtf8Bytes(ListOfMessages[id], ListOfMessages[id].GetType()));
        //        }
        //        ListOfMessages.Clear();
        //        return messages;
        //    }
        //    ListOfMessages.Clear();
        //    return null;
        //}
        //[HttpGet]
        //[Route("New/{id}")]
        //public string GetNew(int id)
        //{
        //    string messages = "";

        //Newtonsoft.Json
        //    if (id >= 0 && ListOfMessages.Count > id)
        //    {
        //        Console.WriteLine("New GET Request");
        //        for (int i = id; i < ListOfMessages.Count; i++)
        //        {
        //            messages+=Newtonsoft.Json.JsonConvert.SerializeObject(ListOfMessages[i]);
        //        }
        //        ListOfMessages.Clear();
        //        return messages;
        //    }
        //    ListOfMessages.Clear();
        //    return null;
        //}
    }
}
