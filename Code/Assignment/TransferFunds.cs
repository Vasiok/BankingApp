using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using System.Configuration;
using BLL;
using System.Text.RegularExpressions;
using System.Transactions;



namespace Assignment
{
    public partial class TransferFunds : Form
    {
        public Student Stundet { get; set; }

        public Account SourceAccount { get; set; }

        public Account DestinationAccount { get; set; }

        public string RecepientName { get; set; }
        
        public bool ExternalTransfer { get; set; }



        // configurations for extrernal transfers
        private string outSortCode = ConfigurationManager.AppSettings["sortCode"].ToString();
        private string esternalTransferAcc = ConfigurationManager.AppSettings["ExternalAccountNumber"].ToString();
        private string externalName = ConfigurationManager.AppSettings["ExternalAccName"].ToString();


        // Constructor
        public TransferFunds(Student stud, Account acc)
        {
            InitializeComponent();

            this.SourceAccount = acc;
            this.Stundet = stud;
            txtAccountNumber.Text = SourceAccount.AccountNo.ToString();
            txtDate.Text = DateTime.Now.ToString();

        }//end of constructor

        
        //back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }//end of back button

      
        //this will set account details that are needed to create an external transfer
        private void btnExternal_Click(object sender, EventArgs e)
        {
            BLLAccountManager manager = new BLLAccountManager();
            DestinationAccount = manager.GetAccountRecord(int.Parse(esternalTransferAcc));
            txtAccOutNumber.Text = esternalTransferAcc;
            txtDestinationSortCode.Text = outSortCode;
            txtRecepientName.Text = externalName;
            ExternalTransfer = true;
            
        }//end of external


        //button will open new window to select destination account
        private void btnInternal_Click(object sender, EventArgs e)
        {            
            //FindAccount fAcc = new FindAccount(this);
            using (FindAccount fAcc = new FindAccount())
            {
                //subscribing to the event here
                fAcc.OnAccountSelected += fAcc_OnAccountSelected;

                fAcc.ShowDialog();
                
            }
            ExternalTransfer = false;
        }//end of internal account search


        //event handler for internal account selected
        void fAcc_OnAccountSelected(object sender, AccountArgs e)
        {
            DestinationAccount = e.Account;

            BLLTransactionManager manager = new BLLTransactionManager();

            RecepientName = manager.GetRecepientName(DestinationAccount.StudentID);

            txtRecepientName.Text = RecepientName;
            txtAccOutNumber.Text = DestinationAccount.AccountNo.ToString();
            txtDestinationSortCode.Text = DestinationAccount.SortCode.ToString();
        }//end of event handler


