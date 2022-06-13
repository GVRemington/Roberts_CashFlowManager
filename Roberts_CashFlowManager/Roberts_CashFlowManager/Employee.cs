using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowManager
{
    internal class Employee:IPayable
    {
        private string _name;
        private string _ssn;
        private decimal _payable;
        private Ledger.ledgerType _ledgerType;
       
        public Employee(string firstName, string lastName, string ssn) // **Constructor
        {
            _name = firstName + lastName;
            _ssn = ssn;
         
        }

        public Ledger.ledgerType setLedgerType(Ledger.ledgerType ledgerType) // **ledgerType Setter
        {
            _ledgerType = ledgerType;
            return _ledgerType;
        }
        public Ledger.ledgerType ledgerType                       // **ledgerType Getter
        {
            get { return _ledgerType; }
        }

        public decimal setPayable(decimal payable)  // **Payable Setter
        {
            _payable = payable;
            return _payable;
        }
       
        public decimal Payable                  // **Payable Getter
        {
            get { return _payable; }
        }
        
        public string Name
        {
            get { return _name; }
        }

        public string SSN
        {
            get { return _ssn; }
        }
         
       

    }
}
