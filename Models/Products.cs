using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oberoi_991674132_FE.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 100 characters")]
        public string ProductName { get; set; }

        public int CategoryID { get; set; } // Foreign Key

        public string Unit { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        // Navigation properties
        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }

        public ICollection<Orders> Orders { get; set; }

    }
}
