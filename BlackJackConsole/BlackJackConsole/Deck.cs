using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    
    /// <summary>
    /// This Class represents a deck of playing cards.  It creates a deck of standard 52 cards.  It can suffle, and deal a single card, and reset the deck. 
    /// </summary>
    class Deck
    {
        private List<Card> _listOfAvalibleCards;
        private List<Card> _usedCards;

        

        /// <summary>
        /// This constructs the deck of playingcards
        /// </summary>
        public Deck()
        {
            _listOfAvalibleCards = new List<Card>();
            _usedCards = new List<Card>();

            //All 13 cards for spade
            for (int i = 1; i < 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 's'));
            }
            //all 13 cards for club
            for (int i = 1; i <= 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 'c'));
            }
            //all 13 cards for hearts
            for (int i = 1; i <= 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 'h'));
            }
            //all 13 cards for dia
            for (int i = 1; i <= 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 'd'));
            }
        }
        /// <summary>
        /// This Method deals a card from the top of the deck, removes it from the _listOfAvalibleCards and adds it to the used cards
        /// </summary>
        /// <returns></returns>
        public Card dealCard()
        {
            Card dealtCard = _listOfAvalibleCards[0];
            _listOfAvalibleCards.RemoveAt(0);
            _usedCards.Add(dealtCard);

            return dealtCard;

        }

            /// <summary>
            /// This method shuffles the cards in the _listOfAvalibleCards  IT DOES NOT add used cards back to the deck.  Reset method adds the used cards back to the deck then shuffles
            /// </summary>
            /// <returns>Returns an exact </returns>
            public void Shuffle()
        {
            _listOfAvalibleCards.Shuffle();
        }

        

        /// <summary>
        /// This method resets the deck and then shuffles the deck
        /// </summary>
        public void Reset()
        {
            _listOfAvalibleCards = new List<Card>();
            _usedCards = new List<Card>();

            //All 13 cards for spade
            for (int i = 1; i < 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 's'));
            }
            //all 13 cards for club
            for (int i = 1; i <= 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 'c'));
            }
            //all 13 cards for hearts
            for (int i = 1; i <= 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 'h'));
            }
            //all 13 cards for dia
            for (int i = 1; i <= 14; i++)
            {
                _listOfAvalibleCards.Add(new Card(i, 'd'));
            }


        }


        }

    static class MyExtensions
    {
        private static Random rng = new Random();
        /// <summary>
        /// This is an extension method for the generic list datatype. It will shuffle any (I)List of T objects.  It uses the Fisher-yates shuffle algorithm https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle 
        /// Explination and implementation guidance was taken from here https://stackoverflow.com/questions/273313/randomize-a-listt from the comment by Eric j https://stackoverflow.com/users/141172/eric-j
        /// </summary>
        /// <typeparam name="T"> This method takes a list of T objects</typeparam>
        /// <param name="list"> </param>
        public static void Shuffle<T>(this IList<T> list)
        {
            for (int num = list.Count; num > 1; num--)
            {
                int x = rng.Next(num + 1);
                T val = list[x];
                list[x] = list[num];
                list[num] = val;
            }
        }
    }


    }
}
