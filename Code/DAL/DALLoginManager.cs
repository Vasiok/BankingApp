using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// adding using directives
using System.Data.SqlClient; 
using System.Configuration; // added reference
using System.ComponentModel;
using System.Data; // for the CommandType

namespace DAL
{
    public class DALLogInManager
    {
        //pulling connection string from configuration manager
        string cxnString = ConfigurationManager.ConnectionStrings["dbConString"].ConnectionString;


        //Method that uses stored procedure in order to check username and password of the person in order to use the databse
        public bool CheckLogin(string UserName, string UserPassword)
        {
            bool work = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cxnString))
                {
                    // calling the stored procedure
                    SqlCommand cmd = new SqlCommand("uspCheckLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter userNameParm = new SqlParameter("@UserName", SqlDbType.NVarChar, 40);
                    userNameParm.Value = UserName;

                    SqlParameter passwordParm = new SqlParameter("@UserPassword", SqlDbType.NVarChar, 40);
                    passwordParm.Value = UserPassword;

                    SqlParameter userIdParm = new SqlParameter("@UserID", SqlDbType.Int, 4);
                    userIdParm.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(userNameParm);
                    cmd.Parameters.Add(passwordParm);
                    cmd.Parameters.Add(userIdParm);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // execute query
                    conn.Close();

                    string result = userIdParm.Value.ToString();

                    if (string.IsNullOrEmpty(result)) // if the string is empty, there was no username, password match
                    {
                        work = false;
                    }
                    else
                    {
                        work = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return work;
        }//end of CheckLogin
    }
}
