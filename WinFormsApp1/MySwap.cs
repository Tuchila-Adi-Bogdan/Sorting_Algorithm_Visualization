/* 
 * Author: Tuchilă Adi-Bogdan
 * Date: 08.11.2025
 * Redistribution is strictly prohibited.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm_Visualizer
{
    internal class MySwap
    {
        public static void swap(ref int a, ref int b)
        {
            Random rand = new Random();
            int method = rand.Next(5);
            switch (method)
            {
                case 0:
                    normalSwap(ref a, ref b);
                    break;
                case 1:
                    tupleSwap(ref a, ref b);
                    break;
                case 2:
                    xorSwap(ref a, ref b);
                    break;
                case 3:
                    additionSubtractionSwap(ref a, ref b);
                    break;
                case 4:
                    multiplicationDivisionSwap(ref a, ref b);
                    break;
            }
        }
        public static void normalSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void tupleSwap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
        public static void xorSwap(ref int a, ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
        public static void additionSubtractionSwap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        public static void multiplicationDivisionSwap(ref int a, ref int b)
        {
            if (a == 0 || b == 0)
                swap(ref a, ref b);
            a = a * b;
            b = a / b;
            a = a / b;
        }

    }
}
