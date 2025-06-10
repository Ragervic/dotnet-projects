using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [Range(typeof(DateTime),"01/01/2023","01/01/2026")]
        public DateTime Date { get; set; }
    }
}
