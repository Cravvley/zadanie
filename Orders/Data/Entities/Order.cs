namespace Orders.Data.Entities
{
    public class Order
    {
        public decimal NetTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public IList<OrderItem>? OrderItems { get; set; }
    }
}