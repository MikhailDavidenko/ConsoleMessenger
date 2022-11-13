
using MessengerServer.Interfaces;
using MessengerServer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerServer.Services
{
    public class MessagesRep : IMessages
    {
        ApplicationContext context;

        public MessagesRep(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task AddMessage(Message msg)
        {
             await context.Messages.AddAsync(msg);
             await context.SaveChangesAsync();
        }

        public List<Message> GetMessages(int id)
        {
            //Message msg = context.Messages.Find(id);
            List<Message> msg = context.Messages.Where(i => i.Id >= id).ToList();
            return  msg;
        }
    }
}
