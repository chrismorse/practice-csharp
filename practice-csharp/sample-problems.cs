using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class sample_problems
    {

        public static void RunAllTests()
        {
            int[] vals = { 1, 2, 3, 4, 19, 29, 5, 6, 7, 4, 3, 5, 6, 22, 5, 4, 3, 1, 8 };

            Console.WriteLine();
            Console.WriteLine("largest is {0}", findLargestItemInArray(vals));
        }
        
        
        
        // find the largest item in an array
        static int findLargestItemInArray(int[] vals)
        {
            if (vals.Length == 0)
               return -1;

            // initialize maxVal
            int maxVal = vals[0];

            for (int i = 0; i < vals.Length; i++) {
                if (vals[i] > maxVal) 
                    maxVal = vals[i];
            }

            return maxVal;


        }
    
    
    }
}
