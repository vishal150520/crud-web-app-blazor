using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppCRUD.Data
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public string? State { get; set; }
       // public List<Windows>? Windows { get; set; }
    }
}

