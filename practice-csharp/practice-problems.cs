using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class practice_problems
    {

        public static void RunAllTests()
        {
            Console.WriteLine("-------------------------------------");
            FizzBuzz(15);

            SingleNumber(new int[] {0,1,2,3,1,0,2});
            SingleNumberXOR(new int[] {0,1,2,3,1,0,2});

        }



        // Given an array of integers, every element appears twice except for one.  Find that single one.
        public static int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (!set.Contains(num))
                {
                    set.Add(num);
                }
                else
                {
                    set.Remove(num);
                }
            }

            return set.First();

        }
        
        public static int SingleNumberXOR(int[] nums) {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
		        result ^= nums[i];
            }
	        return result;
        }







        public static IList<string> FizzBuzz(int n)
        {

            List<string> returnList = new List<string>();

            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    returnList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    returnList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    returnList.Add("Buzz");
                }
                else
                {
                    returnList.Add(i.ToString());
                }

            }

            return returnList;

        }

    }
}
