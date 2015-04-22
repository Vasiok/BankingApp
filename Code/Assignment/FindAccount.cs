using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DataModel;

namespace Assignment
{
    public partial class FindAccount : Form
    {
        //TransferFunds trans;
        private List<Account> accList = new List<Account>();

        Account SelectedAcc = new Account();

        //publishing an event
        public event EventHandler<AccountArgs> OnAccountSelected;

        //constructor
        public FindAccount()
        {
            InitializeComponent();
            //this.trans = transfer;
            PrimeListGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();            
            
        }


        //method to populate datagrid
        private void PrimeListGrid()
        {
            
            BLLAccountManager bllAccMgnr = new BLLAccountManager();
            List<Account> AccDetailsList = bllAccMgnr.GetAccountDetailsAsList();

            //// set auto generate columns to false
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.ColumnCount = 7;
            // fit everything to the size of the windows form
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //setting the headers
            dgvAccounts.Columns[0].HeaderText = "Account Number"; // what will be displayed in dgv
            dgvAccounts.Columns[0].DataPropertyName = "AccountNo"; // from column names in SQL Server

            dgvAccounts.Columns[1].HeaderText = "Account Type";
            dgvAccounts.Columns[1].DataPropertyName = "AccountType";

            dgvAccounts.Columns[2].HeaderText = "Sort Code";
            dgvAccounts.Columns[2].DataPropertyName = "SortCode";

            dgvAccounts.Columns[3].HeaderText = "Initial Balance";
            dgvAccounts.Columns[3].DataPropertyName = "InitBal";

            dgvAccounts.Columns[4].HeaderText = "Current Balance";
            dgvAccounts.Columns[4].DataPropertyName = "CurtBal";

            dgvAccounts.Columns[5].HeaderText = "Over Draft Limit";
            dgvAccounts.Columns[5].DataPropertyName = "OverDraft";

            dgvAccounts.Columns[6].HeaderText = "Student ID";
            dgvAccounts.Columns[6].DataPropertyName = "StudentID";

            dgvAccounts.DataSource = AccDetailsList;
        }//end of primeGrid()


        //Method eill get details of selected account in the datagrid and will return an object
        private Account GetSelectedAccount()
        {

            BLLAccountManager bllAccMngr = new BLLAccountManager();
            // inputting a list of Accounts into accList
            accList = bllAccMngr.GetAccountDetailsAsList();

            Account selAccount = null;

            int studentID = 0;
            string accType = "";
            // as the StudentID is the last column in Main Display dgv - using enum
            int studentIDIndex = Convert.ToInt32(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_StudentID));
            int accTypeIndex = Convert.ToInt32(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_AccountType));
            int rowIndex = 0;

            if (dgvAccounts.SelectedRows.Count > 0)
            {
                // this ensures you select only 1 row, not multi-select
                rowIndex = dgvAccounts.SelectedRows[0].Index;

                // getting the studentID
                studentID = (int)dgvAccounts.Rows[rowIndex].Cells[studentIDIndex].Value;
                // getting the account type
                accType = dgvAccounts.Rows[rowIndex].Cells[accTypeIndex].Value.ToString();

                for (int i = 0; i < accList.Count; i++)
                {
                    if (accList[i].StudentID == studentID)
                    {
                        if (accList[i].AccountType == accType)
                        {
                            selAccount = accList[i];
                            break;
                        }
                    }
                }
            }
            return selAccount;
        }//End of GetSelectedAccount


        //button to select an account
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Account acc = new Account();

            acc = GetSelectedAccount();


            if (acc !=null)
            {
                AccountArgs accArgs = new AccountArgs();
                accArgs.Account = acc;

                //raising published even here
                OnAccountSelected(this, accArgs);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Please make a selection");
            }
        }//end of select click


        //button to filter the result of students
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BLLAccountManager manager = new BLLAccountManager();

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            List<Account> accsFromBll = new List<Account>(2);

            // testing to see what search option to use
            if (firstName == string.Empty && lastName == String.Empty)
            {
                MessageBox.Show("Please enter student first name or last name or both");
            }
            else if ((firstName != String.Empty) && (lastName != String.Empty))
            {
                accsFromBll = manager.GetAcountsByStudentName(firstName, lastName);
            }
            else if (firstName != String.Empty)
            {
                accsFromBll = manager.GetAcountsByStudentFirsName(firstName);
            }
            else if (lastName != String.Empty)
            {
                accsFromBll = manager.GetAcountsByStudentLastName(lastName);
            }



            dgvAccounts.DataSource = accsFromBll;

            if (!accsFromBll.Any())
            {
                MessageBox.Show("No account or student found");
            }
        }//End of search 



        //button to show all students on the datagrid again
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            BLLAccountManager manager = new BLLAccountManager();

            List<Account> accs = manager.GetAccountDetailsAsList();

            dgvAccounts.DataSource = accs;
        }//end of display all

       
    }
}
