using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{

    public enum OOP2_SGetStudents
    {
        SPGetStudents_StudentID = 0,
        SPGetStudents_StudentFName,
        SPGetStudents_StudentLName,
        SPGetStudents_StudentEmail,
        SPGetStudents_StudentPhone,
        SPGetStudents_StudentAddress1,
        SPGetStudents_StudentAddress2,
        SPGetStudents_StudentCity,
        SPGetStudents_StudentCounty
    }

    //Class to model student records in the database
    public class Student
    {
        // properties       
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        /*
         * Needed to use two different constructors here as they way we 
         * can create this class differs a bit
         */


        //constructor to use in passing allready existing student
        public Student(int stdId, string fName, string lName, string email, string phone, string addrOne, string addrTwo, string city, string county)
        {
            StudentID = stdId;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Phone = phone;
            Address1 = addrOne;
            Address2 = addrTwo;
            City = city;
            County = county;
        }


        // constructor to use for creating new student
        public Student(string fName, string lName, string email, string phone, string addrOne, string addrTwo, string city, string county)
        {            
            FirstName = fName;
            LastName = lName;
            Email = email;
            Phone = phone;
            Address1 = addrOne;
            Address2 = addrTwo;
            City = city;
            County = county;
        }


        //Default constructior
        public Student()
        {

        }
        
    }
}
