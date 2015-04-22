using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataModel;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALAccountManager
    {

        //pulling connection string from configuration manager
        private string connectionString = ConfigurationManager.ConnectionStrings["dbConString"].ConnectionString;

        //Method to add new account
        //Creating sql connection and configuring all the parameters here in order to use stored procedure
        public bool AddAccount(Account acc, out int accountNum)
        {
            bool retVal = false;
            accountNum = 0;
            
            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spCreateAccount", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter accType = new SqlParameter("@AccountType", acc.AccountType);
                    cmd.Parameters.Add(accType);

                    SqlParameter sCode = new SqlParameter("@SortCode", acc.SortCode);
                    cmd.Parameters.Add(sCode);

                    SqlParameter initBal = new SqlParameter("@InitialBalance", acc.InitialBalance);
                    cmd.Parameters.Add(initBal);

                    SqlParameter currentBal = new SqlParameter("@CurrentBalance", acc.CurrentBalance);
                    cmd.Parameters.Add(currentBal);

                    SqlParameter overdraftLimit = new SqlParameter("@OverdraftLimit", acc.OverDraftLimit);
                    cmd.Parameters.Add(overdraftLimit);

                    SqlParameter stdId = new SqlParameter("@StudentId", acc.StudentID);
                    cmd.Parameters.Add(stdId);

                    SqlParameter accnumberOut = new SqlParameter("@AccountNum", SqlDbType.Int);
                    accnumberOut.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(accnumberOut);

                    cxn.Open();

                    int i = cmd.ExecuteNonQuery();

                    cxn.Close();

                    if (i > 0)
                    {
                        retVal = true;
                        accountNum = Convert.ToInt32(accnumberOut.Value);
                    }


                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


            return retVal;
        }//end of AddAccount



        //Method to add new student
        public bool addStudent(Student stud, out int studID)
        {
            bool retVal = false;
            studID = 0;

            try
            {

                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spCreateStudent", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter studFName = new SqlParameter("@FirstName", stud.FirstName);
                    cmd.Parameters.Add(studFName);

                    SqlParameter studLName = new SqlParameter("@LastName", stud.LastName);
                    cmd.Parameters.Add(studLName);

                    SqlParameter email = new SqlParameter("@Email", stud.Email);
                    cmd.Parameters.Add(email);

                    SqlParameter phone = new SqlParameter("@PhoneNumber",stud.Phone);
                    cmd.Parameters.Add(phone);

                    SqlParameter addr1 = new SqlParameter("@Address1", stud.Address1);
                    cmd.Parameters.Add(addr1);

                    SqlParameter addr2 = new SqlParameter("@Address2", stud.Address2);
                    cmd.Parameters.Add(addr2);


                    SqlParameter city = new SqlParameter("@City", stud.City);
                    cmd.Parameters.Add(city);

                    SqlParameter county = new SqlParameter("@County", stud.County);
                    cmd.Parameters.Add(county);

                    SqlParameter studIdOut = new SqlParameter("@StudentId", SqlDbType.Int);
                    studIdOut.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(studIdOut);

                    cxn.Open();

                    int i = cmd.ExecuteNonQuery();

                    cxn.Close();
                    studID = Convert.ToInt32(studIdOut.Value);

                    if (i > 0)
                    {
                        retVal = true;
                        studID = Convert.ToInt32(studIdOut.Value);
                    }


                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return retVal;

        }//end of addStudent



        //Method to  retrieve all students details from the database
        public List<Student> getStudents()
        {
            // specifing a min of 5 for Data Management
            List<Student> students = new List<Student>(5);

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetStudents", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cxn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //getting values for student from reader
                        int studId = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentID)));
                        string studFName = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentFName)).ToString();
                        string studLname = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentLName)).ToString();
                        string studEmail = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentEmail)).ToString();
                        string studphone = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentPhone)).ToString();
                        string studAddrOne = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentAddress1)).ToString();
                        string studAddrTwo = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentAddress2)).ToString();
                        string studCity = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentCity)).ToString();
                        string studCounty = reader.GetValue(Convert.ToInt32(OOP2_SGetStudents.SPGetStudents_StudentCounty)).ToString();

                        //creating student object
                        Student stud = new Student(studId, studFName, studLname, studEmail, studphone, studAddrOne, studAddrTwo, studCity, studCounty);

                        students.Add(stud);
                    }
                    //closing the reader
                    reader.Close();

                    //closing the connection
                    cxn.Close();
                }


            }
            catch (Exception ex)
            {
                
                throw ex;
            }
    

            return students;
        }//end of getStudents



       // getting all accounts information out to main display
        public List<Account> GetAccountDetailsAsList()
        {
            // memory management technique used here
            List<Account> AccDetailsList = new List<Account>(10);

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAccountDetails", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cxn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int accNo = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_AccountNo)));
                        string accType =  reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_AccountType)).ToString();
                        int sortCode = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_SortCode)));
                        int initBalance = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_InitialBalance)));
                        int currentBal = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_CurrentBalance)));
                        int overDraftLimit = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_OverDraftLimit)));
                        int studID = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_StudentID)));
						
						Account acc = new Account(accNo, accType, sortCode, initBalance, currentBal, overDraftLimit, studID);

                        AccDetailsList.Add(acc);
                    }

                    reader.Close();
                    cxn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw;
            }

            return AccDetailsList;
        }//end of GetAccountDetailsAsList



        //method to edit student details in the database
        public bool EditStudentDetails(Student stu)
        {
            bool retVal = false;

            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spEditStudentDetails", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter email = new SqlParameter("@email", stu.Email);
                    cmd.Parameters.Add(email);

                    SqlParameter phone = new SqlParameter("@phone", stu.Phone);
                    cmd.Parameters.Add(phone);

                    SqlParameter add1 = new SqlParameter("@add1", stu.Address1);
                    cmd.Parameters.Add(add1);

                    SqlParameter add2 = new SqlParameter("@add2", stu.Address2);
                    cmd.Parameters.Add(add2);

                    SqlParameter city = new SqlParameter("@city", stu.City);
                    cmd.Parameters.Add(city);

                    SqlParameter county = new SqlParameter("@county", stu.County);
                    cmd.Parameters.Add(county);

                    SqlParameter stdId = new SqlParameter("@studID", stu.StudentID);
                    cmd.Parameters.Add(stdId);

                    // opening the connection
                    cxn.Open();

                    // executing th equery
                    int i = cmd.ExecuteNonQuery();

                    // closing the connection
                    cxn.Close();

                    if (i > 0)
                    {
                        retVal = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return retVal;
        }//end of EditStudentDetails


        //this method is only to get the data related to external transfers account
        public Account GetAccountRecord(int accNumber)
        {
            Account acc = new Account();
            try
            {
                using (SqlConnection cxn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAccount", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter accNo = new SqlParameter("@accNo", accNumber);
                    cmd.Parameters.Add(accNo);

                    cxn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int accNoo = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_AccountNo)));
                        string accType =  reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_AccountType)).ToString();
                        int sortCode = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_SortCode)));
                        int initBalance = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_InitialBalance)));
                        int currentBal = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_CurrentBalance)));
                        int overDraftLimit = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_OverDraftLimit)));
                        int studID = Convert.ToInt32(reader.GetValue(Convert.ToInt32(OOP2_SGetAccounts.SPGetAccounts_StudentID)));
						
						Account acc1 = new Account(accNoo, accType, sortCode, initBalance, currentBal, overDraftLimit, studID);

                        acc = acc1;
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return acc;
        }


    }
}
