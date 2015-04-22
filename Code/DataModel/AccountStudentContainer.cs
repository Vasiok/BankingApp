using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    //This class is to acomodate the serialization of account and student details
    public class AccountStudentContainer
    {
        public Account Account { get; set; }
        public Student Student { get; set; }

    }
}
