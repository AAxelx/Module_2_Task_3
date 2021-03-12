using System;
using System.Collections.Generic;
using System.Text;
using Store.Services.Abstractions;
using Store.Models.Result;
using Store.Models.Grocary.Vegetables;
using Store.Models.Enums;

namespace Store.Services
{
    public class SaladService : ISaladService
    {
        public SaladService()
        {
        }

        public Salad MakeSalad()
        {
            var vegetables = new Vegetable[]
            {
                new StandartPotato(350, "Some Farm", 450, Models.Enums.Country.Ukraine),
                new PinkTomat(230, "Some Farm", 200, Models.Enums.Country.Ukraine),
                new YellowTomat(270, "Some Farm", 180, Models.Enums.Country.Ukraine),
                new RedPotato(430, "Some Farm", 375, Models.Enums.Country.Belarus)
            };

            var calorie = 0d;
            for(var i = 0; i < vegetables.Length; i++)
            {
                calorie += vegetables[i].Calorie;
            }

            return new Salad { Vegetables = vegetables, Calorie = calorie };
        }
    }
}
