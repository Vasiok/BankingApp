using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    //Used class here to hold regex
    public class Expressions
    {
        // the names of the fields are self explanitary
        public static string FirstName = @"^([A-Z]{1}([a-z]*)?\s?([A-Z]{1}([a-z]*)?)?)[a-z]$";
        public static string LastName = @"^[A-Z]{1}[']?[a-z]*[']?[A-Za-z]*?[a-z]$";
        public static string Email =@"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})";
        public static string Phone = @"^[0-9]{2,3}[-][0-9]{7}$";
        public static string Address = @"^[0-9A-Za-z][0-9A-Za-z'\s]*[a-z0-9]$";
        public static string City = @"^[A-Z][a-z]*$";
        public static string Money = @"^[0-9]*([.][0-9]{2})?$";
    }
}
