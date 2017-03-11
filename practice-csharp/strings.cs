using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practice_csharp
{
    class strings
    {
        public static void RunAllTests()
        {
            const String testString = "reverse";
            const String reversedTestString = "esrever";

            String reversedString;
            
            reversedString = ReverseString(testString);
            Debug.Assert(reversedString == reversedTestString, "String is not reversed");

            reversedString = ReverseString2(testString);
            Debug.Assert(reversedString == reversedTestString, "String is not reversed");
            
            reversedString = ReverseString_Recursive(testString);
            Debug.Assert(reversedString == reversedTestString, "String is not reversed");

            reversedString = ReverseString3(testString);
            Debug.Assert(reversedString == reversedTestString, "String is not reversed");


            Console.WriteLine("strings done");

        }
        
        static string ReverseString(string input)
        {
            char[] charInput = input.ToCharArray();
            char[] reversed = new char[charInput.Length];

            for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
            {
                reversed[i] = charInput[j];
            }

            return new string(reversed);
        }


        static string ReverseString2(string input)
        {
            char[] charInput = input.ToCharArray();
            char[] reversed = new char[charInput.Length];

            for(int i = 0, j = input.Length -1; i<=j; i++, j--) {
                reversed[i] = charInput[j];
                reversed[j] = charInput[i];
            }

            return new string(reversed);

        }

        static string ReverseString3(string input)
        {
            return new String(input.Reverse().ToArray());

        }


        static string ReverseString_Recursive(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }
            else
            {
                return ReverseString_Recursive(input.Substring(1)) + input[0];
            }
        }

        


    }
}
