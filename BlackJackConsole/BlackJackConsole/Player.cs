using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    /// <summary>
    /// This class is a blueprint for a player for a game of blackjack
    /// </summary>
    class Player
    {
        private double _wallet;
        private int _numberOfGamesPlayed;
        private int _numberOfGamesWon;

        /// <summary>
        /// This is a constructor for player
        /// </summary>
        /// <param name="startingMoney"> the amount of money that the player starts with</param>
        public Player(double startingMoney)
        {
            _wallet = startingMoney;
            _numberOfGamesPlayed = 0;
            _numberOfGamesWon = 0;
            
        }
        /// <summary>
        /// This is to add or subtract money from the wallet
        /// </summary>
        /// <param name="amount"></param>
        public void changeToWallet(double amount)
        { 
            _wallet += amount;
        }
        /// <summary>
        /// This gets and sets _wallet
        /// </summary>
        public double getWallet
        {
            get { return _wallet; }
           

        }
        /// <summary>
        /// This gets and sets _numberOfGamesPlayed
        /// </summary>
        public int _numberofGamesPlayed
        {
            get { return _numberofGamesPlayed; }
            set { _numberofGamesPlayed++ ; }

        }

        // <summary>
        /// This gets and sets _numberOfGamesWon
        /// </summary>
        public int _numberofGamesWon
        {
            get { return _numberofGamesWon; }
            set { _numberofGamesWon++; }

        }

    }
}
