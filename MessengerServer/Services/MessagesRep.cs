
using MessengerServer.Interfaces;
using MessengerServer.Models;
using System.Collections.Generic;
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

        public async Task<Message> GetMessages(int id)
        {
            var msg = await context.Messages.FindAsync(id);
            return msg;
        }
    }
}
