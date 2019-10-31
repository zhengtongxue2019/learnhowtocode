namespace Ch01
{
    internal class Movie
    {
        public const int Children = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public string Title { get; }

        public int PriceCode { get; set; }

        public double GetThisAmount(Movie movie, int dayRented)
        {
            double thisAmount=0;
            switch (movie.PriceCode)
            {
                case Movie.Regular:
                {
                    thisAmount += 2;
                    if (dayRented > 2)
                    {
                        thisAmount += (dayRented - 2) * 1.5;
                    }
                }
                    break;
                case Movie.NewRelease:
                {
                    thisAmount += dayRented * 3;
                }
                    break;
                case Movie.Children:
                {
                    thisAmount += 1.5;
                    if (dayRented > 3)
                    {
                        thisAmount += (dayRented - 3) * 1.5;
                    }
                }
                    break;
            }

            return thisAmount;
        }
    }
}