﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}