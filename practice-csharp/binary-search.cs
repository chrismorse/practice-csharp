﻿using System;
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

            Debug.Assert(BinarySearch_Recursive(sortedInput, -1, 0, sortedInput.Length - 1) == -1);
            Debug.Assert(BinarySearch_Recursive(sortedInput, 0, 0, sortedInput.Length - 1) == 0);
            Debug.Assert(BinarySearch_Recursive(sortedInput, 1, 0, sortedInput.Length - 1) == 1);
            Debug.Assert(BinarySearch_Recursive(sortedInput, 2, 0, sortedInput.Length - 1) == 2);
            Debug.Assert(BinarySearch_Recursive(sortedInput, 11, 0, sortedInput.Length - 1) == 9);
            Debug.Assert(BinarySearch_Recursive(sortedInput, 15, 0, sortedInput.Length - 1) == 10);
            Debug.Assert(BinarySearch_Recursive(sortedInput, 22, 0, sortedInput.Length - 1) == -1);

            
            Console.WriteLine("binary search done");

        }


        static int BinarySearch(int[] sortedInput, int target)
        {

            int high = sortedInput.Length - 1;
            int low = 0;
            int mid = 0;

            while (low <= high)
            {
                mid = (high + low) / 2;

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


        static int BinarySearch_Recursive(int[] sortedInput, int target, int low, int high)
        {

            int mid = (high + low) / 2;


            if (low <= high)
            {
                if (target > sortedInput[mid])
                {
                    low = mid + 1;
                    return BinarySearch_Recursive(sortedInput, target, low, high);
                }
                else if (target < sortedInput[mid])
                {
                    high = mid - 1;
                    return BinarySearch_Recursive(sortedInput, target, low, high);
                }
                else
                {
                    return mid;
                }
            }
            else
            {
                return -1;
            }
        }


    }
}
