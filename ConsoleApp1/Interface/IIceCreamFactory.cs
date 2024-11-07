﻿using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IIceCreamFactory
    {
        public IceCreamModel GetObject();
        public IceCreamModel GetObject(IceCreamModel iceCreamData);
    }
}
