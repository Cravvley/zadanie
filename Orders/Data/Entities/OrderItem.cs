namespace Orders.Data.Entities
{
    public class OrderItem
    {
        public decimal NetPrice { get; set; }
        public int Quantity { get; set; }
        public decimal NetTotal { get; set; }
        public decimal Total { get; set; }
    }
}