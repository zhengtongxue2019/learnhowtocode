namespace Ch01
{
    internal class Movie
    {
        private string _title;
        private int _priceCode;

        public string Title => _title;

        public int PriceCode => _priceCode;

        public const int Children = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        public Movie(string title, int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
        }

       

        public double GetAmount(int dayRented)
        {
            double thisAmount=0;
            switch (_priceCode)
            {
                case Regular:
                {
                    thisAmount += 2;
                    if (dayRented > 2)
                    {
                        thisAmount += (dayRented - 2) * 1.5;
                    }
                }
                    break;
                case NewRelease:
                {
                    thisAmount += dayRented * 3;
                }
                    break;
                case Children:
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