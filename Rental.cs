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

        public int FrequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            frequentRenterPoints = frequentRenterPoints + 1;
            if (this.Movie.PriceCode == Movie.NewRelease && this.DayRented > 1)
            {
                //frequentRenterPoints++;
                frequentRenterPoints = frequentRenterPoints + 1;
            }

            return frequentRenterPoints;
        }
    }
}