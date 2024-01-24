namespace BlazorAppCRUD.Data
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string? OrderName { get; set; }
        public string? State { get; set; }
        public int WindowId { get; set; }
        public string? WindowName { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
        public int SubElementId { get; set; }
        public int Element { get; set; }
        public string? Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Orders>? Orders { get; set; }

    }
}
