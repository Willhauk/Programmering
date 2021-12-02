using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Transfer
    {
        public string fromAccountNr;
        public string toAccountNr;
        public int amount;

        public Transfer(string fromAccountNr, string toAccountNr, int amount)
        {

        }

        public string FromAccountNr
        {
            get
            {
                return fromAccountNr;
            }
        }

        public string ToAccountNr
        {
            get
            {
                return toAccountNr;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
        }

    }


}
