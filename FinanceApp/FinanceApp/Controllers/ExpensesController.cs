using FinanceApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        //Able to interact with database
        private readonly FinanceAppContext _context;
        public ExpensesController(FinanceAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //Get expenses from database and imported to view
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }
    }
}

// Note: The provided code block is a command to execute in the terminal for adding a migration, not a code change to be incorporated into the file.
