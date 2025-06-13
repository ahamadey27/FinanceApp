using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
        {

        }
        //Click "View" up top "Server Explorer" and create database server and right click top to create data base
        public DbSet<Expense> Expenses { get; set; }

    }
}
