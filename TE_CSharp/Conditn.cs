using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Conditn
    {

        public static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
                Console.WriteLine("team.");
                Console.WriteLine("had your tea");
                Console.WriteLine("--------------------------------------------------------------------");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day/n team.");
                Console.WriteLine("team.");
                Console.WriteLine("--------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Good evening.");
                Console.WriteLine("team.");
                Console.WriteLine("had your tea");
                Console.WriteLine("--------------------------------------------------------------------");

            }
        }

    }
}
        
    



