using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    //Class used for event handling
    public class StudentArgs : EventArgs
    {
        public Student Student { get; set; }
    }
}
