using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    /// <summary>
    /// This class provides a blueprint for the blackjack hand opject.  It consists of a list of cards in the hand, the current value of those cards, and functions to score a hand and turn Aces from a natural 11 to a 1
    /// 
    /// </summary>
    class Hand
    {
        private int _score;
        private List<Card> _cardsInHand;

        /// <summary>
        /// This constructs a hand
        /// </summary>
        /// <param name="firstcard"> This is the first card needed to start a hand</param>
        public Hand(Card firstcard)
        {
            _cardsInHand = new List<Card>();
            _cardsInHand.Add(firstcard);

            _score = 0;
        }
        /// <summary>
        /// Checks for natural 21 (A and 10 value card)
        /// </summary>
        /// <returns></returns>
        public bool checkNatural21()
        {
            if(_score == 21 && _cardsInHand.Count == 2)
            {
                return true;
            }
            else { return false; }
        }
        /// <summary>
        /// This private method updates the score for the hand.  It should only be called when a new card is added to the hand
        /// </summary>
        private void updateScore()
        {
            int numAcesAt11 = 0;
            _score = 0; //reset score for good update
            //add up all the values of cards in the list
            foreach (Card c in _cardsInHand)
            {
                if(c.getValue == 1)
                {
                    numAcesAt11++; // record the number of aces used
                    _score += 11;
                }
                else if(c.getValue >= 10) // 10 and face cards are worth 10
                {
                    _score += 10;
                }

                else { _score += c.getValue; } //all other cards are worth their value              

            }
            while (_score > 21 && numAcesAt11 > 0) // if the score is too high and aces were used switch them to a value of 1
            {
                _score -= 10;
                numAcesAt11--;
            }

        }

        /// <summary>
        /// This method adds a card to the hand and then updates the score
        /// </summary>
        /// <param name="addedCard"></param>
       public void addCardToHand(Card addedCard)
        {
            _cardsInHand.Add(addedCard);
            updateScore();
        }


    }
}
