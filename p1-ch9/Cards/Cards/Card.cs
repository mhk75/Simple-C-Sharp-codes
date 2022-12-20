using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        private string face;
        private string suit;

        public Card(string cardSuit,string cardFace)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return face + "of" + suit;
        }
    }
}
