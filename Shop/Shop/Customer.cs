﻿using System.Collections.Generic;
using System.IO;

namespace Ch01
{
    internal class Customer
    {
        private List<Rental> _rentals = new List<Rental>();
        
        public string Name { get; }
        
        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            TextWriter textWriter = new StringWriter();
            textWriter.WriteLine("租借人：" + Name);
            foreach (Rental rental in _rentals)
            {
                double thisAmount = 0;
                Rental each = rental;

                thisAmount = GetRentalAmount(each);

                //add frequentRenterPoints
                frequentRenterPoints++;
                if (each.Movie.PriceCode == Movie.NewRelease && each.DayRented>1)
                {
                    frequentRenterPoints++;
                }

                //show figures for this rental
                textWriter.WriteLine(each.Movie.Title + ":" + thisAmount);
                totalAmount += thisAmount;
            }
            
            textWriter.WriteLine("本次费用合计： " + totalAmount);
            textWriter.WriteLine("累计获得" + frequentRenterPoints + " 积分。");
            return textWriter.ToString();
        }

        private static double GetRentalAmount(Rental rental)
        {
            double thisAmount = 0;
            switch (rental.Movie.PriceCode)
            {
                case Movie.Regular:
                {
                    thisAmount += 2;
                    if (rental.DayRented > 2)
                    {
                        thisAmount += (rental.DayRented - 2) * 1.5;
                    }
                }
                    break;
                case Movie.NewRelease:
                {
                    thisAmount += rental.DayRented * 3;
                }
                    break;
                case Movie.Children:
                {
                    thisAmount += 1.5;
                    if (rental.DayRented > 3)
                    {
                        thisAmount += (rental.DayRented - 3) * 1.5;
                    }
                }
                    break;
            }
            return thisAmount;
        }
    }
}