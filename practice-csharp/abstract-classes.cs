using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class abstract_classes
    {


        static public void RunAllTests()
        {
            FullTimeEmployee ft = new FullTimeEmployee()
            {
                FirstName = "Chris",
                LastName = "Morse",
                YearlySalary = 100000
            };

            Console.WriteLine("-------------------------------");
            ft.PrintFullName();
            ft.PrintMonthlySalary();


            HourlyEmployee he = new HourlyEmployee()
            {
                FirstName = "Chuck",
                LastName = "Morse",
                HourlyRate = 50,
                MonthlyHoursWorked = 160
            };

            he.PrintFullName();
            he.PrintMonthlySalary();

        }



        // with abstract classes... you can't instantiate the base class here.   Not allowed.
        // Also, you have to implement the abstract method in the inherited class!

        public abstract class Employee
        {

            public string FirstName;
            public string LastName;

            public void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }

            public abstract void PrintMonthlySalary();

        }


        public class FullTimeEmployee : Employee
        {
            public float YearlySalary;

            public override void PrintMonthlySalary()
            {
                Console.WriteLine("Yearly Salary: {0}", this.YearlySalary / 12);
            }
        }


        public class HourlyEmployee : Employee
        {
            public float HourlyRate;
            public int MonthlyHoursWorked;

            // remember to override here....
            public override void PrintMonthlySalary()
            {
                Console.WriteLine("Yearly Salary: {0}", HourlyRate * MonthlyHoursWorked);
            }
        }


    }
}