        //transfer button click event to transfer money from one account to aother
        private void btnTransfer_Click(object sender, EventArgs e)
        {

            //Note that we are creatinf a transaction here in order to make sure that if something goes
            //wrong in a middle of transfering money our database stays in consistent state.
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    BLLTransactionManager manager = new BLLTransactionManager();

                    //Dealing with getting monney from one acc first
                    int transferAmmount = MoneyTransformer.TransformMoney(txtAmmount.Text);

                    int debitedAccNewBal = SourceAccount.CurrentBalance - transferAmmount;

                    // new balance for credited account
                    int creditedAccNewBal = DestinationAccount.CurrentBalance + transferAmmount;

                    bool transferPossible = false;

                    // setting the possibility of transaction to true
                    if (SourceAccount.CurrentBalance >= transferAmmount)
                    {
                        transferPossible = true;
                    }
                    else
                    {
                        MessageBox.Show("Not Enough funds");
                    }


                    if (transferPossible)
                    {
                        //testing to make sure saving account doesnt transfer to external
                        if (SourceAccount.AccountType.Equals("saving"))
                        {
                            if (!ExternalTransfer)
                            {
                                manager.WithdrawMonies(SourceAccount.AccountNo, debitedAccNewBal, SourceAccount.AccountType);


                                //This code can be uncommented in order to show that database doesnt change if there was an error or exceprion somewhere
                                //Exception ex = new Exception();
                                //if (ex != null)
                                //{
                                //    MessageBox.Show("Opps SOMETHING WENT WRONG HERE !!!");
                                //}
                                //throw ex;

                                manager.DepositMonies(DestinationAccount.AccountNo, creditedAccNewBal, DestinationAccount.AccountType);

                                int debitTransNo = 0;
                                int creditTransNo = 0;

                                //setting and creating transaction for debit
                                TransactionRecord debitTrans = new TransactionRecord();
                                debitTrans.AccountNumber = SourceAccount.AccountNo;
                                debitTrans.TransactionType = TransactionType.debit;
                                debitTrans.Date = DateTime.Now;
                                debitTrans.TransactionAmmount = transferAmmount;
                                debitTrans.Balance = debitedAccNewBal;
                                //creating a transaction for debited account
                                manager.CreateTransaction(debitTrans, out debitTransNo);


                                //setting and creating transaction for credit
                                TransactionRecord creditTrans = new TransactionRecord();
                                creditTrans.AccountNumber = DestinationAccount.AccountNo;
                                creditTrans.TransactionType = TransactionType.credit;
                                creditTrans.Date = DateTime.Now;
                                creditTrans.TransactionAmmount = transferAmmount;
                                creditTrans.Balance = creditedAccNewBal;
                                //creating a transaction for credit account
                                manager.CreateTransaction(creditTrans, out creditTransNo);


                                //Create Transfer Record object first
                                TransferRecord record = new TransferRecord();
                                record.RecepientName = txtRecepientName.Text;
                                record.DebitedAccount = int.Parse(txtAccountNumber.Text);
                                //NOTE here I am setting the record transaction number to the number created for debited account
                                record.TransactionNumber = debitTransNo;
                                record.DestinationSortCode = txtDestinationSortCode.Text;
                                record.DestinationAccNo = int.Parse(txtAccOutNumber.Text);
                                record.TransferAmmount = transferAmmount;
                                record.TransferDate = DateTime.Now;
                                record.TransferDescription = rtfDescription.Text;


                                bool success = false;
                                //creating new transfer record                        
                                success = manager.CreateTransfer(record);
                                transaction.Complete();
                                transaction.Dispose();

                                if (success)
                                {
                                    MessageBox.Show("Transfer Successfull");
                                }  
                            }
                            else
                            {
                                MessageBox.Show("Cant transfer to an external account from saving account\nOnly internal transfers are allowed");
                            }
                        }
                        else
                        {
                            manager.WithdrawMonies(SourceAccount.AccountNo, debitedAccNewBal, SourceAccount.AccountType);


                            //This code can be uncommented in order to show that database doesnt change if there was an error or exceprion somewhere
                            //Exception ex = new Exception();
                            //if (ex != null)
                            //{
                            //    MessageBox.Show("Opps SOMETHING WENT WRONG HERE !!!");
                            //}
                            //throw ex;

                            manager.DepositMonies(DestinationAccount.AccountNo, creditedAccNewBal, DestinationAccount.AccountType);

                            int debitTransNo = 0;
                            int creditTransNo = 0;

                            //setting and creating transaction for debit
                            TransactionRecord debitTrans = new TransactionRecord();
                            debitTrans.AccountNumber = SourceAccount.AccountNo;
                            debitTrans.TransactionType = TransactionType.debit;
                            debitTrans.Date = DateTime.Now;
                            debitTrans.TransactionAmmount = transferAmmount;
                            debitTrans.Balance = debitedAccNewBal;
                            //creating a transaction for debited account
                            manager.CreateTransaction(debitTrans, out debitTransNo);


                            //setting and creating transaction for credit
                            TransactionRecord creditTrans = new TransactionRecord();
                            creditTrans.AccountNumber = DestinationAccount.AccountNo;
                            creditTrans.TransactionType = TransactionType.credit;
                            creditTrans.Date = DateTime.Now;
                            creditTrans.TransactionAmmount = transferAmmount;
                            creditTrans.Balance = creditedAccNewBal;
                            //creating a transaction for credit account
                            manager.CreateTransaction(creditTrans, out creditTransNo);


                            //Create Transfer Record object first
                            TransferRecord record = new TransferRecord();
                            record.RecepientName = txtRecepientName.Text;
                            record.DebitedAccount = int.Parse(txtAccountNumber.Text);
                            //NOTE here I am setting the record transaction number to the number created for debited account
                            record.TransactionNumber = debitTransNo;
                            record.DestinationSortCode = txtDestinationSortCode.Text;
                            record.DestinationAccNo = int.Parse(txtAccOutNumber.Text);
                            record.TransferAmmount = transferAmmount;
                            record.TransferDate = DateTime.Now;
                            record.TransferDescription = rtfDescription.Text;


                            bool success = false;
                            //creating new transfer record                        
                            success = manager.CreateTransfer(record);
                            transaction.Complete();
                            transaction.Dispose();

                            if (success)
                            {
                                MessageBox.Show("Transfer Successfull");
                            }  
                        }
                    }
                }                
                catch (TransactionException ex)
                {

                    transaction.Dispose();
                    MessageBox.Show("OOpppps somethinge went WRONG there");
                    throw ex;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No money were transfered");
                }
            }
        }//End of TransferClick


        //this is just get money from an external account
        private void btnExternalSource_Click(object sender, EventArgs e)
        {
            BLLAccountManager manager = new BLLAccountManager();
            txtAccountNumber.Text = esternalTransferAcc;
            SourceAccount = manager.GetAccountRecord(int.Parse(esternalTransferAcc));
        }//end of external




        /*************************
         * Validatin the fields  *
         *************************/
        private void txtAmmount_Validating(object sender, CancelEventArgs e)
        {
            string withdraeAmmount = txtAmmount.Text;
            string usrRgExp = Expressions.Money;

            if (!Regex.IsMatch(withdraeAmmount, usrRgExp))
            {
                errTransferAmmount.SetError(txtAmmount, "Please enter a valid amount of money, eg 0.00.");
                txtAmmount.Text = "";
                MessageBox.Show("Please enter a valid amount of money, eg 0.00.");                
            }
            else
            {
                errTransferAmmount.SetError(txtAmmount, "");                

            }

        }

        //load event
        private void TransferFunds_Load(object sender, EventArgs e)
        {
            txtDestinationSortCode.Enabled = false;
            txtAccOutNumber.Enabled = false;
            txtRecepientName.Enabled = false;
        }//end of load

        
    }//end of class
}
