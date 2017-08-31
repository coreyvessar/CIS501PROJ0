using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Dealer
    {
        private double _bank;
        private int _standOn;

        /// <summary>
        /// Constructs a dealer
        /// </summary>
        /// <param name="bankStartingValue"></param>
        public Dealer(double bankStartingValue)
        {
            _bank = bankStartingValue;
        }

        /// <summary>
        /// This is to add or subtract money from the wallet
        /// </summary>
        /// <param name="amount"></param>
        public void changeToBank(double amount)
        {
            _bank += amount;
        }

        /// <summary>
        /// This gets and sets _bank
        /// </summary>
        public double getBank
        {
            get { return _bank; }
        }

    }
}
