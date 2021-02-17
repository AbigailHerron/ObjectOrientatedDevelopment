/*###########################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 17/02/21
  GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week%204/Ex2%20and%203/Program.cs

 Description: Week 4, Exercise 2 and 3 - practicing LINQ
              - Retrieves file information from C drive using basic
                information stored in a MyFileInfo class
 ###########################################################################*/
using System;
using System.IO;
using System.Linq;

namespace Ex2and3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=================== Exercise 2 ===================*/
            // creating a variable with all the file names of the files in the C:\Windows  directory
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            /* // Version 1 - Query
            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new MyFileInfo
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };
            // end v1 */

            /* // Version 2 - Lambda
            var query = files
                .Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new MyFileInfo
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });
            // end v2 */

            /*=================== Exercise 3 ===================*/
            /* // Version 1 - Query
            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };
            // end v1 */

            // Version 2 - Lambda
            var query = files
                .Where(f => f.Length > 100000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });
            // end v2

            Console.WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name} \t{item.Length} bytes, \t{item.CreationTime}");
            }
        }
    }// end Program class (main class)







    public class MyFileInfo
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime CreationTime { get; set; }
    }// end MyFileInfo class
}// end namespace Ex2
