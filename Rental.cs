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
            double thisAmount=0;
            switch (this.Movie.PriceCode)
            {
                case Movie.Regular:
                {
                    thisAmount += 2;
                    if (this.DayRented > 2)
                    {
                        thisAmount += (this.DayRented - 2) * 1.5;
                    }
                }
                    break;
                case Movie.NewRelease:
                {
                    thisAmount += this.DayRented * 3;
                }
                    break;
                case Movie.Children:
                {
                    thisAmount += 1.5;
                    if (this.DayRented > 3)
                    {
                        thisAmount += (this.DayRented - 3) * 1.5;
                    }
                }
                    break;
            }

            return thisAmount;
        }
    }
}