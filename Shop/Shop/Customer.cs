using System.Collections.Generic;
using System.IO;
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
            TextWriter textWriter = new StringWriter();
            textWriter.WriteLine("租借人：" + Name);

            foreach (var rental in _rentals)
            {
                //show figures for this rental
                textWriter.WriteLine(rental.Movie.Title + ":" + rental.GetRentalAmount());
            }

            textWriter.WriteLine("本次费用合计： " + GetTotalAmount());
            textWriter.WriteLine("累计获得" + GetTotalFrequentRenterPoints() + " 积分。");
            return textWriter.ToString();
        }

        private int GetTotalFrequentRenterPoints()
        {
            return _rentals.Sum(rental => rental.GetFrequentRenterPoints());
        }

        private double GetTotalAmount()
        {
            return _rentals.Sum(rental => rental.GetRentalAmount());
        }
    }
}