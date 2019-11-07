namespace Ch01
{
    internal class Movie
    {
        public const int Children = 2; //儿童片
        public const int Regular = 0;//普通片
        public const int NewRelease = 1;//新片

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public string Title { get; }

        public int PriceCode { get; set; }

        public int GetFrequentRenterPoints(int DayRented)
        {
            int frequentRenterPoints = 0;
            //add frequentRenterPoints
            frequentRenterPoints++;
            if (PriceCode == Movie.NewRelease && DayRented > 1)
            {
                frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }

        public double GetRentalAmount(int DayRented)
        {
            double thisAmount = 0;
            switch (PriceCode)
            {
                case Movie.Regular:
                {
                    thisAmount += 2;
                    if (DayRented > 2)
                    {
                        thisAmount += (DayRented - 2) * 1.5;
                    }
                }
                    break;
                case Movie.NewRelease:
                {
                    thisAmount += DayRented * 3;
                }
                    break;
                case Movie.Children:
                {
                    thisAmount += 1.5;
                    if (DayRented > 3)
                    {
                        thisAmount += (DayRented - 3) * 1.5;
                    }
                }
                    break;
            }
            return thisAmount;
        }
    }
}