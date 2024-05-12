using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Beck
{
    internal class DeskQuote
    {
        public string customerName;
        public string invoiceDate;
        public Desk quoteDesk;
        public double quoteAmount = 0.0F;
        public int rushOrderDays = 0;
    }
}
