using Microsoft.EntityFrameworkCore;
using financeApp.Models; 

namespace financeApp.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
