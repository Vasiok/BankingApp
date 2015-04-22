using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// adding using directives
using DAL;

namespace BLL
{
    public class BLLLogInManager
    {


        //Method to check user name and password
        public bool CheckLogin(string UserName, string UserPassword)
        {
            DALLogInManager dalLoginMngr = new DALLogInManager();

            bool retVal = false;

            retVal = dalLoginMngr.CheckLogin(UserName, UserPassword);

            return retVal;
        }//end of CheckLogin
    }
}
