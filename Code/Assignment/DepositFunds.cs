using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adding using directives
using DataModel;
using BLL;
using System.Text.RegularExpressions; // to pass objects

namespace Assignment
{
    public partial class DepositFunds : Form
    {
        // private property - bringing Student /Account from the DataModel
        private Student Student { get; set; }
        private Account Account { get; set; }

        //setting transaction type to credit as this class deals with logements
        public TransactionType TransactionType = TransactionType.credit;


        //constructor
        public DepositFunds(Student student, Account account)
        {
            InitializeComponent();

            // passing the student and account objects into the private propertys
            Student = student;
            Account = account;

            // populate the txt fields
            PopulateStudentFields(Student);
            PopulateAccountFields(Account);

            // setting the fields that don't allow any edits
            NoEdit();
        }//end of contructor


        //button to fo back 
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }// end of back button


        //this will populated fields on our form using student object passed
        private void PopulateStudentFields(Student stu)
        {
            // populating the student fields from the student object
            txtFirstName.Text = stu.FirstName; 
            txtLastName.Text = stu.LastName;
        }//end of PopulateStudentFields


        //Method to populate fields relevant to account using account object passed
        private void PopulateAccountFields(Account acc)
        {
            // populating the account fields from the account object
            txtAccountNum.Text = acc.AccountNo.ToString();
            txtCurrentBal.Text = acc.CurtBal;
            txtOverdraft.Text = acc.OverDraft;

            string accType = acc.AccountType.ToString();

            if (accType == "current")
            {
                rdoCurrentAcc.Checked = true;
                rdoSavingsAcc.Checked = false;
            }
            else if (accType == "saving")
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


        //button click to deposit money
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // getting the account type
            string accType = "";
            if (rdoCurrentAcc.Checked)
            {
                accType = "current";
            }
            else if (rdoSavingsAcc.Checked)
            {
                accType = "saving";
            }

            // to get the old balance
            string ob = txtCurrentBal.Text;
            // removing the Euro Sign
            ob = ob.Replace("€", "");
            // by removing the period, the value equates to the integer value
            ob = ob.Replace(".", "");
            ob = ob.Replace(",", "");

            int oldBalance;
            oldBalance = Convert.ToInt32(ob);

            // converting the deposit amount from a string to int
            string da = txtDeposit.Text;
            int depositAmount = MoneyTransformer.TransformMoney(da);

            int newBalance;
            newBalance = oldBalance + depositAmount; 

            int accNum = int.Parse(txtAccountNum.Text);

            BLLTransactionManager bllTransMngr = new BLLTransactionManager();
            // sending the Desposit Money through the layers
            bllTransMngr.DepositMonies(accNum, newBalance, accType);

            // Start of code to deal with transaction
            int transID = 0;
            TransactionRecord trans = new TransactionRecord();
            trans.TransactionType = TransactionType;
            trans.TransactionAmmount = depositAmount;
            trans.AccountNumber = accNum;
            trans.Date = DateTime.Now;
            trans.Balance = newBalance;

            bllTransMngr.CreateTransaction(trans, out transID);
            // end of transaction

            // reseting the Deposit field to blank
            txtDeposit.Text = String.Empty;

            // to display the new balance out to the user, ensuring "0.00"
            string displayBal = newBalance.ToString();
            int c = displayBal.Count();
            displayBal = displayBal.Insert((c - 2), ".");

            // displaying the new balance to the user, before exiting the screen
            MessageBox.Show("Deposit Complete, New Balance = €" + displayBal);

            // reseting the Current Balance
            txtCurrentBal.Text = "€" + displayBal;
        }//end of deposit button click



        //load event
        private void DepositFunds_Load(object sender, EventArgs e)
        {
            // puttin the curser in the txtDespoit 
            txtDeposit.Focus();
        }//end of load



        /*************************
         * Validating the fields  *
         *************************/
        private void txtDeposit_Validating(object sender, CancelEventArgs e)
        {
            string depositAmmount = txtDeposit.Text;
            string usrRgExp = Expressions.Money;

            if (!Regex.IsMatch(depositAmmount, usrRgExp))
            {
                errDeposit.SetError(txtDeposit, "Please enter a valid amount of money, in the format 0.00.");
                txtDeposit.Text = "";
                MessageBox.Show("Please enter a valid amount of money, in the format 0.00.");
                //val = false;
            }
            else
            {
                errDeposit.SetError(txtDeposit, "");                

            }
        }//end of validating
    }
}
