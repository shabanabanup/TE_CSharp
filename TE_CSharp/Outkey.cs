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
            string name, dept,comp;
            details(out id, out name, out dept,out comp);
            Console.WriteLine($"Student ID= {id}");
            Console.WriteLine($"Student Name= {name}");
            Console.WriteLine($"Student Department= {dept}");
            Console.WriteLine($"Company = {comp}");
            

        }
        public static void details(out int sid, out string sname, out string sdept,out string scomp)
        {
            sid = 15019;
            sname = "Shabana";
            sdept = ".NET CORE";
            scomp = "TietoEvry";
            
        }

    }
}

