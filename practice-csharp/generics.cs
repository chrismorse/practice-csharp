using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class generics
    {

        public static void RunAllTests()
        {
            var result = new Result<int>{Success= true, Data = 5};
            var result2 = new Result<string> { Success = true, Data = "John" };

            var helper = new ResultPrinter();
            helper.Print(result);
            helper.Print(result2);

            Console.WriteLine("-------------------------------");


        
        }

        // Generics allow you to define type-safe data structures, without committing to actual data types.

        // removing duplication by defining the type as you go.   Do consistent things even though you are dealing with differnet data types.


        // instead of below... where we have similar structure but using different types we can use generics. 
        public class Result<T>
        {
            public bool Success { get; set; }
            public T Data { get; set; }
        }

        // a method that we call with a generic type
        public class ResultPrinter
        {
            public void Print<T>(Result<T> result)   //notice how to do this.   Need generic on both name and input
            {
                Console.WriteLine(result.Success);
                Console.WriteLine(result.Data);
            }
        }




        // could have multiple generic types
        public class ResultMultipleGenerics<T, U>
        {
            public bool Success { get; set; }
            public T Data1 { get; set; }
            public U Data2 { get; set; }

        }


        //public class ResultInt
        //{
        //    public bool Success { get; set; }
        //    public int Data { get; set; }
        //}

        //public class ResultString
        //{
        //    public bool Success { get; set; }
        //    public string Data { get; set; }
        //}

        //public class ResultBool
        //{
        //    public bool Success { get; set; }
        //    public bool Data { get; set; }
        //}


    }
}



