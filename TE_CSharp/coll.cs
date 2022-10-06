using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class coll
    {
        
            static public void Main()
            {
                //dictionary
                Dictionary<int, string> d = new Dictionary<int, string>();

                d.Add(107, "Willson");
                d.Add(209, "Thomas");
                d.Add(305, "Mark");

                //hastable
                Hashtable h = new Hashtable();

                h.Add(107, ".NET");
                h.Add(209, ".NET");
                h.Add(305, "Database");

                foreach (KeyValuePair<int, string> element in d)
                {
                    Console.WriteLine("ID: {0} and Name: {1}", element.Key, element.Value);
                Console.WriteLine("-------------------------------------");
            }
                Console.WriteLine("\n");
                Console.WriteLine("-------------------------------------");
                foreach (DictionaryEntry element in h)
                {
                    Console.WriteLine("ID: {0} and Batch: {1}", element.Key, element.Value);
                Console.WriteLine("-------------------------------------");
            }
            }
        
    }
}

