﻿using System;

namespace Ch01
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

            PriceCode = priceCode;
        }

        public string Title { get; }

        public int PriceCode
        {
            get { return _price.GetPriceCode(); }
            set { _price.SetPriceCode(value); }
        }

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