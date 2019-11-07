using System;

namespace Shop
{
    internal class Movie
    {
        public const int Children = 2; //儿童片
        public const int Regular = 0;//普通片
        public const int NewRelease = 1;//新片

        private Price _price;

        public Movie(string title, int priceCode)
        {
            Title = title;

            switch (priceCode)
            {
                case Movie.Regular:
                    {
                        _price = new RegularPrice();
                    }
                    break;
                case Movie.NewRelease:
                    {
                        _price = new NewReleasePrice();
                    }
                    break;
                case Movie.Children:
                    {
                        _price = new ChildrenPrice();
                    }
                    break;
                default:
                    throw new ArgumentException("没有找到对应的类别");
            }
        }

        public string Title { get; }

        public int GetFrequentRenterPoints(int DayRented)
        {
            return _price.GetFrequentRenterPoints(DayRented);
        }

        public double GetRentalAmount(int DayRented)
        {
            return _price.GetRentalAmount(DayRented);
        }
    }
}