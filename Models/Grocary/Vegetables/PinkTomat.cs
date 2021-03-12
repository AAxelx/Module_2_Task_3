using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Vegetables
{
    public class PinkTomat : Vegetable
    {
        public PinkTomat(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public override TypeOfVegetable TypeOfVegetable => TypeOfVegetable.Tomato;

        public override double Calorie => 67;

        public override string Name => "Pink Tomato";

        public override TimeSpan LifeTime => TimeSpan.FromDays(9);

        public override TypeOfFood TypeOfFood => TypeOfFood.Grown;
    }
}
