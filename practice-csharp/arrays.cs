using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class arrays
    {
        public static void RunAllTests()
        {
            Arrays();
            Console.WriteLine();

            JaggedArray();
            Console.WriteLine();
            
            MultiDimensionalArray();

            ArrayResize();

            ImplicitlyTypedArrays();
        }

        static void Arrays()
        {
            int[] ages = new int[] {5,6,7,8,9};
            foreach (var age in ages) {
                Console.Write("{0} ",age);
            }
            Console.WriteLine();
        }


        static void JaggedArray()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 2, 3, 4, 5, 6, 7, 9 };
            jaggedArray[2] = new int[] { 4, 5, 6, 7, 8, 9 };


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArray[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // can also use foreach to walk through.
            foreach (int[] thisRow in jaggedArray)
            {
                foreach (int thisItem in thisRow)
                {
                    Console.Write("{0} ", thisItem);
                }
                Console.WriteLine();
            }
        }


        static void MultiDimensionalArray()
        {
            int[,] multiArray = new int[3, 6]    // also called a rectangular array
            {
                {1,2,3,4,5,6},
                {4,5,6,7,8,9},
                {9,8,7,6,5,4}
            };

            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    Console.Write("{0} ", multiArray[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void ArrayResize()
        {
            int[] nums = {1,2,3,4,5};

            //could also create a temp, walk through all and copy... OR
            Array.Resize(ref nums, 6);
            nums[5] = 6;
        }


        static void ImplicitlyTypedArrays()
        {
            var myInstance = new { firstName = "Chris", lastName = "Morse" };
            var yourInstance = new { firstName = "Hiring", lastName = "Manager" };

            var myArray = new[] { myInstance, yourInstance };

            var myArray2 = new[] { 1, 2, 'a', 3, 4 };   //what type will this be??   (BTW - string won't compile)


        }


    }
}
