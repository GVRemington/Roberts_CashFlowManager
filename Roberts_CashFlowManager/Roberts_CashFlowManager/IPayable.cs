using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowManager
{
    internal interface IPayable
    {
        public Ledger.ledgerType ledgerType { get; }
       

        public decimal Payable { get; }
    }
}
