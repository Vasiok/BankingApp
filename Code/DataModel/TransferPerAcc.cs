using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public enum OOP2_SGetTransferPerAcc
    {
        SPGetTransferPerAcc_AccountNumber = 0,
        SPGetTransferPerAcc_TransactionNum,
        SPGetTransferPerAcc_TransactionType,
        SPGetTransferPerAcc_Date,
        SPGetTransferPerAcc_TransactionAmount,
        SPGetTransferPerAcc_DestinationSortCode,
        SPGetTransferPerAcc_DestinationAccNo,
        SPGetTransferPerAcc_TransferDescription
    }

    // Class that represents transfers for a particular account
    public class TransferPerAcc
    {
        public int AccountNumber { get; set; }
        public int TransactionNum { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime Date { get; set; }
        public int TransactionAmount { get; set; }
        public string TransAmt // string version of the Transaction Amount
        {
            get
            {
                decimal amt = (decimal)TransactionAmount / 100;

                return string.Format("{0:c}", amt);
            }
        }
        public string DestinationSortCode { get; set; }
        public int DestinationAccNo { get; set; }
        public string TransferDescription { get; set; }

        // constructor
        public TransferPerAcc(int acc, int tNum, TransactionType tType, DateTime daTe, int transAmt, string desSortCode, int desAcc, string descrip)
        {
            AccountNumber = acc;
            TransactionNum = tNum;
            TransactionType = tType;
            Date = daTe;
            TransactionAmount = transAmt;
            DestinationSortCode = desSortCode;
            DestinationAccNo = desAcc;
            TransferDescription = descrip;
        }
    }
}
