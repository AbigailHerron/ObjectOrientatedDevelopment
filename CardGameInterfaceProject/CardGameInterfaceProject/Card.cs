/*####################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Card.cs
 
 Description: A blueprint for a Card object
 Properties: Rank, Suit, Point, Position
 Methods: ToString(override) - for testing purposes
 Constructors: Default
 ###################################################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameInterfaceProject
{
    public class Card
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int Point { get; set; }        
        public bool Position { get; set; }  /* | Note: Position is relavant for the TarotDeck as the card looks          |
                                               |       differentupside-down than upright. The PlayingDeck cards          |
                                               |       look the same either way, so it won't be referenced for that deck | */

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: ToString()
                  1) Overrides original ToString()
                  2) Returns the current object's Rank, Suit and Point values 
                  3) This is merely to test that the card class is working correctly
                     and will most likely be removed at a later date */
        public override string ToString()
        {
            return $"Card dealt is the {this.Rank} of {this.Suit}, value {this.Point}";
        }// end ToString()
    }// end Card Class
}
