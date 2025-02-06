using Orders.Data.Entities;
using Orders.Infrastructure.Services;

namespace Orders.Tests
{
    public class OrderServiceTest
    {
        [Fact]
        public void FillFinancialField()
        {
            // Arrange
            var order = new Order
            {
                OrderItems = new List<OrderItem>
            {
                new OrderItem { NetPrice = 100m, Quantity = 2 }, 
                new OrderItem { NetPrice = 50m, Quantity = 4 }   
            }
            };
            decimal tax = 0.2m; 
            var orderService = new OrderService(new OrderItemService());

            // Act
            orderService.FillFinancialFields(order, tax);

            // Assert
            var predictedNetTotal = 400m; 
            var predictedTotal = predictedNetTotal * 1.2m; 
            var predictedTax = predictedTotal - predictedNetTotal; 

            Assert.Equal(predictedNetTotal, order.NetTotal);
            Assert.Equal(predictedTotal, order.Total);
            Assert.Equal(predictedTax, order.Tax);

            Assert.Equal(200m, order.OrderItems[0].NetTotal); 
            Assert.Equal(240m, order.OrderItems[0].Total);    
            Assert.Equal(200m, order.OrderItems[1].NetTotal); 
            Assert.Equal(240m, order.OrderItems[1].Total);
        }
    }
}
