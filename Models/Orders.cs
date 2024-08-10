using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oberoi_991674132_FE.Models
{
    public class Orders
    {

        [Key]
        public int OrderID { get; set; }
        public int ProductID { get; set; } // Foreign Key
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

       [ForeignKey("ProductID")]

        public Products Products { get; set; }
    }
}
