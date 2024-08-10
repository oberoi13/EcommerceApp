using System.ComponentModel.DataAnnotations;

namespace Oberoi_991674132_FE.Models
{
    public class Categories
    {

        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        // Navigation property
        public ICollection<Products> Products { get; set; }
    }
}
