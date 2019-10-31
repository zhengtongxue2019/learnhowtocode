namespace Ch01
{
    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }

        public override double GetAmount(int dayRented)
        {
            return dayRented * 3;
        }

        public override int GetFrequentRenterPoints(int dayRented)
        {
            return dayRented > 1 ? 2 : 1;
        }
    }
}