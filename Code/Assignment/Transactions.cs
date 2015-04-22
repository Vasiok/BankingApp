using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adding using directive
using DataModel;
using BLL; // to pass objects

namespace Assignment
{
    public partial class Transactions : Form
    {
        // private property - bringing Student /Account from the DataModel
        private Student Student { get; set; }
        private Account Account { get; set; }


        //constructor
        public Transactions(Student student, Account account)
        {
            InitializeComponent();

            Student = student;
            Account = account;

            // populate the txt fields
            PopulateStudentFields(Student);
            PopulateAccountFields(Account);
            NoEdit();

            // for Main DGV
            GenerateColumnNames();
            // for Transfer DGV
            GenerateColumnNames2();
        }//end of constructor


        //nack button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }//end of back


        //method populates student fields on the form
        private void PopulateStudentFields(Student stu)
        {
            txtFirstName.Text = stu.FirstName;
            txtLastName.Text = stu.LastName;
        }//end of populateStudent


        //Method to populate account related fields on the form
        private void PopulateAccountFields(Account acc)
        {
            txtAccountNum.Text = acc.AccountNo.ToString();

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
        }//end of NoEdit


        //method to view all transactions
        private void btnAllTranactions_Click(object sender, EventArgs e)
        {
            // sets dgvTransfer to hidden, dgvTransactions visibable
            dgvTransactions.Visible = true;
            dgvTransfers.Visible = false;
            
            BLLTransactionManager bllTransMngr = new BLLTransactionManager();
            List<TransactionRecord> transList = new List<TransactionRecord>();

            int accNum = int.Parse(txtAccountNum.Text);

            transList = bllTransMngr.GetTransactionDetailsAsList(accNum);

            dgvTransactions.DataSource = transList;
        }//end of all transactions


        //will set datagrid to logments transactions only
        private void btnLodgements_Click(object sender, EventArgs e)
        {
            // sets dgvTransfer to hidden, dgvTransactions visibable
            dgvTransactions.Visible = true;
            dgvTransfers.Visible = false;

            BLLTransactionManager bllTransMngr = new BLLTransactionManager();
            List<TransactionRecord> transList = new List<TransactionRecord>();

            int accNum = int.Parse(txtAccountNum.Text);

            transList = bllTransMngr.GetCreditTransactionsAsList(accNum);
            
            dgvTransactions.DataSource = transList;
        }//end of lodgements


        //will show only withdraws
        private void btnViewWithdraws_Click(object sender, EventArgs e)
        {
            // sets dgvTransfer to hidden, dgvTransactions visibable
            dgvTransactions.Visible = true;
            dgvTransfers.Visible = false;

            BLLTransactionManager bllTransMngr = new BLLTransactionManager();
            List<TransactionRecord> transList = new List<TransactionRecord>();

            int accNum = int.Parse(txtAccountNum.Text);

            transList = bllTransMngr.GetDebitTransactionsAsList(accNum);

            dgvTransactions.DataSource = transList;
        }//end of withdraws


        //method to generate column names for datagrid
        private void GenerateColumnNames()
        {
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.ColumnCount = 5;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransactions.Columns[0].HeaderText = "Transaction ID";
            dgvTransactions.Columns[0].DataPropertyName = "TransactionID";

            dgvTransactions.Columns[1].HeaderText = "Transaction Type";
            dgvTransactions.Columns[1].DataPropertyName = "TransactionType";

            dgvTransactions.Columns[2].HeaderText = "Date of Transaction"; 
            dgvTransactions.Columns[2].DataPropertyName = "Date";

            dgvTransactions.Columns[3].HeaderText = "Transaction Amount";
            dgvTransactions.Columns[3].DataPropertyName = "TransAmt";

            dgvTransactions.Columns[4].HeaderText = "Balance";
            dgvTransactions.Columns[4].DataPropertyName = "CurrBal"; 
        }//end of GenerateColumnNames


        //view transfers only
        private void btnTransfers_Click(object sender, EventArgs e)
        {
            // sets dgvTransfer to visible, dgvTransactions hidden
            dgvTransfers.Visible = true;
            dgvTransactions.Visible = false;

            BLLTransactionManager bllTransMngr = new BLLTransactionManager();
            List<TransferPerAcc> transList = new List<TransferPerAcc>();
            
            int accNum = int.Parse(txtAccountNum.Text);

            transList = bllTransMngr.GetTransactionsAndTransfersAsList(accNum);

            dgvTransfers.DataSource = transList;
        }//end of transfers



        // the column names for the Data Grid View for Transfers
        private void GenerateColumnNames2()
        {
            dgvTransfers.AutoGenerateColumns = false;
            dgvTransfers.ColumnCount = 7;
            dgvTransfers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransfers.Columns[0].HeaderText = "Transaction ID";
            dgvTransfers.Columns[0].DataPropertyName = "TransactionNum";

            dgvTransfers.Columns[1].HeaderText = "Transaction Type";
            dgvTransfers.Columns[1].DataPropertyName = "TransactionType";

            dgvTransfers.Columns[2].HeaderText = "Date";
            dgvTransfers.Columns[2].DataPropertyName = "Date";

            dgvTransfers.Columns[3].HeaderText = "Transaction Amount";
            dgvTransfers.Columns[3].DataPropertyName = "TransAmt";

            dgvTransfers.Columns[4].HeaderText = "Destination Sort Code";
            dgvTransfers.Columns[4].DataPropertyName = "DestinationSortCode";

            dgvTransfers.Columns[5].HeaderText = "Destination Account Number";
            dgvTransfers.Columns[5].DataPropertyName = "DestinationAccNo";

            dgvTransfers.Columns[6].HeaderText = "Transfer Description";
            dgvTransfers.Columns[6].DataPropertyName = "TransferDescription";

        }//end of GenerateColumnNames2
    }
}
