/*####################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 21/03/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Game.cs
 
 Description: An abstract class (Game) and all related Sub-Classes (GoFish, Match, TexasHoldEm, Fortune) as follows:
 --------------------------------------------------------------------
     Class: Game (abstract) 
     Properties: GameType, GameDeck
     Methods: Deal, ResetGame, CompareTo

             Sub-Class: GoFish
             Additional Properties: Pairs
             Additional Methods: CheckPairs, CompareTo(override), PullCards
             Constructors: Default

             Sub-Class: Match
             Additional Properties: Pairs, TriesLeft
             Additional Methods: IsMatch, CompareTo(override)
             Constructors: Default

             Sub-Class: TexasHoldEm
             Additional Properties: Bet
             Additional Methods: Raise, Fold
             Constructors: Default

             Sub-Class: Fortune
             Additional Properties: today
             Additional Methods: GetPast, GetPresent, GetFuture, CalcFortune, ToString(override)
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
    /*====================================================GAME CLASS=======================================================*/
    public abstract class Game : IComparable
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string GameType { get; set; }
        public Deck GameDeck { get; set; }
        public List<Player> Players { get; set; }

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: Deal()
                  1) To be overritten by sub-classes */
        public abstract void Deal(); // end Deal()


        /*Method: ResetGame()
                  1) To be overritten by sub-classes */
        public abstract void ResetGame(); // end ResetGame()


        /*Method: CompareTo()
                  1) To be overritten by sub-classes */
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }// end CompareTo
    }// end Game abstract class



    /*=================================================GO-FISH CLASS=======================================================*/
    public class GoFish : Game
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public int Pairs { get; set; }

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Creates a default, shuffled PlayingDeck object
                       2) Adds Player and Bot to List<Player> */
        public GoFish()
        {
            this.GameDeck = new PlayingDeck();
            GameDeck.Shuffle();

            // can pass the selected Player to this list when creating the game window
            this.Players = new List<Player>();             
            Player bot = new Player("Botty"); // adding a Bot to play against for now
            Players.Add(bot);
        }// end Default constructor

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: Deal()
                  1) Places 7 Card objects from the GameDeck into the Hand property of
                     each Player in the List Players
                  2) Removes Cards from GameDeck as they are dealt into Player Hands */
        public override void Deal()
        {
           foreach(Player p in Players)
            {
                while(p.Hand.Count < 7) // each hand starts with 7 cards
                {
                    p.Hand.Add(GameDeck.Pack.ElementAt(0));
                    GameDeck.Pack.RemoveAt(0); // card can't be in the deck and in a hand or pair
                }
            }
        }// end Deal()
        

        /*Method: ResetGame()
                  1) */
        public override void ResetGame()
        {
            
        }// end ResetGame()
        

        /*Method: CompareTo()
                  1) */
        public int CompareTo()
        {
            throw new NotImplementedException();
        }// end CompareTo()
        

        /*Method: CheckPairs()
                  1) */
        public void CheckPairs()
        {

        }// end CheckPairs()


        /*Method: PullCards()
                  1) */
        public void PullCards()
        {

        }// end PullCards()
    }// end GoFish class
}// end Namespace
