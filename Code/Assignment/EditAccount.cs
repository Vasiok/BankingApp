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
using BLL;
using System.Text.RegularExpressions; // to pass objects

namespace Assignment
{
    public partial class EditAccount : Form
    {
        // private property - bringing Student /Account from the DataModel
        private Student Student { get; set; }
        private Account Account { get; set; }

        // constructor - forse the user to send an account when creating form
        public EditAccount(Student student, Account account)
        {
            InitializeComponent();
            cboCounty.DataSource = Enum.GetValues(typeof(Countys.CountysList));
            Student = student;
            Account = account;

            // populate the txt fields
            PopulateStudentFields(Student);
            PopulateAccountFields(Account);
        }

        // go back to main screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }//end of go back


        //event will sent new student object in order to change the details in database
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student stu = new Student();

            BLLAccountManager bllAccMngr = new BLLAccountManager();

            bool retVal = false;

            // fill up stu with details on edit form
            stu = CaptureStudentFields();

            // pass info to DB
            retVal = bllAccMngr.EditStudentDetails(stu);
            if (retVal)
            {
                MessageBox.Show("Details saved");
            }

          
        }//end of edit button click



        // capturing all the student details to pass down
        private Student CaptureStudentFields()
        {
            Student stu = new Student();

            stu.FirstName = txtFirstName.Text;
            stu.LastName = txtLastName.Text;
            stu.StudentID = int.Parse(txtStudentId.Text);
            stu.Email = txtEmail.Text;
            stu.Phone = txtPhone.Text;
            stu.Address1 = txtAddress1.Text;
            stu.Address2 = txtAddress2.Text;
            stu.City = txtCity.Text;
            stu.County = cboCounty.Text;

            return stu;
        }//end of CaptureStudentFields


        //Method used to populate fields with existing student
        private void PopulateStudentFields(Student stu)
        {
            txtFirstName.Text = stu.FirstName; // no edit
            txtLastName.Text = stu.LastName; // no edit
            txtStudentId.Text = stu.StudentID.ToString(); // no edit
            txtEmail.Text = stu.Email;
            txtPhone.Text = stu.Phone;
            txtAddress1.Text = stu.Address1;
            txtAddress2.Text = stu.Address2;
            txtCity.Text = stu.City;
            cboCounty.Text = stu.County;

            NoEditStu();
        }//end of PopulateStudentFields



        // setting the student fields to no edit
        private void NoEditStu()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStudentId.Enabled = false;
        }//end of NoEdit


        //populate all fields neccesary for account
        private void PopulateAccountFields(Account acc)
        {
            txtAccountNum.Text = acc.AccountNo.ToString();
            txtSortCode.Text = acc.SortCode.ToString();
            txtInitialBalance.Text = acc.InitBal;
            txtCurrentBal.Text = acc.CurtBal;
            txtOverdraft.Text = acc.OverDraft;

            string accType = acc.AccountType.ToString();

            if (accType == "Current")
            {
                rdoCurrentAcc.Checked = true;
                rdoSavingsAcc.Checked = false;
            }
            else
            {
                rdoCurrentAcc.Checked = false;
                rdoSavingsAcc.Checked = true;
            }

            NoEditAcc();
        }//end of PopulateAccountFields


        // setting the account fields to no edit
        private void NoEditAcc()
        {
            rdoCurrentAcc.Enabled = false;
            rdoSavingsAcc.Enabled = false;
            txtAccountNum.Enabled = false;
            txtSortCode.Enabled = false;
            txtInitialBalance.Enabled = false;
            txtCurrentBal.Enabled = false;
            txtOverdraft.Enabled = false;
        }//end of NoEditAcc




        /*************************
         * Validatin the fields  *
         *************************/
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;
            string usrRgExp = Expressions.Email;

            if (!Regex.IsMatch(email, usrRgExp))
            {
                errEmail.SetError(txtEmail, "Please enter a validemail");
                txtEmail.Text = "";
                MessageBox.Show("Please enter a valid email");                
            }
            else
            {
                errEmail.SetError(txtEmail, "");                

            }
        }




        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = txtPhone.Text;
            string usrRgExp = Expressions.Phone;

            if (!Regex.IsMatch(phone, usrRgExp))
            {
                errPhone.SetError(txtPhone, "Please enter valid phone");
                txtPhone.Text = "";
                MessageBox.Show("Please enter valid phone");                
            }
            else
            {
                errPhone.SetError(txtEmail, "");                

            }
        }

        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            string addr1 = txtAddress1.Text;
            string usrRgExp = Expressions.Address;

            if (!Regex.IsMatch(addr1, usrRgExp))
            {
                errAddr1.SetError(txtAddress1, "Please enter an address");
                txtAddress1.Text = "";
                MessageBox.Show("Please enter an address");                
            }
            else
            {
                errAddr1.SetError(txtAddress1, "");                

            }
        }



        private void txtAddress2_Validating(object sender, CancelEventArgs e)
        {
            string addr2 = txtAddress2.Text;
            string usrRgExp = Expressions.Address;

            if (!Regex.IsMatch(addr2, usrRgExp))
            {
                errAddr2.SetError(txtAddress2, "Please enter an address");
                txtAddress2.Text = "";
                MessageBox.Show("Please enter an address");                
            }
            else
            {
                errAddr2.SetError(txtAddress2, "");                

            }
        }



        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            string city = txtCity.Text;
            string usrRgExp = Expressions.City;

            if (!Regex.IsMatch(city, usrRgExp))
            {
                errCity.SetError(txtCity, "Please enter city");
                txtCity.Text = "";
                MessageBox.Show("Please enter city");                
            }
            else
            {
                errCity.SetError(txtCity, "");                

            }
        }

        /*************************
         *** End of validation ***
         *************************/

    }
}
