using Microsoft.EntityFrameworkCore;

namespace Verif_Optional.Data
{
    public class DataContext
    {
        public class tableContext:DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source=(localdb)\\Local;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                }
            }
        }
    }
}
