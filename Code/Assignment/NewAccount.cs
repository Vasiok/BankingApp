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
using System.Configuration;
using System.Text.RegularExpressions;

namespace Assignment
{
    public partial class NewAccount : Form
    {
        //getting needed details from configuration file
        public int savingOverdraft = int.Parse(ConfigurationManager.AppSettings["savOverdraft"]);
        public string sortCodeInCode = ConfigurationManager.AppSettings["sortCode"].ToString();
        
        // creating object Student
        public Student Student { get; set; }

        MainDisplay md;

        public bool ExistingStud { get; set; }

        //constructor
        public NewAccount(MainDisplay mdPasses)
        {            
            InitializeComponent();
            md = mdPasses;
            // calling enums from Countys Class
            cboCounty.DataSource = Enum.GetValues(typeof (Countys.CountysList));
        }

        //default constructor
        public NewAccount() 
        {
        }

        //back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }//end of back


        // Method to to create new account
        // If a student exists it will create a new acount that will be linked to existing student
        // If there is no student it will create a student and a new account
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //variable to control display of succesfull record insetion
            bool success = false;

            BLLAccountManager manager = new BLLAccountManager();

            List<Account> accList = new List<Account>();

            //following two lines are here to chech if we have account type allready created
            List<Account> currentExist = new List<Account>(1);
            List<Account> savingtExist = new List<Account>(1);

            accList = manager.GetAccountDetailsAsList();

            //Creating empty account
            Account acc = new Account();
            
            int accNo;
            int studIdFromDb = 0;

            if (!ExistingStud)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    PopulateStudent();
                    manager.AddStudent(Student, out studIdFromDb);
                    success = true;
                }
                else
                {
                    success = false;
                }
                //PopulateStudent();
                //manager.AddStudent(Student, out studIdFromDb);
               
