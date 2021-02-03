/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Lab1/Band.cs
 
 Description: Blueprints for a Band object.
              An abstract Band class with RockBand, PopBand and IndieBand subclasses

 Class: Band (abstract)
 Properties: BandName, YearFormed, Members
 Methods: ToString() (override), CompareTo()
 Constructors: Default, All

         Class: RockBand (sub-class)
         Additional Properties: 
         Additional Methods: 
         Altered Methods: ToString()
         Constructors: Default

         Class: PopBand (sub-class)
         Additional Properties: 
         Additional Methods: 
         Altered Methods: ToString()
         Constructors: Default

         Class: IndieBand (sub-class)
         Additional Properties: 
         Additional Methods: 
         Altered Methods: ToString()
         Constructors: Default
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /*==================================================== BAND CLASS =====================================================*/
    public abstract class Band : IComparable
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


        /*Method: CompareTo()
                  1) Implements the CompareTo() method from the IComparable abstract class
                  2) Removes value to the Balance property */
        public int CompareTo(object obj)
        {
            Band thatBand = obj as Band;
            return this.BandName.CompareTo(thatBand.BandName);
        }// end CompareTo()

    }// end Band class




    /*================================================= ROCK-BAND CLASS ===================================================*/
    public class RockBand : Band
    {


        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: ToString()
                  1) Adds ' Rock Band' to the end of parent class' ToString() */
        public override string ToString()
        {
            return base.ToString() + " Rock Band";
        }// end ToString()
    }// end RockBand class


    /*================================================== POP-BAND CLASS ====================================================*/
    public class PopBand : Band
    {
        /*Method: ToString()
                  1) Adds ' Pop Band' to the end of parent class' ToString() */
        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        public override string ToString()
        {
            return base.ToString() + " Pop Band";
        }// end ToString()
    }// end PopBand class


    /*================================================= INDIE-BAND CLASS ====================================================*/
    public class IndieBand : Band
    {
        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: ToString()
                  1) Adds ' Indie Band' to the end of parent class' ToString() */
        public override string ToString()
        {
            return base.ToString() + " Indie Band";
        }// end ToString()
    }// end IndieBand class

}// end Namespace
