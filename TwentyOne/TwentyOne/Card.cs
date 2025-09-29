using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //constructor : values assigned to object upon creation 
        //the constructor method name is alwaus the same as the Class it is in
        public Card()
        {
            Suit = "Spades";
            Face = "Two";

        }
        public string Suit { get; set; }
        public string  Face { get; set; }

    }
}
