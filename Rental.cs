namespace Ch01
{
    internal class Rental
    {
        public Rental(Movie movie, int dayRented)
        {
            Movie = movie;
            DayRented = dayRented;
        }

        public int DayRented { get; }

        public Movie Movie { get; }

        public double GetAmount()
        {
            return Movie.GetThisAmount(Movie, DayRented);
        }

        public int FrequentRenterPoints()
        {
            if (Movie.PriceCode == Movie.NewRelease && DayRented > 1)
            {
                return 2;
            }
            return 1;
        }
    }
}