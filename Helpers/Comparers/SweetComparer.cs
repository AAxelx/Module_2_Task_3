using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Store.Models.Grocary.Sweet;

namespace Store.Helpers.Comparers
{
    public class SweetComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Sweet;
            var y = second as Sweet;

            if (x.Name.Length > y.Name.Length)
                return 1;
            else if (x.Name.Length < y.Name.Length)
                return -1;
            else
                return 0;
        }
    }
}
