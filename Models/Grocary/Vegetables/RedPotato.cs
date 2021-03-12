using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Vegetables
{
    public class RedPotato : Vegetable
    {
        public RedPotato(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }
        public override TypeOfVegetable TypeOfVegetable => TypeOfVegetable.Tomato;

        public override double Calorie => 130;

        public override string Name => "Red Potato";

        public override TimeSpan LifeTime => TimeSpan.FromDays(40);

        public override TypeOfFood TypeOfFood => TypeOfFood.Grown;
    }
}
