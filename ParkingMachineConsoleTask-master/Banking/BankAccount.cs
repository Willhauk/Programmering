using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class BankAccount
    {
        private bool accountNumber;
        private int pin;
        private float balance;
        private List<Transfer> successfullTransfers;

        private BankAccount(string accountNumber, string pin)
        {

        }
        private BankAccount(string accountNumber, string pin, int balance)
        {

        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
        }
        public bool Transfer(Transfer transfer)
        {
            
        }
        public bool ValidatePin(string pin)
        {

        }
        public List<Transfer> GetTransfers()
        {

        }
    }
}
