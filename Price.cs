﻿namespace Ch01
{
    public abstract class Price
    {
        public abstract double GetAmount(int dayRented);

        public virtual int GetFrequentRenterPoints(int dayRented)
        {
            return 1;
        }
    }
}