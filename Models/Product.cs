using ServiceProject1.Models.Commen;
using System.ComponentModel.DataAnnotations;

namespace ServiceProject1.Models
{
    public class Product: BaseAuiditibleEntity
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; } /*= null!;*/
        public double Price { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurants { get; set; }
    }
}
