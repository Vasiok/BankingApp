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
using BLL; // to pass object
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment
{
    public partial class ViewAccount : Form
    {
        // private property - bringing Student /Account from the DataModel
        private Student Student { get; set; }
        private Account Account { get; set; }
        
        
        //constructor
        public ViewAccount(Student student, Account account)
        {
            InitializeComponent();

            Student = student;
            Account = account;          

            // populate the txt fields
            PopulateStudentFields(Student);
            PopulateAccountFields(Account);
            NoEdits();
        }//end of constructor


        //method to populate student fields
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
        }//end of PopulateStudentFields


        //method to populate account fields
        private void PopulateAccountFields(Account acc)
        {
            txtAccountNum.Text = acc.AccountNo.ToString();
            txtSortCode.Text = acc.SortCode.ToString();
            txtInitialBalance.Text = acc.InitBal;
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



        // setting the fields to no edit
        private void NoEdits()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStudentId.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress1.Enabled = false;
            txtAddress2.Enabled = false;
            txtCity.Enabled = false;
            cboCounty.Enabled = false;
            
            rdoCurrentAcc.Enabled = false;
            rdoSavingsAcc.Enabled = false;
            txtAccountNum.Enabled = false;
            txtSortCode.Enabled = false;
            txtInitialBalance.Enabled = false;
            txtCurrentBal.Enabled = false;
            txtOverdraft.Enabled = false;
        }//end of NoEdits

        //back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }//end of back button



        //will serialize the details of related account and student to an xml file
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            AccountStudentContainer Container = new AccountStudentContainer();
            Container.Student = Student;
            Container.Account = Account;

            svfSaveToXml.Filter = "xml files (*.xml)|*.xml";
            svfSaveToXml.FilterIndex = 1;
            svfSaveToXml.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            svfSaveToXml.RestoreDirectory = true;
            if (svfSaveToXml.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializerAcc = new XmlSerializer(typeof(AccountStudentContainer));
                
                using (XmlWriter writer = XmlWriter.Create(svfSaveToXml.FileName))
                {
                    try
                    {
                        serializerAcc.Serialize(writer, Container);                        
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        
                        throw ex;
                    }
                }
            }
        }//end of serialize button


    }//end of class
}
