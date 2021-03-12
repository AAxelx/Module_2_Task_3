using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Grocary.Vegetables;
using System.Collections;

namespace Store.Helpers.Comparers
{
    public class VegetableComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Vegetable;
            var y = second as Vegetable;

            if (x.Name.Length > y.Name.Length)
                return 1;
            else if (x.Name.Length < y.Name.Length)
                return -1;
            else
                return 0;
        }
    }
}
