using Orders.Data.Entities;
using Orders.Infrastructure.Services;
using Orders.Infrastructure.Utilities;

namespace Orders.Tests
{
    public class TaxHelperTest
    {
        [Fact]
        public void ConvertNettoToGross()
        {
            // Arrange
            decimal netto = 100m;
            decimal tax = 0.2m; 

            // Act
            decimal result = TaxHelper.ConvertNettoToGross(netto, tax);

            // Assert
            decimal predicted = 100m * 1.2m;
            Assert.Equal(predicted, result);
        }
    }
}
