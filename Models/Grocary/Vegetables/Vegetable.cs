using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Vegetables
{
    public abstract class Vegetable : Food
    {
        protected Vegetable(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public abstract TypeOfVegetable TypeOfVegetable { get; }
    }
}
