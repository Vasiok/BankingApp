using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{

    //model class for transfer records  that are needed in our database
    public class TransferRecord
    {
        public int TransferId { get; set; }
        public string RecepientName { get; set; }
        public int DebitedAccount { get; set; }
        public int TransactionNumber { get; set; }
        public string DestinationSortCode { get; set; }
        public int DestinationAccNo { get; set; }
        public int TransferAmmount { get; set; }
        public DateTime TransferDate { get; set; }
        public string TransferDescription { get; set; }
    }
}
