using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowManager
{
    internal class Invoice:IPayable
    {   
        private string _partNumber;
        private string _partDestription;
        private int _units;
        private decimal _unitCost;
        private string _stringUC;
        private decimal _invoiceTotal;
        private string _stringInvTot;
        private int _invNum1;
        private int _invNum2;
        private int _invNum3;
        private string _stringInvNum;
       
        public Invoice(Random r, string partNumber, string partDescription, int units, decimal unitCost)
        {
            _partNumber = partNumber;
            _partDestription = partDescription;
            _units = units;
            _unitCost = unitCost;
            _invoiceTotal = _units * _unitCost;
            _invNum1 = r.Next(1000,10000);
            _invNum2 = r.Next(1000,10000);
            _invNum3 = r.Next(1000, 10000);
            _stringInvNum = _invNum1+"-"+_invNum2+"-"+_invNum3;
            _stringInvTot = string.Format("{0:C}", _invoiceTotal);
            _stringUC = string.Format("{0:C}",_unitCost);
           
        }
        public Ledger.ledgerType ledgerType
        {
            get { return Ledger.ledgerType.Invoice; }

        } 
        public decimal Payable
        {
            get { return _invoiceTotal; }

        }
       
        public override string ToString()
        {
           return
            "\n\tInvoice No.        " + _stringInvNum + "\n" +
            "\tPart No.           " + _partNumber + "\n" +
            "\tPart Description   " + _partDestription + "\n" +
            "\tUnit Price:        " + _stringUC + "\n" +
            "\tQuantity:          " + _units + "\n" +
            "\tInvoice Payable:   " + _stringInvTot;
        }
    }
}
