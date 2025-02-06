namespace Orders.Infrastructure.Utilities
{
    public class TaxHelper
    {
        public static decimal ConvertNettoToGross(decimal netto, decimal tax) => netto * (1 + tax);
    }
}