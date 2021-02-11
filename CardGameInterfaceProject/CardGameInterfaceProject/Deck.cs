/*####################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Deck.cs
 
 Description: An abstract class (Deck) and all related Sub-Classes (PlayingDeck, TarotDeck) as follows:
 --------------------------------------------------------------------
     Class: Deck (abstract)
     Properties: Deck, SpecialCards
     Methods: Shuffle

             Sub-Class: PlayingDeck
             Additional Properties: --
             Additional Methods: ToString(override)
             Constructors: Default

             Sub-Class: TarotDeck
             Additional Properties: --
             Additional Methods: ToString(override)
             Constructors: Default
 --------------------------------------------------------------------
 ###################################################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameInterfaceProject
{
    public abstract class Deck
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public List<Card> Pack { get; set; }
        public string[] SpecialCards { get; set; }

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: CreateDeck
                  1) */

        /*Method: Shuffle
                  1) */


    }// end Deck abstract class
}// end Namespace
