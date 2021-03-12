using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;


namespace Store.Models.Grocary
{
    public abstract class Food : Grocary
    {
        protected Food(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry) 
        {
        }

        public abstract TypeOfFood TypeOfFood { get; }
    }
}
