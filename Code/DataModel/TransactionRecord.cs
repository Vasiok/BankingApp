using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{

    public enum TransactionType
    {
        debit, 
        credit
    }

    public enum OOP2_SGTransations
    {
        SPGetTransaction_TransactionID = 0,
        SPGetTransaction_TransactionType,
        SPGetAccounts_AccountNumebr,
        SPGetTransaction_Date,
        SPGetTransaction_TransactionAmmount,
        SPGetTransaction_Balance        
    }


    //Class that represents transactions
    public class TransactionRecord
    {
        public int TransactionID { get; set; }
        public TransactionType TransactionType { get; set; }
        public int AccountNumber { get; set; }
        public DateTime Date { get; set; }
        public int TransactionAmmount { get; set; }
        public string TransAmt // string version of the Transaction Amount with currency sign
        {
            get
            {
                decimal ta = (decimal)TransactionAmmount / 100;

                return string.Format("{0:c}", ta);
            }
        }
        public int Balance { get; set; }
        public string CurrBal // string version of the Balance with currency sign
        {
            get
            {
                decimal currBal = (decimal)Balance / 100;

                return string.Format("{0:c}", currBal);
            }
        }

         // default constructor
        public TransactionRecord()
        {
        }

        public TransactionRecord(int id, TransactionType transType, int accNum, DateTime date, int transAmt, int bal)
        {
            TransactionID = id;
            TransactionType = transType;
            AccountNumber = accNum;
            Date = date;
            TransactionAmmount = transAmt;
            Balance = bal;
        }
    }

}
