using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Sweet
{
    public abstract class Sweet : Food
    {
        protected Sweet(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public abstract TypeOfSweet TypeOfSweet { get; }


        public abstract bool IsExistAlcohol { get; }

        public abstract Ingredient[] Composition { get; }
    }
}
