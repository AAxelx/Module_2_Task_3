using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Sweet
{
    public class CaramelCandy : Candy
    {
        public CaramelCandy(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public override string Name => "Caramel Candy";

        public override TimeSpan LifeTime => TimeSpan.FromDays(14);

        public override double Calorie => 900;

        public override bool IsExistAlcohol => false;

        public override Ingredient[] Composition => new Ingredient[] { Ingredient.Buttle, Ingredient.Suger };

        public override TypeOfSweet TypeOfSweet => TypeOfSweet.Candy;

        public override TypeOfCandy TypeOfCandy => TypeOfCandy.Lollipop;

        public override TypeOfFood TypeOfFood => TypeOfFood.Produced;

    }
}
