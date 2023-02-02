using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class PackingRobot : WarehouseRobot
    {
        public PackingRobot(string name) : base(name)
        {
        }

        public override void ProccessOrder(Order o)
        {
            o.State = "Packed";
        }
    }
}