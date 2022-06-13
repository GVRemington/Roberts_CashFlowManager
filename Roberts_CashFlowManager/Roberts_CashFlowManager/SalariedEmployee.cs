using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowManager
{
    internal class SalariedEmployee:Employee
    {
        private decimal _weeklySalary;
        private string _stringSalary;
       
        public SalariedEmployee(string firstName, string lastName, string ssn, decimal weeklySalary) : base(firstName, lastName, ssn)
        { 
            _weeklySalary = weeklySalary;
            _stringSalary = string.Format("{0:C}", _weeklySalary);
            base.setPayable(_weeklySalary);
            base.setLedgerType(Ledger.ledgerType.Salaried);
        }
        
        public override string ToString()
        {
            return
                "\n\tSalaried Employee:  \n" +
                "\tName:             " + Name + "\n"  +
                "\tSSN:              " + SSN + "\n" +
                "\tWeekly Salary:    " + _stringSalary + "\n" +
                "\tEmployee Payable: " + _stringSalary;
        }
    }
}
