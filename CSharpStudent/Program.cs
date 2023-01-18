using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudent
{
    internal class Program
    {
        /*
         * In the Solution Explorer (probably in the right panel)
         *      R-Click the Solution Name (Itp136Student)
         *          Choose "Rename"
         *          Change "Student" to "YourName" (no space or special characters)
         *              For example: "Itp136ChrisJones"
         *      R-Click the Project name (CSharpStudentYourName)
         *          Choose "Rename"
         *          Change "YourName" to your first and last name (no spaces or special characters)
         *              For example: "Itp136StudentChrisJones"
         */
        static void Main(string[] args)
        {
            int year = 2023;
            Console.WriteLine("Welcome to C#, ____"); //--< Replace the "____" with your name <<<
            Console.WriteLine($"The year is {year}");

            year++;         //--< The ++ increments the year variable <<<
            Console.WriteLine($"Next year is {year}");
            Console.ReadKey();
        }
    }
}
