﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class MyMissingTokenException : ArgumentException
    {
        public MyMissingTokenException(string message) : base(message)
        {
        }
    }
}
