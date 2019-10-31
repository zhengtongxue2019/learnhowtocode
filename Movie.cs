using System;

namespace Ch01
{
    internal class Movie
    {
        private string _title;
        private Price _price;

        public string Title => _title;

        public const int Children = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        public Movie(string title, int priceCode)
        {
            _title = title;
            SetPriceCode(priceCode);
        }

        private void SetPriceCode(int priceCode)
        {
            switch (priceCode)
            {
                case Regular:
                    _price = new RegularPrice();
                    break;
                case NewRelease:
                    _price = new NewReleasePrice();
                    break;
                case Children:
                    _price = new ChildrenPrice();
                    break;
                default:
                    throw new ArgumentException("Incorrect Price Code");
            }
        }

        public double GetAmount(int dayRented)
        {
            return _price.GetAmount(dayRented);
        }

        public int GetFrequentRenterPoints(int dayRented)
        {
            return _price.GetFrequentRenterPoints(dayRented);
        }
    }
}