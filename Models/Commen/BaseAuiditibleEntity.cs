using System.Data;

namespace ServiceProject1.Models.Commen
{
    public class BaseAuiditibleEntity:BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
