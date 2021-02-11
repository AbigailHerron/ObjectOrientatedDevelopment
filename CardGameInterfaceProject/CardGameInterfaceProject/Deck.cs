/*####################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Deck.cs
 
 Description: An abstract class (Deck) and all related Sub-Classes (PlayingDeck, TarotDeck) as follows:
 --------------------------------------------------------------------
     Class: Deck (abstract) -- Note: May change this to a Parent class later
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

        /*Method: Shuffle
                  1) To be executed after CreateDeck has run
                  2) Re-orders the card objects in the list Pack */
        public void Shuffle()
        {
            Random order = new Random();
            Card temp = new Card();
            int cardIndex;

            for (int i = 0; i < this.Pack.Count; i++)
            {
                // makes cardIndex a random number within the limited range of cards in the list Pack
                cardIndex = order.Next(this.Pack.Count);

                    // keeping the details of card object at i in the list
                temp = this.Pack.ElementAt(i);
                    // makes the card at i now equal a random card in the Pack list
                this.Pack[i] = this.Pack.ElementAt(cardIndex); 
                    // puts original card at i (temp) where the index of the random card is
                this.Pack[cardIndex] = temp; // dealing with duplicates
            }// end for block
        }// end Shuffle()


    }// end Deck abstract class
}// end Namespace
