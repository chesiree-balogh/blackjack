using System;
using System.Collections.Generic;

namespace blackjack
{
  class Program
  {
    static void Main(string[] args)
    {
      //welcome message:
      Console.WriteLine("Ready to test your luck in a little game of BlackJack? Let's go!");




      //create new car for empty string for a card
      var newCard = "";

      //create a deck of 52 cards
      var deck = new List<Card>();

      //list of faces ex hearts spades diamonds clubs
      var cardsSuits = new List<string>() { "clubs", "diamonds", "hearts", "spades" };

      //list of card values
      var cardFaces = new List<string>() {"ace", "2", "3", "4", "5", "6", "7",
      "8", "9", "10", "jack", "queen", "king"};




      //this is the creation of pairing a suit with a rank and adding that to the deck
      for (int i = 0; i < cardsSuits.Count; i++)
      {
        for (int j = 0; j < cardFaces.Count; j++)
        {
          var card = new Card();
          card.Rank = cardFaces[j];
          card.Suit = cardsSuits[i];

          deck.Add(card);
        }
      }



      //this is where the created deck is being shuffled
      Random rnd = new Random();

      for (int z = deck.Count - 1; z >= 1; z--)
      {
        var j = new Random().Next(z);
        var temp = deck[j];
        deck[j] = deck[z];
        deck[z] = temp;
      }

      //List< >() is the syntex for LIST
      //bucket for dealers dealt cards
      var dealerHand = new List<Card>();

      //deal dealer 2 cards
      dealerHand.Add(deck[0]);
      dealerHand.Add(deck[1]);

      //remove dealers dealt cards from full deck
      deck.RemoveAt(0);
      deck.RemoveAt(0);



      //bucket for players dealt cards
      var playerHand = new List<Card>();

      //deal player 2 cards
      playerHand.Add(deck[0]);
      playerHand.Add(deck[1]);

      //remover players dealt cards from full deck
      deck.RemoveAt(0);
      deck.RemoveAt(0);


      //display the players hand
      Console.WriteLine($"Your first card is {playerHand[0].DisplayCards()}, and your second card is {playerHand[1].DisplayCards()}.");



      //should I nest this is a while loop???
      //while players hang is < 21 if >21 BUST
      // give the player their total
      var playerTotal = 0;
      for (int i = 0; i < playerHand.Count; i++)
      {
        playerTotal += playerHand[i].GetCardValue();
      }
      Console.WriteLine($"Giving you a total of:  {playerTotal}");


      //create option to hit or stay.... and if they bust over 21
      Console.WriteLine("Do you want to: (h)-Hit or (s)-Stand?");

      //players response 
      var input = Console.ReadLine().ToLower();

      //add another card to player hand
      if (input == "h")
      {
        Console.WriteLine("your new card is: ");
      }

      var newPlayersCard = new List<Card>();
      newPlayersCard.Add(deck[0]);
      deck.RemoveAt(0);
      Console.WriteLine($"{newPlayersCard[0].DisplayCards()}");


      //give player their new total
      var newPlayerTotal = 0;
      for (int i = 0; i < newPlayersCard.Count; i++)
      {
        newPlayerTotal += newPlayersCard[i].GetCardValue();
      }

      var combineTotal = newPlayerTotal + playerTotal;
      Console.WriteLine($"Giving you a total of:  {combineTotal}");


      //else if "Stand" show dealers hand 


      //if bust don't display dealers hand, Display "You busted, Dealer won"


      //if player didn't bust, distplay dealers cards value


      //have dealer hit/stand till 17 or highter in a loop


      //if player didn't bust but dealer did display "Dealer busted, YOU win!"


      //play again option, While Loop

      //while (condition) player>dealer player won


      //reshuffles full new deck


      //have it list out each face for each suit


    }
  }
}

