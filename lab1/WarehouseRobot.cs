using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal abstract class WarehouseRobot
    {
        public string Name { get; set; }

        public WarehouseRobot(string name)
        {
            Name = name;
        }

        public abstract void ProccessOrder(Order o);
    }
}