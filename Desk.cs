using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskApp
{

    public partial class Desk
    {
        public decimal Width = 0, Depth = 0, TotalSize = 0;
        public decimal Drawers = 0;
        public string Material = "";
        public int DeliveryTime = 0;
        public Desk(decimal Width, decimal Depth, string Material, int deliveryTime, int drawers)
        {
            this.Width = Width;
            this.Depth = Depth;
            this.Material = Material;
            this.DeliveryTime = deliveryTime;
            this.Drawers = drawers;
        }
    }
}
