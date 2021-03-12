using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Sweet
{
    public abstract class Cookie : Sweet
    {
        protected Cookie(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public abstract TypeOfCookie TypeOfCookie { get; }
    }
}
