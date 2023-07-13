using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

      
    }

}
