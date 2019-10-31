namespace Ch01
{
    internal class Rental
    {
        private Movie _movie;
        private int _dayRented;

        public Rental(Movie movie, int dayRented)
        {
            _movie = movie;
            _dayRented = dayRented;
        }

        public Movie Movie
        {
            get { return _movie; }
        }


        public double GetAmount()
        {
            //因为本系统中可能发生变化的是加入影片的类型，而这种变化会带来不稳定的倾向。
            //所以希望控制它所造成的影响，所以选择在Movie内来计算费用。
            return _movie.GetAmount(_dayRented);
        }

        public int FrequentRenterPoints()
        {
            if (_movie.PriceCode == Movie.NewRelease && _dayRented > 1)
            {
                return 2;
            }
            return 1;
        }
    }
}