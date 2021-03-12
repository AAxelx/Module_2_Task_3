using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Sweet
{
    public abstract class Candy : Sweet
    {
        protected Candy(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public abstract TypeOfCandy TypeOfCandy { get; }
    }
}
