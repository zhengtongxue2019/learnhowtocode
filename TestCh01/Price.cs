using System.Collections.Generic;
using System.Linq;

namespace TestCh01
{
    public partial class Shop
    {
        public bool CalcPrice(List<Product> products, ref double totalPrice)
        {
            if (products == null) return false;
            totalPrice += products.Sum(product => product.CalcBasePrice());
            return true;
        }
    }
}