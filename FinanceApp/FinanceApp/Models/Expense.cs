using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be more than zero")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public string Catagory { get; set; } = null!;

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
