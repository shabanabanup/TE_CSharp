using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class St_Ist

    {
            public int substraction(int a, int b)
            {
                int val = a - b;
                return val;
            }
            static void Main(string[] args)
            {
            St_Ist a = new St_Ist();
                int newval = a.substraction(56, 12);
                Console.WriteLine(newval);
            Console.WriteLine("-------------------------------");

            Console.ReadKey();
            }
        
    }
    }










