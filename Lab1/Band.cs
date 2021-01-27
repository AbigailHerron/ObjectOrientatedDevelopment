/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Lab1/Band.cs
 
 Description: A blueprint for a musical Band object
 Properties: BandName, YearFormed, Members
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
    public class Band
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }


        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                  1) Chains to All Constructor
                  2) Passes down the default values */
        public Band() : this("Templates", 2021, "Me, Myself, I")
        {
        }// end Default Constructor


        /*Constructor: All
                  1) Takes in two string values and an int value
                  2) Creates a Band object with the BandName name, YearFormed year
                     and Members members */
        public Band(string name, int year, string members)
        {
            this.BandName = name;
            this.YearFormed = year;
            this.Members = members;
        }// end All Constructor


        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: ToString()
                  1) Overrides original ToString() method
                  2) Removes value to the Balance property */
        public override string ToString()
        {
            return this.BandName;
        }// end ToString()

    }// end Band class
}// end Namespace
