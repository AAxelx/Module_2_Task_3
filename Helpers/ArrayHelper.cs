using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Helpers
{
    public static class ArrayHelper
    {
        public static void ReverseDeviceArray(object[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            object temp;

            while (start < end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }


        public static object[] CleanCapacity(object[] devices)
        {
            var count = 0;
            foreach (var item in devices)
            {
                if (item != null)
                {
                    count++;
                }
            }

            var result = new object[count];

            foreach (var item in devices)
            {
                if (item != null)
                {
                    result[--count] = item;
                }
            }


            ReverseDeviceArray(result);

            return result;
        }
    }
}
