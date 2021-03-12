using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Grocary.Vegetables;

namespace Store.Models.Result
{
    public class Salad
    {
        public Vegetable[] Vegetables { get; set; }

        public double Calorie { get; set; }
    }
}
