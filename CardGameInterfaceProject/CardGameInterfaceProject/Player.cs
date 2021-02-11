/*##########################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Player.cs
 
 Description: A blueprint for a Player object
 Properties: PlayerName, Stats
 Methods:
 Constructors: Default, All
 #########################################################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameInterfaceProject
{
    public class Player
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string PlayerName { get; set; }
        public List<Stats> Scores {get; set;}


        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Initialises a blank Player with default values
                       2) Passes default values to All constructor */
        public Player() : this("Guest") { }

        public Player(string name)
        {
            this.PlayerName = name;
                this.Scores = new List<Stats>();
        }
    }// end Player class
}// end Namespace
