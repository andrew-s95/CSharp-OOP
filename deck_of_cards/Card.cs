using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string faceVal, string suitVal)
        {
            Face = faceVal;
            Suit = suitVal;
        }
    }
}