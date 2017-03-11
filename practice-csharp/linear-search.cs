using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class linear_search
    {
        public static void RunAllTests()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Debug.Assert(LinearSearch(input, 5) == 4);
            Debug.Assert(LinearSearch(input, 11) == -1);


        }

        static int LinearSearch(int[] input, int target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }


    }
    
}
