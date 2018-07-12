﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            photoProcessor.Process(string.Empty);
        }
    }
}
