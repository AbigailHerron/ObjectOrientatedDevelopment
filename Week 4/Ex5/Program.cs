/*###########################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 17/02/21

 Description: Week 4, Exercise 5 - practicing LINQ
              - Chained Queries
 ###########################################################################*/
using System;
using System.Linq;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,5,3,6,10,12,8};

            /* // Version 1 - Query
            var query1 = from number in numbers
                         orderby number descending
                         select number;

            var query2 = from number in query1
                         where number < 8
                         select number;

            var query3 = from number in query2
                         select DoubleIt(number);
            // end v1 */

            // Version 2 - Lambda
            var query1 = numbers
                .OrderByDescending(n => n);

            var query2 = query1
                .Where(n => n < 8);

            var query3 = query2
                .Select(n => DoubleIt(n));
            // end v2

            foreach(var item in query3)
            {
                Console.WriteLine(item);
            }

        }// end Main()


        // supporting DoubleIt method
        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }// end DoubleIt()
    }// end Class
}// end Namespace
