/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Lab1/Album.cs
 
 Description: A blueprint for a musical Album object
 Properties: AlbumName, Released, Sales
 Methods: ToString() (override)
 Constructors: Default, All
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Album
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string AlbumName { get; set; }
        public int YearFormed { get; set; }
        public int Sales { get; set; }

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                  1) Chains to All Constructor
                  2) Passes down the default values */
        public Album() : this("Hits of the Year", 2021, 1000)
        {
        }// end Default Constructor


        /*Constructor: All
                  1) Takes in a string value and two int values
                  2) Creates an Album object with the AlbumName name, YearFormed year
                     and Sales sales */
        public Album(string name, int year, int sales)
        {
            this.AlbumName = name;
            this.YearFormed = year;
            this.Sales = sales;
        }// end All Constructor



        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: ToString()
                  1) Overrides original ToString() method */
        public override string ToString()
        {
            return string.Format($"{this.AlbumName} - released in {this.YearFormed}. Sales of {this.Sales}");
        }// end ToString()

    }// end Album class
}
