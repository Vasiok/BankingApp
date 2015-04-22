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
    public partial class SearchExistingStudents : Form
    {
        BLLAccountManager manager = new BLLAccountManager();

        List<Student> students = new List<Student>();

        Student Student = new Student();

        

        // Publishing the event
        public event EventHandler<StudentArgs> OnStudentSelected;

        public SearchExistingStudents()
        {
            InitializeComponent();            

        }



        private void SearchExistingStudents_Load(object sender, EventArgs e)
        {            
            students = manager.getStudents();
            dgvDisplay.DataSource = students;
        }


        // Method to search for student by name and surname
        public List<Student> searchByFANDLnames()
        {
            List<Student> resultList = new List<Student>();


            // this will get the list of students that have name and last name as provided in our text boxes
            // using "where" and lambda expression
            resultList = students.Where(Student => (Student.FirstName.ToUpper().Equals(txtFirstName.Text.ToUpper())) && (Student.LastName.ToUpper().Equals(txtLastName.Text.ToUpper()))).ToList();

            if (!resultList.Any())
            {
                MessageBox.Show("Student not found");
            }

            return resultList;

        }//end of searchByFANDLnames


        //search button click
        //here we use different options in order to accomodate search by first name or second name only
        //or by both
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Student> studs = new List<Student>(1);

            if (txtFirstName.Text.Equals(String.Empty) && txtLastName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please enter student Name");
            }
            else if (! txtFirstName.Text.Equals(String.Empty) &&  !txtLastName.Text.Equals(String.Empty))
            {
                 studs = searchByFANDLnames(); 
            }
            else if (!txtFirstName.Text.Equals(String.Empty))
            {
                studs = searchByFname();
            }
            else
            {
                studs = searchByLname();
            }


            if (studs.Any())
            {
                dgvDisplay.DataSource = studs; //set dvg to results if there are students found
            }
            
        }//end of search click


        //method will return list of account that have the same surname associated with them
        //as the one entered by user
        private List<Student> searchByLname()
        {
            List<Student> resultList = new List<Student>();


            // this will get the list of students that have name and last name as provided in our text boxes
            // using "where" and lambda expression
            resultList = students.Where(Student => (Student.LastName.ToUpper().Equals(txtLastName.Text.ToUpper()))).ToList();

            if (!resultList.Any())
            {
                MessageBox.Show("Student not found");
            }

            return resultList;
        }//end of searchByLname


        //search by first name only
        private List<Student> searchByFname()
        {
            List<Student> resultList = new List<Student>();


            // this will get the list of students that have name and last name as provided in our text boxes
            // using "where" and lambda expression
            resultList = students.Where(Student => (Student.FirstName.ToUpper().Equals(txtFirstName.Text.ToUpper()))).ToList();

            if (!resultList.Any())
            {
                MessageBox.Show("Student not found");
            }

            return resultList;
        }//end of searchByFname



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of back button


        // getting values from selected row and creating an instance of Student object and pass that to 
        // NewAccount where I need to populate the fields relevant to students from this class
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int studId = Convert.ToInt32(dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentID)].Value);
            string fName = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentFName)].Value.ToString();
            string studLName = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentLName)].Value.ToString();
            string studEmail = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentEmail)].Value.ToString();
            string studPhone = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentPhone)].Value.ToString();
            string studAddr1 = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentAddress1)].Value.ToString();
            string studAddr2 = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentAddress2)].Value.ToString();
            string studCity = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentCity)].Value.ToString();
            string studCounty = dgvDisplay.CurrentRow.Cells[Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentCounty)].Value.ToString();

            Student stud = new Student(studId, fName, studLName, studEmail, studPhone, studAddr1, studAddr2, studCity, studCounty);

            if (stud != null)
            {
                StudentArgs sArg = new StudentArgs();
                sArg.Student = stud;
                OnStudentSelected(this, sArg);


                this.Close(); 
            }
            else
            {
                MessageBox.Show("Please make a selection");
            }
        }//end of select button


        //method to repopulate the datagrid with list of all students
        private void btnDisplayAllStuds_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = students;
        }//end of repopulate
    }
}
