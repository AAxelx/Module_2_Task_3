using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary
{
    public abstract class Grocary : Product
    {
        protected Grocary(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public abstract double Calorie { get; }
    }
}
