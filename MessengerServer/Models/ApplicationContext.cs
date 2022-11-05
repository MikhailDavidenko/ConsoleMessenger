using Microsoft.EntityFrameworkCore;

namespace MessengerServer.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Message> Messages { get; set; }
    }
}
