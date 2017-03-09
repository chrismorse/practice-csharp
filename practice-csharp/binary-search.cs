using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class binary_search
    {

        public static void RunAllTests()
        {
            int[] sortedInput = new int[] {0,1,2,3,4,5,8,9,10,11,15};

            Debug.Assert(BinarySearch(sortedInput, -1) == -1);
            Debug.Assert(BinarySearch(sortedInput, 0) == 0);
            Debug.Assert(BinarySearch(sortedInput, 1) == 1);
            Debug.Assert(BinarySearch(sortedInput, 2) == 2);
            Debug.Assert(BinarySearch(sortedInput, 11) == 9);
            Debug.Assert(BinarySearch(sortedInput, 15) == 10);
            Debug.Assert(BinarySearch(sortedInput, 22) == -1);

            Console.WriteLine("binary search done");

        }


        static int BinarySearch(int[] sortedInput, int target)
        {

            int high = sortedInput.Length - 1;
            int low = 0;
            int mid = 0;

            while (low <= high)
            {
                mid = (int)Math.Ceiling(((double)high + (double)low) / 2);

                if (target > sortedInput[mid])
                {
                    low = mid + 1;
                }
                else if (target < sortedInput[mid])
                {
                    high = mid - 1 ;
                }
                else
                {
                    return mid;
                }

            }
            return -1;

        }

    }
}
