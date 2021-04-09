/*####################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/02/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Deck.cs
 
 Description: An abstract class (Deck) and all related Sub-Classes (PlayingDeck, TarotDeck) as follows:
 --------------------------------------------------------------------
     Class: Deck (abstract) -- Note: May change this a normal class later
     Properties: Deck, SpecialCards
     Methods: Shuffle

             Sub-Class: PlayingDeck
             Additional Properties: Suits, Ranks
             Additional Methods: ToString(override)
             Constructors: Default

             Sub-Class: TarotDeck
             Additional Properties: MajorArcana, MinorSuits, MinorRanks
             Additional Methods: ToString(override), Shuffle(override)
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

    /*====================================================DECK CLASS=======================================================*/
    public abstract class Deck
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public List<Card> Pack { get; set; }

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: Shuffle
                  1) To be executed after CreateDeck has run
                  2) Re-orders the card objects in the list Pack */
        public virtual void Shuffle()
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

    /*================================================PLAYING-DECK CLASS===================================================*/
    public class PlayingDeck : Deck
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string[] suits = new string[] {"spades", "diamonds" ,"clubs" ,"hearts"};
        public string[] ranks = new string[] {"Ace", "2","3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Creates a default, unshuffled PlayingDeck object
                       2) Loops through suits and ranks arrays to create 52 cards, and places them
                          in the property Pack */
        public PlayingDeck()
        {
            this.Pack = new List<Card>(); // initialising List to avoid problems
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    Card c = new Card();
                    c.Suit = suits[i];
                    c.Rank = ranks[j];

                    // assigning the default point value for each card
                    if (j <= 8)
                        c.Point = j + 1; // the point value for ace is set to 1 at this time
                    else
                        c.Point = 10;  // cards 10 to King will be worth 10 points

                    Pack.Add(c); // adding new card to deck
                }
            }// end nested for block
        }// end Default constructor
    }// end PlayingDeck sub-class

    /*=================================================TAROT-DECK CLASS====================================================*/
    public class TarotDeck : Deck
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string[] majorArcana = new string[] {"Fool", "Magician", "High Priestess", "Empress", "Emperor",
                                                    "Hierophant", "Lovers","Chariot", "Justice", "Hermit",
                                                    "Wheel of Fortune", "Strength", "Hanged Man", "Death", "Temperance",
                                                    "Devil", "Tower", "Star", "Moon", "Sun", "Judgement", "World"};

        public string[] minorSuits = new string[] {"wands", "cups", "swords", "pentacles"};
        public string[] minorRanks = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knave",
                                                   "Knight", "Queen", "King"};

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Creates a default, unshuffled TarotDeck object
                       2) Loops through majorArcana, minorSuits and minorRanks arrays to create 78 cards, and places them
                          in the property Pack */
        public TarotDeck()
        {
            this.Pack = new List<Card>(); // initialising Pack first to avoid problems

            // looping through all major cards and adding them to the Pack list
            for(int i = 0; i < majorArcana.Length; i++)
            {
                Card c = new Card();
                c.Suit = "major";
                c.Rank = majorArcana[i];

                    // Note: from Ace to King in minor is 1 - 14, should start with Fool at 15
                c.Point = i + 15;
                c.Position = true; // this just means the card was pulled upright
                Pack.Add(c); // adding new card to deck
            }

            // looping through all minor cards and adding them to the Pack list
            for (int i = 0; i < minorSuits.Length; i++)
            {
                for (int j = 0; j < minorRanks.Length; j++)
                {
                    Card c = new Card();
                    c.Suit = minorSuits[i];
                    c.Rank = minorRanks[j];

                    // assigning the default point value for each card
                    c.Point = j + 1; // start with Ace and make it worth 1
                    c.Position = true;
                    Pack.Add(c); // adding new card to deck
                }
            }// end nested for block
        }// end Default constructor

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: Shuffle(override)
                  1) Takes the Shuffle() method from Deck class
                  2) Randomly changes the Position of each card ('flipping' random cards) 
                  3) Changes the Point value of any 'flipped' cards to a negative */
        public override void Shuffle()
        {
            base.Shuffle(); // re-ordering the deck as before
            Random flip = new Random();

            // each card in the Pack list has a random chance of being 'flipped'
            foreach(Card c in Pack)
            {
                if (flip.Next(1) != 0) // flip can either be 0 or 1
                {
                    // using if/else here in case the deck is shuffled more than once
                    if(c.Position == true)
                        c.Position = false;
                    else
                    c.Position = true; // make the card upside-down, essentially

                    c.Point = c.Point * (-1); // reverse the point value of the card when flipped
                }
            }// end loop
        }// end Shuffle()
    }// end TarotDeck sub-class
}// end Namespace
