using Orders.Data.Entities;

namespace Orders.Infrastructure.Services.Interfaces
{
    public interface IOrderItemService
    {
        public void FillFinancialFields(OrderItem orderItem, decimal tax);
    }
}