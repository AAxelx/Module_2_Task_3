using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;

namespace Store.Models.Grocary.Sweet
{
    public class ChocolateCookie : Cookie
    {
        public ChocolateCookie(double price, string createdBy, double weight, Country createdCountry)
            : base(price, createdBy, weight, createdCountry)
        {
        }

        public override string Name => "Chocolate Cookie";

        public override TimeSpan LifeTime => TimeSpan.FromDays(14);

        public override double Calorie => 730;

        public override Ingredient[] Composition => new Ingredient[] { Ingredient.Suger, Ingredient.Suger };

        public override bool IsExistAlcohol => false;

        public override TypeOfSweet TypeOfSweet => TypeOfSweet.Flour;

        public override TypeOfCookie TypeOfCookie => TypeOfCookie.Suger;

        public override TypeOfFood TypeOfFood => TypeOfFood.Produced;
    }
}
