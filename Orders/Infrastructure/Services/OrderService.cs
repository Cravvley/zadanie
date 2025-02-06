using Orders.Data.Entities;
using Orders.Infrastructure.Services.Interfaces;
using Orders.Infrastructure.Utilities;

namespace Orders.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        IOrderItemService OrderItemService{ get; set; }
        public OrderService(IOrderItemService orderItemService)
        {
            OrderItemService = orderItemService;
        }
        public void FillFinancialFields(Order order, decimal tax)
        {
            foreach(var orderItem in order.OrderItems) {
                OrderItemService.FillFinancialFields(orderItem,tax);
            }

            order.NetTotal = order.OrderItems.Sum(item => item.NetTotal);
            order.Total = TaxHelper.ConvertNettoToGross(order.NetTotal, tax);
            order.Tax = order.Total - order.NetTotal;
        }
    }
}