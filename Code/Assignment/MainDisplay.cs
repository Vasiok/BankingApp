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
using System.Text.RegularExpressions;

namespace Assignment
{
    //Main display screen
    public partial class MainDisplay : Form
    {
        // making a list for students
        private List<Student> stuList = new List<Student>();
        private List<Account> accList = new List<Account>();

        public MainDisplay()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry f1 = new Entry();
            f1.Show();
            this.Close();
        }

        //exit menu option
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end of exit


        // new account from menu
        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewAccount na = new NewAccount(this))
            {
                na.ShowDialog();
                this.Close();
            }
        }//end of new account


        //edit account tool strip menu
        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            Account selAccount = GetSelectedAccount();

            if (selStudent != null)
            {
                // passing the selected student and account into the edit form
                using (EditAccount ea = new EditAccount(selStudent, selAccount))
                {
                    ea.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
        }//end of edit account



        //method returns selected student object from data grid
        private Student GetSelectedStudent()
        {
            BLLAccountManager bllAccMngr = new BLLAccountManager();

            Student selStudent = null;

            int studentID = 0;
            // the StudentID is the last column in Main Display dgv - using enum instead of majic numbers
            int columnIndex = Convert.ToInt32(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_StudentID));
            int rowIndex = 0;

            if (dgvDisplay.SelectedRows.Count > 0)
            {
                // this ensures you select only 1 row, not multi-select
                rowIndex = dgvDisplay.SelectedRows[0].Index;

                //getting the studentID
                studentID = (int)dgvDisplay.Rows[rowIndex].Cells[columnIndex].Value;

                // inputting a list of Students into stuList
                stuList = bllAccMngr.getStudents();

                // circulating through the list to find the matching student number
                for (int i = 0; i < stuList.Count; i++)
                {
                    if (stuList[i].StudentID == studentID)
                    {
                        selStudent = stuList[i];
                        break;
                    }
                }
            }
            return selStudent;
        }//end of GetSelectedStudent


        //method returns selected account from datagrid
        private Account GetSelectedAccount()
        {
            BLLAccountManager bllAccMngr = new BLLAccountManager();
            // inputting a list of Accounts into accList
            accList = bllAccMngr.GetAccountDetailsAsList();

            Account selAccount = null;

            int studentID = 0;
            string accType = "";
            // using enum instead of majic numbers
            int studentIDIndex = Convert.ToInt32(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_StudentID));
            int accTypeIndex = Convert.ToInt32(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_AccountType));
            int rowIndex = 0;

            if (dgvDisplay.SelectedRows.Count > 0)
            {
                // this ensures you select only 1 row, not multi-select
                rowIndex = dgvDisplay.SelectedRows[0].Index;

                // getting the studentID
                studentID = (int)dgvDisplay.Rows[rowIndex].Cells[studentIDIndex].Value;
                // getting the account type
                accType = dgvDisplay.Rows[rowIndex].Cells[accTypeIndex].Value.ToString();

                // circulating through the list to find the matching student number and account type
                for (int i = 0; i < accList.Count; i++)
                {
                    // checking student id
                    if (accList[i].StudentID == studentID)
                    {
                        // checking matching account type
                        if(accList[i].AccountType == accType)
                        {
                            selAccount = accList[i];
                            break;
                        }
                    }
                }
            }
            return selAccount;
        }//end of GetSelectedAccount



        //deposit option menu
        private void depositFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            Account selAccount = GetSelectedAccount();

            if (selStudent != null)
            {
                // passing the selected student & account into the deposit form
                using (DepositFunds df = new DepositFunds(selStudent, selAccount))
                {
                    df.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
        }//end of deposit menu


        //withdraw menu option
        private void withdrawFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            Account selAccount = GetSelectedAccount();

            if (selStudent != null)
            {
                // passing the selected student and account into the withdraw form
                using (WithdrawFunds wf = new WithdrawFunds(selStudent, selAccount))
                {
                    wf.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
        }//end of withdraw menu


        //transfer from menu option
        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            Account selAccount = GetSelectedAccount();

            if (selStudent != null)
            {
                // passing the selected student and account into the transfer form
                using (TransferFunds tf = new TransferFunds(selStudent, selAccount))
                {
                    tf.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
           
        }//end of menu transfer


        //view transaction from menu option
        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            Account selAccount = GetSelectedAccount();

            if (selStudent != null)
            {
                // passing the selected student and account into the view tranactions form
                using (Transactions tra = new Transactions(selStudent, selAccount))
                {
                    tra.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
        }//end of view transaction


        //view account menu option
        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            Account selAccount = GetSelectedAccount();

            if (selStudent != null)
            {
                // passing the selected student and accounts into the view account form
                using (ViewAccount va = new ViewAccount(selStudent, selAccount))
                {
                    va.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
        }//end of view account



        // loading information into the Main Display
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            PrimeGrids(false);
        }//end of load event


        //method will call other method to populate datagrid
        private void PrimeGrids(bool clearListGridDataSource)
        {
            PrimeListGrid(clearListGridDataSource);
        }//end of prime


        //method that populates the datagrid and configures the way data is displayd in it
        private void PrimeListGrid(bool clearDataSource)
        {
            if (clearDataSource)
            {
                dgvDisplay.DataSource = null;
            }

            BLLAccountManager bllAccMgnr = new BLLAccountManager();
            List<Account> AccDetailsList = bllAccMgnr.GetAccountDetailsAsList();

            dgvDisplay.AutoGenerateColumns = false;
            dgvDisplay.ColumnCount = 7;
            dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //setting the headers
            dgvDisplay.Columns[0].HeaderText = "Account Number"; // what will be displayed in dgv
            dgvDisplay.Columns[0].DataPropertyName = "AccountNo"; 

            dgvDisplay.Columns[1].HeaderText = "Account Type";
            dgvDisplay.Columns[1].DataPropertyName = "AccountType";

            dgvDisplay.Columns[2].HeaderText = "Sort Code";
            dgvDisplay.Columns[2].DataPropertyName = "SortCode";

            dgvDisplay.Columns[3].HeaderText = "Initial Balance";
            dgvDisplay.Columns[3].DataPropertyName = "InitBal";

            dgvDisplay.Columns[4].HeaderText = "Current Balance";
            dgvDisplay.Columns[4].DataPropertyName = "CurtBal";

            dgvDisplay.Columns[5].HeaderText = "Over Draft Limit";
            dgvDisplay.Columns[5].DataPropertyName = "OverDraft";

            dgvDisplay.Columns[6].HeaderText = "Student ID";
            dgvDisplay.Columns[6].DataPropertyName = "StudentID";

            dgvDisplay.DataSource = AccDetailsList;
        }//end of primeGrid()


        //method to filter account using name and surname
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
            else if ((firstName != String.Empty) &&(lastName != String.Empty))
            {
                 accsFromBll = manager.GetAcountsByStudentName(firstName, lastName); 
            }
            else if(firstName != String.Empty)
            {
                accsFromBll = manager.GetAcountsByStudentFirsName(firstName);
            }
            else if (lastName != String.Empty)
            {
                accsFromBll = manager.GetAcountsByStudentLastName(lastName);
            }                      

            dgvDisplay.DataSource = accsFromBll;

            if (!accsFromBll.Any())
            {
                MessageBox.Show("No account or student found");
            }

        }//End of search button click



        //method to repopulate datagrid with all accounts
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            BLLAccountManager manager = new BLLAccountManager();

            List<Account> accs = manager.GetAccountDetailsAsList();

            dgvDisplay.DataSource = accs;
        }//end of display all accs btn



        /*************************
         * Validatin the fields  *
         *************************/
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            string name = txtFirstName.Text;
            string usrRgExp = Expressions.FirstName;

            if (!Regex.IsMatch(name, usrRgExp))
            {
                errFname.SetError(txtFirstName, "Please enter name excluding any weird characters");
                txtFirstName.Text = "";
                MessageBox.Show("Please enter first name in correct format");
                //val = false;
            }
            else
            {
                errFname.SetError(txtFirstName, "");
                //val = true;

            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string name = txtLastName.Text;
            string usrRgExp = Expressions.LastName;

            if (!Regex.IsMatch(name, usrRgExp))
            {
                errLName.SetError(txtLastName, "Please enter name excluding any weird characters");
                txtLastName.Text = "";
                MessageBox.Show("Please enter last name in correct format");                
            }
            else
            {
                errLName.SetError(txtLastName, "");                
            }
        }
    }
}
