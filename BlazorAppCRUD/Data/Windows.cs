using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class Windows
    {
        [Key]
        public int WindowId { get; set; }
        public string? Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
       // public List<SubElements>? SubElements { get; set; }
    }
}
