/*###########################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 17/02/21
  GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week%204/Ex9and10/Program.cs

 Description: Week 4, Exercise 6 - practicing LINQ
              - Displaying names to screen using LINQ query
 ###########################################################################*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex9and10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=================== Exercise 9 ===================*/
            /* // Version 1 - Query
            var query = from customer in GetCustomers()
                        where (customer.City == "Dublin")
                        select customer;
            // end v1 */

            /* // Version 2 - Lambda
            var query = GetCustomers()
                .Where(c => (c.City == "Dublin"))
                .Select(c => c);
            // end v2 */


            /*=================== Exercise 10 ==================*/
            /* // Version 1 - Query
            var query = from customer in GetCustomers()
                        where ((customer.City == "Dublin") || (customer.City == "Galway"))
                        orderby customer.Name
                        select customer;
            // end v1 */

            // Version 2 - Lambda
            var query = GetCustomers()
                .Where(c => ((c.City == "Dublin") || (c.City == "Galway")))
                .OrderBy(c => c.Name)
                .Select(c => c);
            // end v2

            foreach (Customer c in query)
            {
                Console.WriteLine($"{c.Name} is from {c.City}");
            }
        }// end Main()






        // support GetCustomers method
        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }// end GetCustomers()
    }// end Class


    // supporting class Customer
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
    }// end Customer class
}// end Namespace
