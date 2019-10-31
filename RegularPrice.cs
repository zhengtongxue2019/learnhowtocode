namespace Ch01
{
    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;
        }

        public override double GetAmount(int dayRented)
        {
            double thisAmount = 2;
            if (dayRented > 2)
            {
                thisAmount += (dayRented - 2) * 1.5;
            }
            return thisAmount;
        }
    }
}