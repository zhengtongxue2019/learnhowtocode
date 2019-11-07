namespace Ch01
{
    public abstract class Price
    {
        private int _priceCode;

        public abstract int GetPriceCode();

        public abstract double GetRentalAmount(int DayRented);

        public void SetPriceCode(int priceCode)
        {
            _priceCode = priceCode;
        }
    }

    public class ChildrenPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Children;
        }

        public override double GetRentalAmount(int DayRented)
        {
            double thisAmount = 0;
            thisAmount += 1.5;
            if (DayRented > 3)
            {
                thisAmount += (DayRented - 3) * 1.5;
            }
            return thisAmount;
        }
    }

    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;
        }

        public override double GetRentalAmount(int DayRented)
        {
            double thisAmount = 0;
            thisAmount += 2;
            if (DayRented > 2)
            {
                thisAmount += (DayRented - 2) * 1.5;
            }
            return thisAmount;
        }
    }

    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }

        public override double GetRentalAmount(int DayRented)
        {
            double thisAmount = 0;
            thisAmount += DayRented * 3;
            return thisAmount;
        }
    }

}