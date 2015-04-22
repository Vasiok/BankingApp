using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// adding using directives
using DAL;
using DataModel;

namespace BLL
{
    public class BLLTransactionManager
    {


        //Method to facilitate the deposit of money
        public bool DepositMonies(int accNum, int newBal, string accType)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();

            bool retVal = false;

            retVal = dalTransMngr.DepositMonies(accNum, newBal, accType);

            return retVal;
        }//end of DepositMonies


        //Method that deals with withdrawing the money from the account
        public bool WithdrawMonies(int accNum, int newBal, string accType)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();

            bool retVal = false;

            retVal = dalTransMngr.DepositMonies(accNum, newBal, accType);

            return retVal;
        }//end of WithdrawMonies




        // method to create a new transaction
        public bool CreateTransaction(TransactionRecord tr, out int transID)
        {
            DALTransactionManager manager = new DALTransactionManager();

            bool retVal = false;

            retVal = manager.CreateTransaction(tr, out transID);

            return retVal;
        }//end of CreateTransaction


        // Method to get recepient Name
        public String GetRecepientName(int studId)
        {
            DALTransactionManager manager = new DALTransactionManager();

            string recepientName = manager.GetStudentName(studId);

            return recepientName;
        }//end of GetRecepientName



        // Method to create transfer record in bll
        public bool CreateTransfer(TransferRecord transfer)
        {
            bool retVal = false;

            DALTransactionManager manager = new DALTransactionManager();

            retVal = manager.CreateTransferRecord(transfer);

            return retVal;
        }//end of CreateTransfer



        //Method will return all the transactions for a ccount number passed in
        public List<TransactionRecord> GetTransactionDetailsAsList(int accNum)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();
            List<TransactionRecord> transDetailsList = dalTransMngr.GetTransactionDetailsAsList();
            try
            {
                // This line will only include transactions that match the account number selected
                transDetailsList = transDetailsList.Where(Transaction => Transaction.AccountNumber == accNum).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return transDetailsList;
        }//end of GetTransactionDetailsAsList


        //method will return onlt transactions that were created as a credit
        public List<TransactionRecord> GetCreditTransactionsAsList(int accNum)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();
            List<TransactionRecord> transDetailsList = dalTransMngr.GetTransactionDetailsAsList();
           
            try
            {
                // This line will onyl include transactions that match credit transaction type
                transDetailsList = transDetailsList.Where(Transaction => Transaction.TransactionType == TransactionType.credit && Transaction.AccountNumber == accNum).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return transDetailsList;
        }//end of GetCreditTransactionsAsList



        //method will return transactions that are debite for particular account
        public List<TransactionRecord> GetDebitTransactionsAsList(int accNum)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();
            List<TransactionRecord> transDetailsList = dalTransMngr.GetTransactionDetailsAsList();

            try
            {
                // This line will only include transactions that match dedit transaction type
                transDetailsList = transDetailsList.Where(Transaction => Transaction.TransactionType == TransactionType.debit && Transaction.AccountNumber == accNum).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return transDetailsList;
        }//end of GetDebitTransactionsAsList


        //Method will return only transactions that were created as a part of transfer
        public List<TransferPerAcc> GetTransactionsAndTransfersAsList(int accNum)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();
            List<TransferPerAcc> transList = dalTransMngr.GetTransactionsAndTransfersAsList();

            try
            {
                // This line will check the acc for each item on the list
                transList = transList.Where(TransferPerAcc => TransferPerAcc.AccountNumber== accNum).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return transList;
        }//end of GetTransactionsAndTransfersAsList



        /***************************************************************************************************
         *************************************************************************************************** 
         * Following methods are created only for transfer option in order to accomodate transaction scope *
         ***************************************************************************************************
         ***************************************************************************************************/
        public bool DepositMoniesTransactionScope(int accNum, int newBal, string accType)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();

            bool retVal = false;

            //retVal = dalTransMngr.DepositMonies(accNum, newBal, accType);
            retVal = dalTransMngr.DepositMoniesTransactionScope(accNum, newBal, accType);

            return retVal;
        }//end of DepositMoniesTransactionScope

        public bool WithdrawMoniesTransactionScope(int accNum, int newBal, string accType)
        {
            DALTransactionManager dalTransMngr = new DALTransactionManager();

            bool retVal = false;

            //retVal = dalTransMngr.DepositMonies(accNum, newBal, accType);
            retVal = dalTransMngr.DepositMoniesTransactionScope(accNum, newBal, accType);

            return retVal;
        }//end of WithdrawMoniesTransactionScope


        // method to create a new transaction
        public bool CreateTransactionTransactionScope(TransactionRecord tr, out int transID)
        {
            DALTransactionManager manager = new DALTransactionManager();

            bool retVal = false;

            //retVal = manager.CreateTransaction(tr, out transID);
            retVal = manager.CreateTransactionTransactionScope(tr, out transID);

            return retVal;
        }// end of CreateTransactionTransactionScope

        public bool CreateTransferTransactionScope(TransferRecord transfer)
        {
            bool retVal = false;

            DALTransactionManager manager = new DALTransactionManager();

            //retVal = manager.CreateTransferRecord(transfer);
            retVal = manager.CreateTransferRecordTransactionScope(transfer);

            return retVal;
        }//end of CreateTransferTransactionScope

    }
}
