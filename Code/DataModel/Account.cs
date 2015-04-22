using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public enum OOP2_SGetAccounts
    {
        SPGetAccounts_AccountNo = 0,
        SPGetAccounts_AccountType,
        SPGetAccounts_SortCode,
        SPGetAccounts_InitialBalance,
        SPGetAccounts_CurrentBalance,
        SPGetAccounts_OverDraftLimit,
        SPGetAccounts_StudentID
    }


    //this class is used in order to model out data in the database
    public class Account
    {
        // properties
        public int AccountNo { get; set; }
        public string AccountType { get; set; }        
        public int SortCode { get; set; }
        public int InitialBalance { get; set; }
        public string InitBal // string version of the intial balance with currency sign
        {
            get
            {
                decimal initBala = (decimal)InitialBalance / 100;
                return string.Format("{0:c}", initBala);
            } 
        }
        public int CurrentBalance { get; set; }
        public string CurtBal // string version of the current balance with currency sign
        {
            get
            {
                decimal curBala = (decimal)CurrentBalance / 100;
                return string.Format("{0:c}", curBala);
            }
        }
        public int OverDraftLimit { get; set; }
        public string OverDraft // string version of the overdraft limit with currency sign
        {
            get
            {
                decimal ovaDft = (decimal)OverDraftLimit / 100;
                return string.Format("{0:c}", ovaDft);
            }
        }
        public int StudentID { get; set; }

        // default constructor
        public Account()
        {
        }

        // constructor
        public Account(int accNo, string accType, int sortCode, int initBal, int currentBal, int overDraft, int studId)
        {
            AccountNo = accNo;
            AccountType = accType;
            SortCode = sortCode;
            InitialBalance = initBal;
            CurrentBalance = currentBal;
            OverDraftLimit = overDraft;
            StudentID = studId;
        }
    }
}
