using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class DeckOfCardsTest
    {
        static void Main(string[] args)
        {
            DeckOfCards mydeckofcards = new DeckOfCards();
            mydeckofcards.Shuffle();

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine("{0,-19}",mydeckofcards.DealCard().ToString());
                
                if((i+1)%4 == 0)
                    Console.WriteLine();
            }
        }
    }
}
