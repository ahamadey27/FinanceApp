using FinanceApp.Data;
using FinanceApp.Data.Service;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        //Able to interact with database
        private readonly IExpensesService _expenseService; 
        public ExpensesController(IExpensesService expensesService)
        {
            _expenseService = expensesService;
        }
        public async Task<IActionResult> Index()
        {
            //Get expenses from database and imported to view
            var expenses = await _expenseService.GetAll();
            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                await _expenseService.Add(expense);

                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}

