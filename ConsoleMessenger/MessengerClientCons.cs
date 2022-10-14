using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleClent
{
    public class MessengerClientCons
    {
        public Message GetMessage(int MessageId)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/messenger/" + MessageId.ToString());
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            string status = ((HttpWebResponse)response).StatusDescription;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            if(responseFromServer != "Not found" && responseFromServer != null && status.ToLower() == "ok")
            {
                Message desMsg = JsonConvert.DeserializeObject<Message>(responseFromServer);
                return desMsg;
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
