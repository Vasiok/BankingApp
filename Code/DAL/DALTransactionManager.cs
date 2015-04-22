using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// adding using directives
using System.Configuration;
using DataModel;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALTransactionManager
    {
        //pulling connection string from database
        private string connectionString = ConfigurationManager.ConnectionStrings["dbConString"].ConnectionString;

        //constants used for fileds in one of the methods where we only get a part of the row and the whole row so need indicate
        //their position in resulting data set
        private const int fNamePos = 0;
        private const int lNamePos = 1;



        /*
         * All methods use stored procedures created for our database
         */

        // method to depoist money, and return a bool on wether it passed or failed
        public bool DepositMonies(int accNum, int newBal, string accType)
        {
            bool retVal = false;

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spDeposit", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter email = new SqlParameter("@newbalance", newBal);
                    cmd.Parameters.Add(email);

                    SqlParameter accountNum = new SqlParameter("@accNum", accNum);
                    cmd.Parameters.Add(accountNum);

                    SqlParameter accountType = new SqlParameter("@accType", accType);
                    cmd.Parameters.Add(accountType);

                    cxn.Open();

                    int i = cmd.ExecuteNonQuery();

                    cxn.Close();

                    if (i > 0)
                    {
                        retVal = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retVal;
        } // end of DepositMonies method




        // method to withdraw money, and return a bool on wether it passed or failed
        public bool WithdrawMonies(int accNum, int newBal, string accType)
        {
            bool retVal = false;

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spWithdraw", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter email = new SqlParameter("@newbalance", newBal);
                    cmd.Parameters.Add(email);

                    SqlParameter accountNum = new SqlParameter("@accNum", accNum);
                    cmd.Parameters.Add(accountNum);

                    SqlParameter accountType = new SqlParameter("@accType", accType);
                    cmd.Parameters.Add(accountType);

                    cxn.Open();

                    int i = cmd.ExecuteNonQuery();

                    cxn.Close();

                    if (i > 0)
                    {
                        retVal = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retVal;
        } // end of WithdrawMonies method


        // Method to create new transaction
        public bool CreateTransaction(TransactionRecord trans,  out int transactionId)
        {
            bool retval = false;
            transactionId = 0;

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spCreateTransaction", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter transType = new SqlParameter("@TransType", trans.TransactionType.ToString() );
                    cmd.Parameters.Add(transType);

                    SqlParameter accountNum = new SqlParameter("@AccNo", trans.AccountNumber);
                    cmd.Parameters.Add(accountNum);

                    SqlParameter dateTime = new SqlParameter("@Date", trans.Date);
                    cmd.Parameters.Add(dateTime);

                    SqlParameter transAmmount = new SqlParameter("@Ammount", trans.TransactionAmmount);
                    cmd.Parameters.Add(transAmmount);

                    SqlParameter transBalance = new SqlParameter("@Balance", trans.Balance);
                    cmd.Parameters.Add(transBalance);

                    SqlParameter transIDOut = new SqlParameter("@TransactionID", SqlDbType.Int);
                    transIDOut.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(transIDOut);

                    cxn.Open();


                    int i = cmd.ExecuteNonQuery();

                    cxn.Close();
                    transactionId = Convert.ToInt32(transIDOut.Value);

                    if (i > 0)
                    {
                        retval = true;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return retval;
        } // End of create CreateTransaction method



        //Method to get student name usgin studentId
        public string GetStudentName(int studentId)
        {
            string recepientName = "";
            string fName;
            string lName;

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetStudentName", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sID = new SqlParameter("@StudentID", studentId);
                    cmd.Parameters.Add(sID);

                    cxn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        fName = reader.GetValue(fNamePos).ToString();
                        lName = reader.GetValue(lNamePos).ToString();

                        recepientName = fName + " " + lName;
                    }
                    reader.Close();
                    cxn.Close();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return recepientName;

        } // End of GetStudentName




        // Method to create transfer record
        public bool CreateTransferRecord(TransferRecord transfer)
        {
            bool retVal = false;

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spCreateTransferRecord", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter recepientName = new SqlParameter("@RecName", transfer.RecepientName);
                    cmd.Parameters.Add(recepientName);

                    SqlParameter debiteAcc = new SqlParameter("@DebitedAcc", transfer.DebitedAccount);
                    cmd.Parameters.Add(debiteAcc);

                    SqlParameter transNumber = new SqlParameter("@TransactionNum", transfer.TransactionNumber);
                    cmd.Parameters.Add(transNumber);

                    SqlParameter destinationSCode = new SqlParameter("@DesctinationSCode", transfer.DestinationSortCode);
                    cmd.Parameters.Add(destinationSCode);

                    SqlParameter destinationAcc = new SqlParameter("@DestinationAccNo", transfer.DestinationAccNo);
                    cmd.Parameters.Add(destinationAcc);

                    SqlParameter transferAmmount = new SqlParameter("@TransferAmmount", transfer.TransferAmmount);
                    cmd.Parameters.Add(transferAmmount);

                    SqlParameter date = new SqlParameter("@Date", transfer.TransferDate);
                    cmd.Parameters.Add(date);

                    SqlParameter description = new SqlParameter("@Description", transfer.TransferDescription);
                    cmd.Parameters.Add(description);

                    cxn.Open();

                    int i = 0;

                    i = cmd.ExecuteNonQuery();

                    cxn.Close();

                    retVal = true;

                    //if (i > 0)
                    //{
                    //    retVal = true;
                    //}

                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


            return retVal;
        }//End of CreateTransferRecord



        // getting transaction information out 
        public List<TransactionRecord> GetTransactionDetailsAsList()
        {
            // memory management technique used here where we create olny a list of 10
            // elements so it doesnt take more memory. If list has more then 10 members it will use more memory
            List<TransactionRecord> TransDetailsList = new List<TransactionRecord>(10);

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetTransactionsDetails", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cxn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int transactionID = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGTransations.SPGetTransaction_TransactionID))); 
                        TransactionType transtType = (TransactionType)Enum.Parse(typeof(TransactionType), reader.GetValue(Convert.ToInt32(OOP2_SGTransations.SPGetTransaction_TransactionType)).ToString());
                        int accNum = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGTransations.SPGetAccounts_AccountNumebr)));
                        DateTime date = Convert.ToDateTime(reader.GetValue(Convert.ToInt32(OOP2_SGTransations.SPGetTransaction_Date)));
                        int transAmt = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGTransations.SPGetTransaction_TransactionAmmount)));
                        int currentBal = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGTransations.SPGetTransaction_Balance)));

                        TransactionRecord trans = new TransactionRecord(transactionID, transtType, accNum, date, transAmt, currentBal);

                        TransDetailsList.Add(trans);
                    }

                    reader.Close();
                    cxn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return TransDetailsList;
        }//End of GetTransactionDetailsAsList



        // getting transaction information out to transaction display
        public List<TransferPerAcc> GetTransactionsAndTransfersAsList()
        {
            // memory management technique used here
            List<TransferPerAcc> TransList = new List<TransferPerAcc>(10);

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetTransfers", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cxn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int accNum = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_AccountNumber)));
                        int transNum = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_TransactionNum)));
                        TransactionType transtType = (TransactionType)Enum.Parse(typeof(TransactionType), reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_TransactionType)).ToString());
                        DateTime date = Convert.ToDateTime(reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_Date)));
                        int transAmt = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_TransactionAmount)));
                        string desSort = reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_DestinationSortCode)).ToString();
                        int desAcc = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_DestinationAccNo)));
                        string description = reader.GetValue(Convert.ToInt32(OOP2_SGetTransferPerAcc.SPGetTransferPerAcc_TransferDescription)).ToString();

                        TransferPerAcc trans = new TransferPerAcc(accNum, transNum, transtType, date, transAmt, desSort, desAcc, description);

                        TransList.Add(trans);
                    }

                    reader.Close();
                    cxn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return TransList;
        }//End of GetTransactionsAndTransfersAsAList



        /***********************************************************************************
         *********************************************************************************** 
         * Following is only created for transfer in order to accomodate transaction scope *
         ***********************************************************************************
         ***********************************************************************************/


        // Deposit with transaction scope
        public bool DepositMoniesTransactionScope(int accNum, int newBal, string accType)
        {
            bool retVal = false;

            try
            {
                SqlConnection cxn = new SqlConnection(connectionString);
                
                    SqlCommand cmd = new SqlCommand("spDeposit", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter email = new SqlParameter("@newbalance", newBal);
                    cmd.Parameters.Add(email);

                    SqlParameter accountNum = new SqlParameter("@accNum", accNum);
                    cmd.Parameters.Add(accountNum);

                    SqlParameter accountType = new SqlParameter("@accType", accType);
                    cmd.Parameters.Add(accountType);

                    cxn.Open();

                    int i = cmd.ExecuteNonQuery();

                 //   cxn.Close();

                    if (i > 0)
                    {
                        retVal = true;
                    }
                }            
            catch (Exception ex)
            {

                throw ex;
            }
            return retVal;
        } // end of DepositMoniesTransactionScope method



        // method to withdraw money, and return a bool on wether it passed or failed
        public bool WithdrawMoniesTransactionScope(int accNum, int newBal, string accType)
        {
            bool retVal = false;

            try
            {
                SqlConnection cxn = new SqlConnection(connectionString);
                
                    SqlCommand cmd = new SqlCommand("spWithdraw", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter email = new SqlParameter("@newbalance", newBal);
                    cmd.Parameters.Add(email);

                    SqlParameter accountNum = new SqlParameter("@accNum", accNum);
                    cmd.Parameters.Add(accountNum);

                    SqlParameter accountType = new SqlParameter("@accType", accType);
                    cmd.Parameters.Add(accountType);

                    cxn.Open();

                    int i = cmd.ExecuteNonQuery();

                    //cxn.Close();

                    if (i > 0)
                    {
                        retVal = true;
                    }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retVal;
        } // end of WithdrawMoniesTransactionScope method


        // Method to create new transaction
        public bool CreateTransactionTransactionScope(TransactionRecord trans, out int transactionId)
        {
            bool retval = false;
            transactionId = 0;

            try
            {
                SqlConnection cxn = new SqlConnection(connectionString);
                
                    SqlCommand cmd = new SqlCommand("spCreateTransaction", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter transType = new SqlParameter("@TransType", trans.TransactionType.ToString());
                    cmd.Parameters.Add(transType);

                    SqlParameter accountNum = new SqlParameter("@AccNo", trans.AccountNumber);
                    cmd.Parameters.Add(accountNum);

                    SqlParameter dateTime = new SqlParameter("@Date", trans.Date);
                    cmd.Parameters.Add(dateTime);

                    SqlParameter transAmmount = new SqlParameter("@Ammount", trans.TransactionAmmount);
                    cmd.Parameters.Add(transAmmount);

                    SqlParameter transBalance = new SqlParameter("@Balance", trans.Balance);
                    cmd.Parameters.Add(transBalance);

                    SqlParameter transIDOut = new SqlParameter("@TransactionID", SqlDbType.Int);
                    transIDOut.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(transIDOut);

                    cxn.Open();


                    int i = cmd.ExecuteNonQuery();

                    transactionId = Convert.ToInt32(transIDOut.Value);

                    if (i > 0)
                    {
                        retval = true;

                        //transactionId = Convert.ToInt32(transIDOut.Value);
                    }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retval;
        } // End of create CreateTransactionTransactionScope method


        // Method to create transfer record
        public bool CreateTransferRecordTransactionScope(TransferRecord transfer)
        {
            bool retVal = false;

            try
            {
                    SqlConnection cxn = new SqlConnection(connectionString);
                
                    SqlCommand cmd = new SqlCommand("spCreateTransferRecord", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter recepientName = new SqlParameter("@RecName", transfer.RecepientName);
                    cmd.Parameters.Add(recepientName);

                    SqlParameter debiteAcc = new SqlParameter("@DebitedAcc", transfer.DebitedAccount);
                    cmd.Parameters.Add(debiteAcc);

                    SqlParameter transNumber = new SqlParameter("@TransactionNum", transfer.TransactionNumber);
                    cmd.Parameters.Add(transNumber);

                    SqlParameter destinationSCode = new SqlParameter("@DesctinationSCode", transfer.DestinationSortCode);
                    cmd.Parameters.Add(destinationSCode);

                    SqlParameter destinationAcc = new SqlParameter("@DestinationAccNo", transfer.DestinationAccNo);
                    cmd.Parameters.Add(destinationAcc);

                    SqlParameter transferAmmount = new SqlParameter("@TransferAmmount", transfer.TransferAmmount);
                    cmd.Parameters.Add(transferAmmount);

                    SqlParameter date = new SqlParameter("@Date", transfer.TransferDate);
                    cmd.Parameters.Add(date);

                    SqlParameter description = new SqlParameter("@Description", transfer.TransferDescription);
                    cmd.Parameters.Add(description);

                    cxn.Open();

                    int i = 0;

                    i = cmd.ExecuteNonQuery();

                    retVal = true;

                    //if (i > 0)
                    //{
                    //    retVal = true;
                    //}

                
            }
            catch (Exception ex)
            {

                throw ex;
            }



            return retVal;
        }//End of CreateTransferRecordTransactionScope

    }
}
