using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models
{
    public abstract class Product
    {
        protected Product(double price, string createdBy, double weight, Country createdCountry)
        {
            Price = price;
            CreatedBy = createdBy;
            Weight = weight;
            CreatedCountry = createdCountry;
            CreatedDate = DateTime.UtcNow;
        }

        public double Price { get; }

        public string CreatedBy { get; }

        public double Weight { get; }

        public Country CreatedCountry { get; }

        public DateTime CreatedDate { get; }

        public DateTime ExperationDate => CreatedDate + LifeTime;

        public abstract string Name { get; }

        public abstract TimeSpan LifeTime { get; }
    }
}
