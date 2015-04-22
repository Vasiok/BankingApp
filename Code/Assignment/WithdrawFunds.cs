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
using BLL;
using System.Text.RegularExpressions; // to pass objects

namespace Assignment
{
    public partial class WithdrawFunds : Form
    {

        // private property - bringing Student /Account from the DataModel
        private Student Student { get; set; }
        private Account Account { get; set; }
        //setting the type of transaction to debit
        public TransactionType TransactionType = TransactionType.debit;


        //constructor
        public WithdrawFunds(Student student, Account account)
        {
            InitializeComponent();

            Student = student;
            Account = account;

            // populate the txt fields
            PopulateStudentFields(Student);
            PopulateAccountFields(Account);
            NoEdit();
        }//end of constructor

        //back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }//end of back button click


        //populates fields relate to student on the form
        private void PopulateStudentFields(Student stu)
        {
            txtFirstName.Text = stu.FirstName;
            txtLastName.Text = stu.LastName;
        }//end of PopulateStudentFields



        //method to populate account fields on our form
        private void PopulateAccountFields(Account acc)
        {
            txtAccountNum.Text = acc.AccountNo.ToString();
            txtCurrentBal.Text = acc.CurtBal;
            txtOverdraft.Text = acc.OverDraft;

            string accType = acc.AccountType.ToString();

            if (accType == "current")
            {
                rdoCurrentAcc.Checked = true;
                rdoSavingsAcc.Checked = false;
            }
            else
            {
                rdoCurrentAcc.Checked = false;
                rdoSavingsAcc.Checked = true;
            }
        }//end of PopulateAccountFields



        // setting the account fields to no edit
        private void NoEdit()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            rdoCurrentAcc.Enabled = false;
            rdoSavingsAcc.Enabled = false;
            txtAccountNum.Enabled = false;
            txtCurrentBal.Enabled = false;
            txtOverdraft.Enabled = false;
        }//end of NoEdit


        //click to initiate a withdraw
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // get account type
            string accType = "";
            if (rdoCurrentAcc.Checked)
            {
                accType = "current";
            }
            else if (rdoSavingsAcc.Checked)
            {
                accType = "saving";
            }

            // for old balance
            string ob = txtCurrentBal.Text;
            ob = ob.Replace("€", "");
            ob = ob.Replace(".", "");
            ob = ob.Replace(",", "");//this is needed if the sum is larger 
            string newBbb = ob;

            int oldBalance;
            oldBalance = int.Parse(ob);//Convert.ToInt32(ob);

            // get overdraft amount
            string od = txtOverdraft.Text;
            od = od.Replace("€", "");
            od = od.Replace(".", "");
            od = od.Replace(",", "");

            int ovaDraft;
            ovaDraft = Convert.ToInt32(od);
            // negative OverDraft to compare new balance with
            int negOvaDraft = -ovaDraft;

            // for withdraw amount
            string wd = txtWithdraw.Text;
            int withdrawAmount = MoneyTransformer.TransformMoney(wd);

            // setting the new balance
            int newBalance;
            newBalance = oldBalance - withdrawAmount;

            // bool set to true for transaction to complete
            bool completeTrans = false;

            if (newBalance >= 0)
            {
                completeTrans = true;
            }
            else if (newBalance >= negOvaDraft)
            {
                completeTrans = true;
            }
            if (completeTrans)
            {

                int accNum = int.Parse(txtAccountNum.Text);

                BLLTransactionManager bllTransMngr = new BLLTransactionManager();
                bllTransMngr.WithdrawMonies(accNum, newBalance, accType);

                //Start of code to deal with transaction
                int transID = 0;
                TransactionRecord trans = new TransactionRecord();
                trans.TransactionType = TransactionType;
                trans.TransactionAmmount = withdrawAmount;
                trans.AccountNumber = accNum;
                trans.Date = DateTime.Now;
                trans.Balance = newBalance;

                bllTransMngr.CreateTransaction(trans, out transID);

                // end of transaction

                // reseting the Withdraw field to blank
                txtWithdraw.Text = "";

                // to display the new balance out to the user, ensuring "0.00"
                string displayBal = newBalance.ToString();

                if (displayBal.Count()>=2)
                {
                    int c = displayBal.Count();
                    displayBal = displayBal.Insert((c - 2), "."); 
                }
                else if(displayBal.Count()==1)
                {
                    displayBal = "0.0" + displayBal;
                }                

                // displaying the new balance to the user, before exiting the screen
                MessageBox.Show("Withdraw Complete, New Balance = €" + displayBal);

                // reseting the Current Balance
                txtCurrentBal.Text = "€" + displayBal;
            }
            else
            {
                MessageBox.Show("Insufficent funds!", "Please try again");
            }
        }//end of Withdraw money

        //load event
        private void WithdrawFunds_Load(object sender, EventArgs e)
        {
            txtWithdraw.Focus();
        }//end of load event


        /*************************
         * Validatin the fields  *
         *************************/
        private void txtWithdraw_Validating(object sender, CancelEventArgs e)
        {


            string withdraeAmmount = txtWithdraw.Text;
            string usrRgExp = Expressions.Money;

            if (!Regex.IsMatch(withdraeAmmount, usrRgExp))
            {
                errWithdraw.SetError(txtWithdraw, "Please enter a valid amount of money, in the format 0.00.");
                txtWithdraw.Text = "";
                MessageBox.Show("Please enter a valid amount of money, in the format 0.00.");                
            }
            else
            {
                errWithdraw.SetError(txtWithdraw, "");                
            }

        }
    }//end of class
}