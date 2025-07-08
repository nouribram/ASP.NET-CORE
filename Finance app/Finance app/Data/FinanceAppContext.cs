using Microsoft.EntityFrameworkCore;

public class FinanceAppContext : DbContext
{
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options)
        : base(options)
    {
    }

    // Example table — you can change this
    public DbSet<User> Users { get; set; }
}








/*using Microsoft.EntityFrameworkCore;
using FinanceApp.Models;


namespace FinanceApp.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
        { }
        public  DbSet<Expense> Expenses { get;set; }


    }
}
*/