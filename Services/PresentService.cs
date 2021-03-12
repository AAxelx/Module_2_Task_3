using System;
using System.Collections.Generic;
using System.Text;
using Store.Services.Abstractions;
using Store.Models.Result;
using Store.Models.Grocary.Sweet;

namespace Store.Services
{
    public class PresentService : IPresentService
    {
        public PresentService()
        {
        }

        public SweetBox MakeNewYearSweetBox()
        {
            var sweet = new Sweet[]
            {
                new CaramelCandy(140, "Roshen", 700, Models.Enums.Country.Ukraine),
                new ChocolateCookie(120, "AVK", 400, Models.Enums.Country.Russia),
                new ChocolateCookie(240, "AVK", 800, Models.Enums.Country.Russia),
                new CaramelCandy(280, "Sweet Dream", 1400, Models.Enums.Country.Belarus)
            };

            var weight = 0d;
            for(var i = 0; i < sweet.Length; i++)
            {
                weight += sweet[i].Weight;
            }

            return new SweetBox { Sweets = sweet, Weight = weight };
        }
    }
}