                //manager.AddStudent(Student, out studIdFromDb);
                acc.StudentID = studIdFromDb;
            }
            else if (ExistingStud)
            {
                acc.StudentID = int.Parse(txtStudentId.Text);
            }

            string accType = "";

            //getting all accs for a given student that are current or saving
            currentExist = accList.Where(Account => Account.AccountType =="current" && Account.StudentID ==  acc.StudentID).ToList();
            savingtExist = accList.Where(Account => Account.AccountType == "saving" && Account.StudentID == acc.StudentID).ToList();

            acc.SortCode = int.Parse(txtSortCode.Text);
            
            string initBal = txtInitialBalance.Text;
            int initBal2 = MoneyTransformer.TransformMoney(initBal);
            acc.InitialBalance = initBal2;
            // setting the current Balance to the same value as the inital balance
            acc.CurrentBalance = initBal2;
            string ovaDraft = txtOverdraft.Text;
            int ovaDraft2 = MoneyTransformer.TransformMoney(ovaDraft);
            acc.OverDraftLimit = ovaDraft2;

            if (rdoCurrentAcc.Checked)
            {
                //checking if student has a current account allready
                if (currentExist.Any())
                {
                    MessageBox.Show("Student allready has a current account");                    
                }
                else
                {
                    accType = "current";
                    acc.AccountType = accType;

                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        manager.AddAccount(acc, out accNo);
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    
                }
                
            }
            else if (rdoSavingsAcc.Checked)
            {
                //checking if student has saving account allready.
                if (savingtExist.Any())
                {
                    MessageBox.Show("Student allready has saving account");                    
                }
                else
                {
                    accType = "saving";
                    acc.AccountType = accType;
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        manager.AddAccount(acc, out accNo);
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
            }

            if (success)
            {
                MessageBox.Show("New Account Created");
            }
            else
            {
                MessageBox.Show("No account created try again with correct details");
            }
            

        }//end of add acc button click


        //method for making values visible on the form used for existing students
        private void PrimeStudentFields()
        {
            txtFirstName.Text = Student.FirstName;            
            txtLastName.Text = Student.LastName;
            txtStudentId.Text = Student.StudentID.ToString();
            txtEmail.Text = Student.Email;
            txtPhone.Text = Student.Phone;
            txtAddress1.Text = Student.Address1;
            txtAddress2.Text = Student.Address2;
            txtCity.Text = Student.City;
            cboCounty.Text = Student.County;            
        }//end of PrimeStudentFields




        //this method is for populating Student object
        private void PopulateStudent()
        {
            Student = new Student();

            Student.FirstName = txtFirstName.Text;
            Student.LastName = txtLastName.Text;
            Student.Email = txtEmail.Text;
            Student.Phone = txtPhone.Text;
            Student.Address1 = txtAddress1.Text;
            Student.Address2 = txtAddress2.Text;
            Student.City = txtCity.Text;
            Student.County = cboCounty.SelectedItem.ToString();
        }// end of PopulateStudent




        // This will bring up new window where you can choose from the list of students or search for one
        private void btnExisting_Click(object sender, EventArgs e)
        {
            using (SearchExistingStudents ses = new SearchExistingStudents())
            {
                //subscribing to event
                ses.OnStudentSelected += ses_OnStudentSelected;
                ses.ShowDialog();
            } 
        }//end of existing click



        //event handler for when an existing student is selected
        //will set the value of Student property to the one passed
        void ses_OnStudentSelected(object sender, StudentArgs e)
        {
            this.Student = e.Student;
            ExistingStud = true;
            PrimeStudentFields();            
        }//end of handler


        //LOAD
        private void NewAccount_Load(object sender, EventArgs e)
        {
            txtStudentId.Enabled = false;
            txtSortCode.Text = sortCodeInCode;
            txtSortCode.Enabled = false;
            txtAccountNum.Enabled = false;
            rdoCurrentAcc.Checked = true;
        }//end of load


        // sets overdraft limit to zero if savings account is being created
        private void rdoSavingsAcc_Click(object sender, EventArgs e)
        {
            txtOverdraft.Text = savingOverdraft.ToString();
            txtOverdraft.Enabled = false;
        }//end of rdoSav


        //sets overdraft back to editable
        private void rdoCurrentAcc_Click(object sender, EventArgs e)
        {
            txtOverdraft.Enabled = true;
        }//end of current








        /*
         *****************************
         * FIELDS VALIDATING CODE
         *****************************
         */

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string name = txtFirstName.Text;
            string usrRgExp = Expressions.FirstName;

            if (!Regex.IsMatch(name, usrRgExp))
            {
                errProv.SetError(txtFirstName, "Please enter name excluding any weird characters.");
                txtFirstName.Text = "";
                e.Cancel = true;
                //MessageBox.Show("Please enter first name in correct format.");                
            }
            else
            {
                errProv.SetError(txtFirstName, "");
                e.Cancel = false;

            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string lName = txtLastName.Text;
            string usrRgExp = Expressions.LastName;

            if (!Regex.IsMatch(lName, usrRgExp))
            {
                errProv.SetError(txtLastName, "Please enter name excluding any weird characters.");
                txtLastName.Text = "";
                e.Cancel = true;
               // MessageBox.Show("Please enter last name in correct format.");                
            }
            else
            {
                errProv.SetError(txtLastName, "");
                e.Cancel = false;
            }
        }



        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;
            string usrRgExp = Expressions.Email;

            if (!Regex.IsMatch(email, usrRgExp))
            {
                errProv.SetError(txtEmail, "Please enter a valid email, eg email@email.com.");
                txtEmail.Text = "";
                e.Cancel = true;
                //MessageBox.Show("Please enter a valid email, eg email@email.com.");                
            }
            else
            {
                errProv.SetError(txtEmail, "");
                e.Cancel = false;
            }
        }




        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = txtPhone.Text;
            string usrRgExp = Expressions.Phone;

            if (!Regex.IsMatch(phone, usrRgExp))
            {
                errProv.SetError(txtPhone, "Please enter a valid phone number, eg 086-2411648.");
                txtPhone.Text = "";
                e.Cancel = true;
               // MessageBox.Show("Please enter a valid phone number\nExample: 086-2411648, 01-2146598");                
            }
            else
            {
                errProv.SetError(txtPhone, "");
                e.Cancel = false;
            }
        }




        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            string address1 = txtAddress1.Text;
            string usrRgExp = Expressions.Address;

            if (!Regex.IsMatch(address1, usrRgExp))
            {
                errProv.SetError(txtAddress1, "Please enter a valid address.");
                txtAddress1.Text = "";
                e.Cancel = true;
               // MessageBox.Show("Please enter a valid address.");                
            }
            else
            {
                errProv.SetError(txtAddress1, "");
                e.Cancel = false;
            }
        }



        private void txtAddress2_Validating(object sender, CancelEventArgs e)
        {
            string address2 = txtAddress2.Text;
            string usrRgExp = Expressions.Address;

            if (!Regex.IsMatch(address2, usrRgExp))
            {
                errProv.SetError(txtAddress2, "Please enter a valid address.");
                txtAddress2.Text = "";
                e.Cancel = true;
                //MessageBox.Show("Please enter a valid address.");                
            }
            else
            {
                errProv.SetError(txtAddress2, "");
                e.Cancel = false;
            }
        }




        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            string city = txtCity.Text;
            string usrRgExp = Expressions.City;

            if (!Regex.IsMatch(city, usrRgExp))
            {
                errProv.SetError(txtCity, "Please enter a valid City name, eg Dublin.");
                txtCity.Text = "";
                e.Cancel = true;
                //MessageBox.Show("Please enter a valid City name, eg Dublin.");                
            }
            else
            {
                errProv.SetError(txtCity, "");
                e.Cancel = false;
            }
        }





        private void txtInitialBalance_Validating(object sender, CancelEventArgs e)
        {
            string initBal = txtInitialBalance.Text;
            string usrRgExp = Expressions.Money;

            if (!Regex.IsMatch(initBal, usrRgExp))
            {
                errProv.SetError(txtInitialBalance, "Please enter valid ammount of money, in the format 0.00.");
                txtInitialBalance.Text = "";
                e.Cancel = true;
               // MessageBox.Show("Please enter valid ammount of money, in the format 0.00.");                
            }
            else
            {
                errProv.SetError(txtInitialBalance, "");
                e.Cancel = false;
            }
        }
        


        private void txtOverdraft_Validating(object sender, CancelEventArgs e)
        {
            string overdraft = txtOverdraft.Text;
            string usrRgExp = Expressions.Money;

            if (!Regex.IsMatch(overdraft, usrRgExp))
            {
                errProv.SetError(txtOverdraft, "Please enter valid ammount of money, in the format 0.00.");
                txtOverdraft.Text = "";
                e.Cancel = true;
               // MessageBox.Show("Please enter valid ammount of money, in the format 0.00.");
                //val = false;
            }
            else
            {
                errProv.SetError(txtOverdraft, "");
                e.Cancel = false;
                //val = true;

            }
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtAddress1_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtAddress2_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtInitialBalance_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        private void txtOverdraft_Validated(object sender, EventArgs e)
        {
            errProv.Clear();
        }

        

        
    }
}
