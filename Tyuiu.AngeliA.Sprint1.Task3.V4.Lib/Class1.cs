using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AngeliA.Sprint1.Task3.V4.Lib
{
    public class Class1 : ISprint1Task3V4
    {
        public double PurchaseAmount(double priceNotebook, double priceCover, int quantity)
        {
            return (priceNotebook * quantity) + (priceCover * quantity);
        }
    }
}
