/*##########################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Player.cs
 
 Description: A blueprint for a Player object
 Properties: PlayerName, Stats
 Methods: PullStats, PushStats
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
        public List<Card> Hand { get; set; }

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Initialises a blank Player with default values
                       2) Passes default values to All constructor */
        public Player() : this("Guest") { }// end Default constructor


        /*Constructor: All
                       1) Initialises a Player object with
                          the PlayerName name */
        public Player(string name)
        {
            this.PlayerName = name;
            this.Scores = new List<Stats>();
            this.Hand = new List<Card>();
        }// end All constructor

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: PullStats()
                  1) Pulls the lates Player statistics from a database
                  2) Not quite sure how to do this yet, so this is a placeholder */
        public void PullStats()
        {
        }// end PullStats()


        /*Method: PushStats()
                  1) Pushes the lates Player statistics to a database
                  2) Not quite sure how to do this yet, so this is a placeholder */
        public void PushStats()
        {
        }// end PushStats()

    }// end Player class
}// end Namespace
