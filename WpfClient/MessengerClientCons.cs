using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace WpfClient
{
    public class MessengerClientCons
    {        
        private static readonly HttpClient client = new HttpClient();
        public async Task<List<Message>> GetMessageHttpAsync(int MessageId)
        {
            var responseArr = await client.GetStringAsync("http://localhost:5000/api/messenger/" + MessageId);
            if (responseArr != null)
            {
                var messages = JsonConvert.DeserializeObject<List<Message>>(responseArr);
                
                return messages;
            }
            return null;
        }

        public bool PostMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/messenger");
            request.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteData = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteData.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteData, 0, byteData.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            string status = ((HttpWebResponse)response).StatusDescription;
            response.Close();
            return status.ToLower() == "ok";
        }
    }
}
