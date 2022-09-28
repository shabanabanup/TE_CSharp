using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Outkey
    {
        public static void Main()
        {
            int id;
            string name, dept;
            details(out id, out name, out dept);
            Console.WriteLine($"Student ID= {id}");
            Console.WriteLine($"Student Name= {name}");
            Console.WriteLine($"Student Department= {dept}");

        }
        public static void details(out int sid, out string sname, out string sdept)
        {
            sid = 15019;
            sname = "Shabana";
            sdept = ".NET CORE";
        }

    }
}

