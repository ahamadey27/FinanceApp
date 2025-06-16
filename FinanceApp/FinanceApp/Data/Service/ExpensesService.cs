using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FinanceApp.Data.Service
{
    public class ExpensesService : IExpensesService
    {
        private readonly FinanceAppContext _context;
        public ExpensesService(FinanceAppContext context)
        {
            _context = context;
        }

        public async Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }
    }
}
