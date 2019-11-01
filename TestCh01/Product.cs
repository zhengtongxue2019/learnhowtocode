namespace TestCh01
{
    public class Product
    {
        public double price;
        public int quantity;

        public double CalcBasePrice()
        {
            return GetBasePrice() * GetDiscountFactor();
        }

        private double GetDiscountFactor()
        {
            return GetBasePrice() >= 1000 ? 0.95 : 0.99;
        }

        private double GetBasePrice()
        {
            return price * quantity;
        }
    }
}