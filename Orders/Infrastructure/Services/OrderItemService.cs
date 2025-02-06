using Orders.Data.Entities;
using Orders.Infrastructure.Services.Interfaces;
using Orders.Infrastructure.Utilities;

namespace Orders.Infrastructure.Services
{
    public class OrderItemService : IOrderItemService
    {
        public void FillFinancialFields(OrderItem orderItem, decimal tax)
        {
            orderItem.NetTotal = orderItem.NetPrice * orderItem.Quantity;
            orderItem.Total = TaxHelper.ConvertNettoToGross(orderItem.NetTotal, tax);
        }
    }
}