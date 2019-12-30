using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Player
    {
        public string Name {get; set;}
        public List<Card> Hand {get; set;}

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck mainDeck)
        {
            var drawCard = mainDeck.Cards[0];
            Hand.Add(drawCard);
            mainDeck.Cards.Remove(drawCard);
            return drawCard;
        }

        public Card Discard(int index)
        {
            if (Hand[index] != null)
            {
                Card discard = Hand[index];
                Hand.Remove(discard);
                return discard;
            }
            return null;
        }

    }
}