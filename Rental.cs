namespace Ch01
{
    internal class Rental
    {
        private Movie _RentaledMovie;
        private int _dayRented;

        public Rental(Movie rentaledMovie, int dayRented)
        {
            _RentaledMovie = rentaledMovie;
            _dayRented = dayRented;
        }

        public Movie RentaledMovie
        {
            get { return _RentaledMovie; }
        }


        public double GetAmount()
        {
            //因为本系统中可能发生变化的是加入影片的类型，而这种变化会带来不稳定的倾向。
            //所以希望控制它所造成的影响，所以选择在Movie内来计算费用。:
            return _RentaledMovie.GetAmount(_dayRented);
        }

        public int GetFrequentRenterPoints()
        {
            return _RentaledMovie.GetFrequentRenterPoints(_dayRented);
            
        }
    }
}