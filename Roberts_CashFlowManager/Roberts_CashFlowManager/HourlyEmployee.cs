using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowManager
{
    internal class HourlyEmployee:Employee
    {
        private decimal _hourlyWage;
        private string _stringhourlyWage;
        private decimal _overtimeWage;

        private decimal _straightPay;
        private decimal _overtimePay;
        private int _totalHours;
        private int _overtime;
        private decimal _totalPay;
        private string _stringTotPay;

        public HourlyEmployee(string firstName, string lastName, string ssn, decimal hourlyWage, int hoursWorked):base(firstName,lastName,ssn)
        {
            _hourlyWage = hourlyWage;
            _overtimeWage = _hourlyWage * 1.5M;

            if (hoursWorked <= 40)
            {
                _totalHours = hoursWorked;
                _totalPay = _totalHours * _hourlyWage;
            }
            else if (hoursWorked > 40)
            {
                _totalHours = hoursWorked;
                _overtime = _totalHours - 40;

                _straightPay = _hourlyWage * 40;
                _overtimePay = _overtimeWage * _overtime;
             
                 _totalPay = _straightPay + _overtimePay;
              
            }
            _stringhourlyWage = string.Format("{0:C}",_hourlyWage);
            _stringTotPay = string.Format("{0:C}",_totalPay);
            base.setPayable(_totalPay);
            base.setLedgerType(Ledger.ledgerType.Hourly);
        }
      
        public override string ToString()
        {
            return
                "\n\tHourly Employee:  " + "\n"+
                "\tName:             " + Name + "\n"+
                "\tSSN:              " + SSN + "\n"+
                "\tHourly Wage:      " + _stringhourlyWage + "\n"+
                "\tHours Worked:     " + _totalHours + "\n"+
                "\tEmployee Payable: " + _stringTotPay;
        }
        
    }
}
