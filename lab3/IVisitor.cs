using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    internal interface IVisitor
    {
        public void Visit(IElement element);
    }
}