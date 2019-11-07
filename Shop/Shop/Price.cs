namespace Ch01
{
    public abstract class Price
    {
        
        public abstract int GetPriceCode();

        public abstract double GetRentalAmount(int DayRented);

        public virtual int GetFrequentRenterPoints(int DayRented)
        {
            int frequentRenterPoints = 0;
            //add frequentRenterPoints
            frequentRenterPoints++;
            return frequentRenterPoints;
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

        public override int GetFrequentRenterPoints(int DayRented)
        {
            int frequentRenterPoints = 0;
            //add frequentRenterPoints
            frequentRenterPoints++;
            if (DayRented > 1)
            {
                frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }
    }

}