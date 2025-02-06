using Orders.Data.Entities;

namespace Orders.Infrastructure.Services.Interfaces
{
    public interface IOrderService
    {
        public void FillFinancialFields(Order order,decimal tax);
    }
}