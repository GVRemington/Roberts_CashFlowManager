using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roberts_CashFlowManager
{
    internal class Ledger
    {
        private decimal _totInvPayables = 0;
        private decimal _totHourPayables = 0;
        private decimal _totSalPayables = 0;
        private decimal _totPayables=0;
        //private string _stringTotPay;

        public enum ledgerType
        {
            Hourly,
            Salaried,
            Invoice
        }
        public string Menu()
        {
            return
             "\n\tNow Listen, I'm a busy Gal," +
             "\n\tI don't have time to idiot proof this" +
             "\n\tSo pay attention! And Follow Directions!" +
             "\n\t(this is the only user error checks I had time to do hahahahaha)\n"+
             "\n\tMake Selection: " +
             "\n\t1: Invoice Item " +
             "\n\t2: Hourly Employee " +
             "\n\t3: Salaried Employee " +
             "\n\t4: Exit and Print Ledger ";

        }
        public string Menu2()
        {
            return
             "\n\tRemember! Follow Directions!!\n" +
             "\n\tMake Selection: " +
             "\n\t1: Invoice Item " +
             "\n\t2: Hourly Employee " +
             "\n\t3: Salaried Employee " +
             "\n\t4: Exit and Print Ledger ";
        }

        public decimal setInv(decimal invPay)                       // **Inv Setter
        {
            _totInvPayables += invPay;
            setTotalPayables(invPay);
            return _totInvPayables;
        }
        public string getInv
        { get { return string.Format("{0:C}", _totInvPayables); } } // **InvPay Getter


        public decimal setHour(decimal hourPay)                   // **Hour Setter
        {
            _totHourPayables += hourPay;
            setTotalPayables(hourPay);
            return _totInvPayables;
        }
        public string getHour
        { get { return string.Format("{0:C}", _totHourPayables); } } // **Hourly Getter


        public decimal setSal(decimal salPay)                       // **Sal Setter
        {
            _totSalPayables += salPay;
            setTotalPayables(salPay);
            return _totInvPayables;
        }
        public string getSal
        { get { return string.Format("{0:C}", _totSalPayables); } } // **Salary Getter


        public string setTotalPayables(decimal payable)                          // **Total Payables Setter
        {
            _totPayables += payable;
            return string.Format("{0:C}", _totPayables);
        }
        public string getTotalPayables
        { get { return string.Format("{0:C}", _totPayables); } } // **Total Payables Getter

        public string report()
        {
            return
              "\n\t**Weekly Ledger Payables Total**:   " + getTotalPayables +
              "\n\n\t**Category BreakDown:   " +
              "\n\t**Invoices:             " + getInv +
              "\n\t**Salaried PayRoll:     " + getSal +
              "\n\t**Hourly PayRoll:       " + getHour + "\n\n"; 
        }
    }
}
