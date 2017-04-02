using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class hashing
    {

        public static void RunAllTests()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            NewDictionary();
            Console.WriteLine();

        }

        // Dictionary - does the key exists?  If so give me the item with that key.

        public static void NewDictionary()
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Washington", "Olympia");
            capitals.Add("Alabama", "Montgomery");
            capitals.Add("Arizona", "Phoenix");

            foreach (var capital in capitals)
            {
                Console.WriteLine("{0} => {1}", capital.Key, capital.Value);
            }

            Console.WriteLine(capitals["Alabama"]);

        }



    }
}
