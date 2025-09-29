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
        //public : accessible everywhere
        //static: must use static modifier if you want to use method without first creating object of that class
        //Deck is return type
        //Shuffle is the name 
        //Deck is argument (parameter type) aka deck inside method
        //create optional parameter by assigning default value (int times = 1)
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }
}
