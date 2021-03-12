using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;
using Store.Models.Grocary.Vegetables;
using Store.Models.Result;

namespace Store.Helpers.Extentions
{
    public static class SaladExtention
    {
        public static Vegetable[] FindVegetables(this Salad salad, TypeOfVegetable typeOfVegetable, double minPrice, double maxPrice)
        {
            var temp = new Vegetable[salad.Vegetables.Length];

            for (var i = 0; i < temp.Length; i++)
            {
                var item = salad.Vegetables[i];
                if (item.TypeOfVegetable == typeOfVegetable && item.Price > minPrice && item.Price < maxPrice)
                {
                    temp[i] = salad.Vegetables[i];
                }
            }

            var tempResult = ArrayHelper.CleanCapacity(temp);

            var result = new Vegetable[tempResult.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = tempResult[i] as Vegetable;
            }

            return result;
        }
    }
}
