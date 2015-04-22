using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    //class used for event handling
    public class AccountArgs : EventArgs
    {
        public Account Account { get; set; }
    }
}
