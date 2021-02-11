/*##########################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Stats.cs
 
 Description: A blueprint for a Player's Statistics Record object
 Properties: GameCode, Wins, Losses, Draws
 Methods: UpdateStats
 Constructors: Default
 #########################################################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameInterfaceProject
{
    public class Stats
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string GameCode { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Initialises a blank Stats object
                       2) Passes a default value of 0 to all values */
        public Stats()
        {
            this.GameCode = "N/A";
            this.Wins = 0;
            this.Losses = 0;
            this.Draws = 0;
        }// end Default constructor

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: UpdateStats()
                  1) Takes in an int value (expected range 1-3)
                  2) Divides this number by 3
                  3) Updates the stats based on the remainder */
        public void UpdateStats(int result)
        {
            int data = result % 3;

            if (data == 0)
                this.Draws++;
            else if (data == 1)
                this.Wins++;
            else
                this.Losses++;
        }// end UpdateStats()
    }// end Stats class
}// end Namespace
