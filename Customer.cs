using System.Collections.Generic;
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
            textWriter.WriteLine("Rental Record For " + Name);
            for (int index = 0; index < _rentals.Count; index++)
            {
                double thisAmount = 0;
                Rental each = _rentals[index];

                switch (each.Movie.PriceCode)
                {
                    case Movie.Regular:
                    {
                        thisAmount += 2;
                        if (each.DayRented>2)
                        {
                            thisAmount += (each.DayRented - 2) * 1.5;
                        }
                    }
                        break;
                    case Movie.NewRelease:
                    {
                        thisAmount += each.DayRented * 3;
                    }
                        break;
                    case Movie.Children:
                    {
                        thisAmount += 1.5;
                        if (each.DayRented>3)
                        {
                            thisAmount += (each.DayRented - 3) * 1.5;
                        }
                    }
                        break;
                }

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
            
            textWriter.WriteLine("Amount owed is " + totalAmount);
            textWriter.WriteLine("You earned " + frequentRenterPoints + " frequent renter points。");
            return textWriter.ToString();
        }
    }
}