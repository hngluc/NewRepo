﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_04.models
{
    internal class ViewModel
    {
        public string InvoiceNo { get; set; }
        public int No { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string InvoiceNote { get; set; }  
    }
}


