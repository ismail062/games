
// imports
using System;
using System.Collections.Generic;
using System.Linq;

// A game deck game to create new game, shuffle, sort and draw card
// The player can create new game and enter his name.
// shuffle = shuffle all cards randomly
// sort = sort all cards by colors and values
// draw = show the top card

/// <summary>
/// a class to create different cards of different colors
/// </summary>
class Card
{
    
    /// local variables
    public string color ="";
    public int value = 0;

    // construct of Card class
    // create a new card object with color and value of a card
    public Card(string color, int value)
    {
        this.color = color;
        this.value = value;
    }

    // print out a specific card. 
    public void show()
    {
        Console.WriteLine("{0} of {1}", this.value, this.color);
    }
}

/// <summary>
/// A class to create a deck of cards
/// contain main functionality of game such as shuffle, sort, draw
/// </summary>

class Deck
{
    // list of cards ==> card deck
    public List<Card> cards = new List<Card> ();
    // list of colors
    string[] colors = { "Hearts", "Diamond", "Clover", "Spades" };
    // constructor of deck class
    // create a new deck which contains 52 cards of 4 colors
    public Deck()
    {
        // create cards and add in deck.
        foreach (var color in colors)
            for(int value=1; value<14; value++)
                cards.Add(new Card(color, value));
    }

    // randomly shuffle the cards
    public void Shuffle()
    {
        Random random = new Random();
        cards = cards.OrderBy(card => random.Next()).ToList();
    }

    // sort the cards based on color and values
    public void Sort()
    {
        cards = cards.OrderBy(card => (card.color, card.value)).ToList();
    }

    // draw last/top card
    public void Draw()
    {
        if (cards.Any())
        {
            Card card_to_remove = cards.LastOrDefault();
            card_to_remove.show();
            cards.Remove(card_to_remove);
        }
        else
            Console.WriteLine("Game Over! \nNo card left to Draw");
    }

    // show list of all cards in deck
    public void Show()
    {
        foreach (var card in cards)
            card.show();
    }
}

