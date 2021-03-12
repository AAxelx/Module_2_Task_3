using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Vegetables
{
    public class YellowTomat : Vegetable
    {
        public YellowTomat(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public override TypeOfVegetable TypeOfVegetable => TypeOfVegetable.Tomato;

        public override double Calorie => 85;

        public override string Name => "Yellow Tomato";

        public override TimeSpan LifeTime => TimeSpan.FromDays(7);

        public override TypeOfFood TypeOfFood => TypeOfFood.Grown;
    }
}
