namespace Shop
{
    public abstract class Price
    {
        
        public abstract int GetPriceCode();

        public abstract double GetRentalAmount(int dayRented);

        public virtual int GetFrequentRenterPoints(int dayRented)
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

        public override double GetRentalAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += 1.5;
            if (dayRented > 3)
            {
                thisAmount += (dayRented - 3) * 1.5;
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

        public override double GetRentalAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += 2;
            if (dayRented > 2)
            {
                thisAmount += (dayRented - 2) * 1.5;
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

        public override double GetRentalAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += dayRented * 3;
            return thisAmount;
        }

        public override int GetFrequentRenterPoints(int dayRented)
        {
            int frequentRenterPoints = 0;
            //add frequentRenterPoints
            frequentRenterPoints++;
            if (dayRented > 1)
            {
                frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }
    }

}