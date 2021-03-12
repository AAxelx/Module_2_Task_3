using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Enums;
using Store.Models.Grocary.Sweet;
using Store.Models.Result;

namespace Store.Helpers.Extentions
{
    public static class SweetBoxExtention
    {
        public static Sweet[] FindSweets(this SweetBox salad, TypeOfSweet typeOfSweet, double minPrice, double maxPrice)
        {
            var temp = new Sweet[salad.Sweets.Length];

            for (var i = 0; i < temp.Length; i++)
            {
                var item = salad.Sweets[i];
                if (item.TypeOfSweet == typeOfSweet && item.Price > minPrice && item.Price < maxPrice)
                    temp[i] = salad.Sweets[i];
            }

            var tempResult = ArrayHelper.CleanCapacity(temp);

            var result = new Sweet[tempResult.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = tempResult[i] as Sweet;
            }

            return result;
        }
    }
}
