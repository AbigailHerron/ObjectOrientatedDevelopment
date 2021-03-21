/*####################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 21/03/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/CardGameInterfaceProject/CardGameInterfaceProject/Deck.cs
 
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
    class Game
    {
    }// end Game abstract class
}// end Namespace
