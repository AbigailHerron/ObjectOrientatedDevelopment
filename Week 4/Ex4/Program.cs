/*###########################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 17/02/21
  GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week%204/Ex4/Program.cs

 Description: Week 4, Exercise 4 - practicing LINQ
              - Deferred Exectution
 ###########################################################################*/
using System;
using System.Linq;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,5,3,6,10,12,8};
            /* // Version 1 - Query
            var query = from number in numbers
                        select DoubleIt(number);
            // end v1 */

            // Version 2 - Lambda
            var query = numbers
                .Select(n => DoubleIt(n));
            // end v2

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }// end Main()

        // supporting DoubleIt method
        private static int DoubleIt (int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }// end DoubleIt()
    }// end class
}// end namespace
