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

        public int GetFrequentRenterPoints()
        {
            return Movie.GetFrequentRenterPoints(DayRented);
        }

        public double GetRentalAmount()
        {
            return Movie.GetRentalAmount(DayRented);
        }
    }
}