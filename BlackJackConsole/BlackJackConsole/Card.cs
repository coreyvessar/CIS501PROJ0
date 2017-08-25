using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Card
    {
        //* This class represents a playing card object *//

        private  int _value; //this value can be 1 through 13  ace value begins at 1
        private  char _suit; // this char represents the suit of the card it can be s (spade) d (diamond) c (club) h (heart)

        /// <summary>
        /// This constructs card and assigns its value and suit
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(int value, char suit)
        {
            _value = value;
            _suit = suit;

        }
        /// <summary>
        /// This gets the value of the card 1-13
        /// </summary>
        /// <returns>The value of the card as an int</returns>
        public int getValue
        {
            get { return _value; }
        }

        /// <summary>
        /// This gets the suit of the card s,c,d or h
        /// </summary>
        /// <returns></returns>
        public char getSuit
        {
           get { return _suit; }
        }



    }
}
