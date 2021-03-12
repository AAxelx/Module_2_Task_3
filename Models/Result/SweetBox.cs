using System;
using System.Collections.Generic;
using System.Text;
using Store.Models.Grocary.Sweet;
using Store.Helpers.Extentions;

namespace Store.Models.Result
{
    public class SweetBox
    {
        public Sweet[] Sweets { get; set; }

        public double Weight { get; set; }
    }
}
