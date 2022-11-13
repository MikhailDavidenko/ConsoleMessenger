using MessengerServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MessengerServer.Interfaces
{
    public interface IMessages
    {
        List<Message> GetMessages(int id);
        Task AddMessage(Message msg);

    }
}
