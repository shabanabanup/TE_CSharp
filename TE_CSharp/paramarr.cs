﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TE_CSharp
{
    class paramarr
    {
        public static int Multiplication(params int[] numbers)
        {
            for (int i = 1; i <= numbers.Length; i++)
            {
                for (int j = 1; j <= numbers.Length; j++)
                {
                    Console.WriteLine("{0} X {1} ={2} \n", i, j, i * j);
                }
            }
            return (0);
        }
        public static void Main()
        {
            int m = Multiplication(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }
    }
}