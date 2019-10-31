namespace Ch01
{
    public class ChildrenPrice : Price
    {
        public override double GetAmount(int dayRented)
        {
            var thisAmount = 1.5;
            if (dayRented > 3)
            {
                thisAmount += (dayRented - 3) * 1.5;
            }
            return thisAmount;
        }
    }
}