using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        public string Suit;
        public string Number; 
        // Card Number is a string because Face Cards don't have integers for their "numbers"
        
        public Card(string suit, string number)
        {
            this.Suit = suit;
            this.Number = number;
        }
    }
}
