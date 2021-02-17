/*###########################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 17/02/21

 Description: Week 4, Exercise 6 - practicing LINQ
              - Displaying names to screen using LINQ query
 ###########################################################################*/
using System;
using System.Linq;

namespace Ex6_7_and_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            /*=================== Exercise 6 ===================*/
            /* // Version 1 - Query
            var query = from name in names
                        select name;
            // end v1 */


            /* // Version 2 - Lambda
            var query = names
                .Select(n => n);
            // end v2 */


            /*=================== Exercise 7 ===================*/
            /* // Version 1 - Query
            var query = from name in names
                        orderby name ascending
                        select name;
            // end v1 */

            /* // Version 2 - Lambda
            var query = names
                .OrderBy(n => n)
                .Select(n => n);
            // end v2 */


            /*=================== Exercise 8 ===================*/
            /* // Version 1 - Query
            var query = from name in names
                        where (name.Substring(0, 1) == "M")
                        select name;
            // end v1 */

            // Version 2 - Query
            var query = names
                .Where(n => (n.Substring(0, 1) == "M"))
                .Select(n => n);
            // end v2 


            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            
        }// end Main()
    }// end Class
}// end Namespace
