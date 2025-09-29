using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //constructor (so that upon instantiation, deck of cards exist)
        //the constructor method name is always the same as the Class it is in
        public Deck()
        {
            //first thing is instantiate a empty list of cards 
            Cards = new List<Card>();
            // deck of cards consists of 4 suits 
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            // deck of cards consists of faces 2-10 and jack, queen, king, ace
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //loop through list of suits and faces, which will give a deck of cards

            //NESTED FOR LOOP

            foreach (string face in Faces)
            {
                foreach (string suit in  Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                    
                }
            }



        }
        public List<Card> Cards { get; set; }
    }
}
