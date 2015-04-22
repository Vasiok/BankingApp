using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DataModel;

namespace BLL
{
    public class BLLAccountManager
    {
                       
        //method to return accs that match last name
        //here instead of creating another stored procedure just use the old one and do a join using LINQ and lambda expression
        public List<Account> GetAcountsByStudentLastName(string lName)
        {
            List<Account> accs = new List<Account>(2);
            List<Account> accsOut = new List<Account>(2);
            List<Student> studs = new List<Student>(10);

            accs = GetAccountDetailsAsList();
            studs = getStudents();

            //Join student account
            var studentsWithAccounts = accs.Join(studs, (a) => a.StudentID, (s) => s.StudentID, (a, s) =>
                                        new 
                                        {
                                            a.AccountNo,
                                            a.AccountType,
                                            a.SortCode,
                                            a.InitialBalance,
                                            a.CurrentBalance, 
                                            a.OverDraftLimit,
                                            a.StudentID,                                            
                                            s.LastName
                                        });
            
            //Iterating over the collection in order to get accounts that match the input string
            foreach (var sWithAcc in studentsWithAccounts)
            {
                if (sWithAcc.LastName.ToLower().Equals(lName.ToLower()))
                {
                    Account acc = new Account();
                    acc.AccountNo = sWithAcc.AccountNo;
                    acc.AccountType = sWithAcc.AccountType;
                    acc.SortCode = sWithAcc.SortCode;
                    acc.InitialBalance = sWithAcc.InitialBalance;
                    acc.CurrentBalance = sWithAcc.CurrentBalance;
                    acc.OverDraftLimit = sWithAcc.OverDraftLimit;
                    acc.StudentID = sWithAcc.StudentID;

                    accsOut.Add(acc);
                }
            }

            return accsOut;

        }//end of GetAcountsByStudentName



        //This method does the same as the above with small difference here it will compare FirsName and Surname
        public List<Account> GetAcountsByStudentName(string fName, string lName)
        {
            List<Account> accs = new List<Account>(2);
            List<Account> accsOut = new List<Account>(2);
            List<Student> studs = new List<Student>(10);

            accs = GetAccountDetailsAsList();
            studs = getStudents();

            //Join student account
            var studentsWithAccounts = accs.Join(studs, (a) => a.StudentID, (s) => s.StudentID, (a, s) =>
                                        new
                                        {
                                            a.AccountNo,
                                            a.AccountType,
                                            a.SortCode,
                                            a.InitialBalance,
                                            a.CurrentBalance,
                                            a.OverDraftLimit,
                                            a.StudentID,
                                            s.FirstName,
                                            s.LastName
                                        });

            foreach (var sWithAcc in studentsWithAccounts)
            {
                if ((sWithAcc.FirstName.ToLower().Equals(fName.ToLower())) && (sWithAcc.LastName.ToLower().Equals(lName.ToLower())))
                {
                    Account acc = new Account();
                    acc.AccountNo = sWithAcc.AccountNo;
                    acc.AccountType = sWithAcc.AccountType;
                    acc.SortCode = sWithAcc.SortCode;
                    acc.InitialBalance = sWithAcc.InitialBalance;
                    acc.CurrentBalance = sWithAcc.CurrentBalance;
                    acc.OverDraftLimit = sWithAcc.OverDraftLimit;
                    acc.StudentID = sWithAcc.StudentID;

                    accsOut.Add(acc);
                }
            }

            return accsOut;

        }//end of GetAcountsByStudentLastName


        //Yet another variation of the same method to accomodate the search usgin first name only
        public List<Account> GetAcountsByStudentFirsName(string fName)
        {
            List<Account> accs = new List<Account>(2);
            List<Account> accsOut = new List<Account>(2);
            List<Student> studs = new List<Student>(10);

            accs = GetAccountDetailsAsList();
            studs = getStudents();

            //Join student account
            var studentsWithAccounts = accs.Join(studs, (a) => a.StudentID, (s) => s.StudentID, (a, s) =>
                                        new
                                        {
                                            a.AccountNo,
                                            a.AccountType,
                                            a.SortCode,
                                            a.InitialBalance,
                                            a.CurrentBalance,
                                            a.OverDraftLimit,
                                            a.StudentID,
                                            s.FirstName                                            
                                        });

            foreach (var sWithAcc in studentsWithAccounts)
            {
                if (sWithAcc.FirstName.ToLower().Equals(fName.ToLower()))
                {
                    Account acc = new Account();
                    acc.AccountNo = sWithAcc.AccountNo;
                    acc.AccountType = sWithAcc.AccountType;
                    acc.SortCode = sWithAcc.SortCode;
                    acc.InitialBalance = sWithAcc.InitialBalance;
                    acc.CurrentBalance = sWithAcc.CurrentBalance;
                    acc.OverDraftLimit = sWithAcc.OverDraftLimit;
                    acc.StudentID = sWithAcc.StudentID;

                    accsOut.Add(acc);
                }
            }

            return accsOut;

        }//end of GetAcountsByStudentFirsName

        

        //Method to add acount and pass out account number
        //uses DAL and passes on object of type Account to it
        public bool AddAccount(Account acc, out int accNumber )
        {
            DALAccountManager manager = new DALAccountManager();

            bool retVal = false;

            retVal = manager.AddAccount(acc, out accNumber);

            return retVal;
        }//end of AddAccount



        //Method to create new Student record
        //uses DAL passing it an object of type Student
        public bool AddStudent(Student stud, out int studID)
        {
            DALAccountManager manager = new DALAccountManager();

            bool retVal = false;

            retVal = manager.addStudent(stud, out studID);

            return retVal;
        }//end of AddStudent




        //getting all the students from
        public List<Student> getStudents()
        {
            DALAccountManager manager = new DALAccountManager();

            List<Student> studs = manager.getStudents();

            return studs;
        }//end of getStudents



        // getting account information out to main display
        public List<Account> GetAccountDetailsAsList()
        {
            List<Account> AccDetailsList = null;

            DALAccountManager dalAccMngr = new DALAccountManager();

            try
            {
                AccDetailsList = dalAccMngr.GetAccountDetailsAsList();
                // This line will exclude external account from the list  displayd on main screen.
                // Using simple lambda inside LINQ
                AccDetailsList = AccDetailsList.Where(Account => Account.AccountType != "external").ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return AccDetailsList;
        }//end of GetAccountDetailsAsList



        //Method when passed a Student object will call method on DAL layer 
        //that will change the details of particular student in the database
        public bool EditStudentDetails(Student stu)
        {
            DALAccountManager dalAccMngr = new DALAccountManager();

            bool retVal = false;

            retVal = dalAccMngr.EditStudentDetails(stu);

            return retVal;
        }//end of EditStudentDetails


        //getting one account details by using accNumber
        public Account GetAccountRecord(int accountNumber)
        {
            Account acc = new Account();
            DALAccountManager manager = new DALAccountManager();

            acc = manager.GetAccountRecord(accountNumber);

            return acc;
        }

    }
}
