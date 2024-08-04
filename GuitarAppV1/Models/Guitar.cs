﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppV1.Models
{
    internal class Guitar
    {



        public string SerialNumber { get; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
    }
}





