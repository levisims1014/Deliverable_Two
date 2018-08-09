using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Difference
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare variables
            DateTime LeviDate1;
            DateTime LeviDate2;


            //asking for user input
            Console.WriteLine("enter a date mm/dd/yyyy: ");
            //getting user input and coverting info to date
            LeviDate1 = Convert.ToDateTime(Console.ReadLine());


            //asking for user input
            Console.WriteLine("Enter a date mm/dd/yyyy: ");
            //getting user input and coverting info to date
            LeviDate2 = Convert.ToDateTime(Console.ReadLine());

            //getting the difference of the dates and naming the variable for it
            var diff = LeviDate2 - LeviDate1;
            //printing the difference of the dates in days
            Console.WriteLine("diff.Days: " + diff.Days);
            //printing the differences of the dates in hours
            Console.WriteLine("diff.Hours: " + diff.Hours);
            //printing the difference of the dates in minutes
            Console.WriteLine("diff.Minutes: " + diff.Minutes);

            Console.ReadLine();
        }
    }
}
