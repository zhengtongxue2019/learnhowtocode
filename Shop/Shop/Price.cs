namespace Ch01
{
    public abstract class Price
    {
        private int _priceCode;

        public abstract int GetPriceCode();

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
    }

    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;
        }
    }

    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }
    }

}