using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Deck
    {
        public string[] cards = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public string[] suits = {"Clubs", "Hearts", "Diamonds", "Spades"};
        public List<Card> Cards {get; set;}

        public Card Deal()
        {
            Card deal = Cards[0];
            Cards.Remove(deal);
            System.Console.WriteLine(deal);
            System.Console.WriteLine("Cards Remaining: " + Cards.Count);
            return deal;
        }

        public void Reset()
        {
            Cards.Clear();
            foreach (var suit in suits)
            {
                foreach(var card in cards)
                {
                    Cards.Add(new Card(suit, card));
                }
            }
        }
        public void Shuffle()
        {
            List<Card> ShuffledCards = new List<Card>();
            Random rand = new Random();
            while (Cards.Count > 0)
            {
                Card randCard = Cards[rand.Next(Cards.Count)];
                ShuffledCards.Add(randCard);
                Cards.Remove(randCard);
            }
            Cards = ShuffledCards;
            System.Console.WriteLine("Deck Shuffled");
        }
    }
}

