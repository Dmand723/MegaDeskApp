using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskApp
{
    public partial class DeskQuote
    {
        public string customerName = "";
        public string orderDate;
        public Desk? desk;
        public double price = 0.00;
        public DeskQuote(string customerName, string orderDate, Desk desk)
        {
            this.customerName = customerName;
            this.orderDate = orderDate;
            this.desk = desk;
        }

    }
}
