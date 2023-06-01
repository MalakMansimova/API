using ServiceProject1.Models.Commen;
using System.ComponentModel.DataAnnotations;

namespace ServiceProject1.Models
{
    public class Restaurant: BaseAuiditibleEntity
    {
        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        public string Name { get; set; }
        public List<Product>Products { get; set; }
    }
}
