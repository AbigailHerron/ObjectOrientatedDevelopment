/*###########################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 17/02/21

 Description: Week 4, Exercise 1 - practicing LINQ
              - Gets all the numbers greater than 5 from the array numbers
 ###########################################################################*/
using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            /* // Version 1 - Query
            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;
            */

            // Version 2 - Lambda
            var outputNumbers = numbers
                .Where(n => n > 5)
                .OrderByDescending(n => n);
            // end v2

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
