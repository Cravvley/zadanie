using Orders.Data.Entities;
using Orders.Infrastructure.Services;
using Orders.Infrastructure.Utilities;

namespace Orders.Tests
{
    public class OrderItemServiceTest
    {
        [Fact]
        public void FillFinancialFields()
        {
            // Arrange
            var orderItem = new OrderItem { NetPrice = 100m, Quantity = 3 };
            decimal tax = 0.2m; 
            var service = new OrderItemService();

            // Act
            service.FillFinancialFields(orderItem, tax);

            // Assert
            var predictedNetTotal = 300m; 

            Assert.Equal(predictedNetTotal, orderItem.NetTotal);
            Assert.Equal(predictedNetTotal * 1.2m, orderItem.Total);
        }
    }
}
