using System.Collections.Generic;
using System.Linq;

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
            string result = "Rental Record For " + Name + "\r\n";
            foreach (var rental in _rentals)
            {
                //show figures for this rental
                result += rental.Movie.Title + ":" + rental.GetAmount() + "\r\n";
            }

            result += "Amount owed is " + GetTotalAmount() + "\r\n";
            result += "You earned " +  GetFrequentRenterPoints() + " frequent renter points。" + "\r\n";
            return result;
        }

        private int GetFrequentRenterPoints()
        {
            return _rentals.Sum(rental => rental.FrequentRenterPoints());
        }

        private double GetTotalAmount()
        {
            return _rentals.Sum(rental => rental.GetAmount());
        }
    }
}