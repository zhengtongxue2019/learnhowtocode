using System.Collections.Generic;

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
            string result = "Rental Record For " + Name + "\r\n";
            foreach (var rental in _rentals)
            {
                double thisAmount = 0;

                thisAmount = rental.GetAmount();

                //add frequentRenterPoints
                frequentRenterPoints++;
                if (rental.Movie.PriceCode == Movie.NewRelease && rental.DayRented>1)
                {
                    frequentRenterPoints++;
                }

                //show figures for this rental
                result +=  rental.Movie.Title + ":" + thisAmount + "\r\n";
                totalAmount += thisAmount;
            }
            
            result += "Amount owed is " + totalAmount + "\r\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points。" + "\r\n";
            return result;
        }
    }
}