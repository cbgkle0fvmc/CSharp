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
            for(int i = 0; i < 13; i++) //for loop each face
            {
                for (int j=0; j < 4; j++) //for loop each suit
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
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
