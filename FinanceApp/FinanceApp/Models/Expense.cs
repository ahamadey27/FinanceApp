using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        //Required is default
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be more than zero")]
        public double Amount { get; set; }
        // Ensure the amount is greater than zero
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be more than zero")]
        [Required]
        public string Catagory { get; set; } = null!;
        public DateTime MyProperty { get; set; } = DateTime.Now; 
    }
}
