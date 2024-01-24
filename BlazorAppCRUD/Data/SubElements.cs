using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class SubElements
    {
        [Key]
        public int SubElementId { get; set; }
        public int Element { get; set; }
        public string? Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
}
