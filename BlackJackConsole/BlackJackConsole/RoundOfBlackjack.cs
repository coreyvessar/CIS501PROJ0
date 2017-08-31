using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class RoundOfBlackjack
    {
        private double _betAmount;
        private Hand _playerHand;
        private Hand _dealersHand;

        private BJTable _theTable;

        
        public RoundOfBlackjack(double bet, BJTable thetable)
        {
            _betAmount = bet;
            _theTable = thetable;
            //create initial hands
            _playerHand = new Hand(_theTable._theDeck.dealCard());
            _playerHand.addCardToHand(_theTable._theDeck.dealCard());

            _dealersHand = new Hand(_theTable._theDeck.dealCard());
            _dealersHand.addCardToHand(_theTable._theDeck.dealCard());

            //check for initial blackjack
            if (_playerHand.checkNatural21())
            {
                if (_dealersHand.checkNatural21())
                {
                    push();
                }
                _betAmount = _betAmount * 1.5;
                playerWins();
            }
            if (_dealersHand.checkNatural21())
            {
                playerLoses();
            }
        }

        private void dealerLogic()
        {

        }

        public void playerLogic()
        {

        }
        




        private void push()
        {
            
        }

        private void playerWins()
        {

        }

        private void playerLoses()
        {

        }
    }
}
