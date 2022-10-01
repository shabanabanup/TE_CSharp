using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
   


        public class addition
        {
            public addition(int x, int y)
            {
                Console.WriteLine($"Output in int: {x + y}");
            }
            public addition(float m, float n)
            {
                Console.WriteLine($"Output in float: {m + n}");
            }
            public addition(string p, string q)
            {
                Console.WriteLine($"Output in string: {p + q}");
            }
        }
        internal class constovload
    {
            public static void Main()
            {
                addition ad = new addition(30, 1);
            addition ad1 = new addition(9.60f, 8.476f);
            addition ad2 = new addition("Tieto", "Evry");
            }
        }
    
}

