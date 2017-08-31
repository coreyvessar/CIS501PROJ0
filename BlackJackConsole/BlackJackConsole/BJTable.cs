using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class BJTable
    {
        
        public Deck _theDeck;
        private Player _player;
        private Dealer _dealer;
        private List<RoundOfBlackjack> _historyOfRounds;



        public BJTable(Player player, Dealer dealer, Deck deck, double betAmount)
        {
            _theDeck = deck;
            _theDeck.Shuffle();

            _player = player;
            _dealer = dealer;
            _historyOfRounds = new List<RoundOfBlackjack>();
        }

           


        /// <summary>
        /// deals a round of blackJack
        /// </summary>
        /// <param name="bet"> amount to be bet</param>
        /// <returns> returns true if a round was dealt, false if the dealers bank is empty or if the player doesnt have that mucch money to bet</returns>
        public bool dealARoundOfBJ(double bet)
        {
            if (_dealer.getBank > 0 && _player.getWallet >= bet)
            {
                RoundOfBlackjack currentRound = new RoundOfBlackjack(bet, this);
                _historyOfRounds.Add(currentRound);
                return true;
            }
            else return false;
        }


        }
        
    }
}
