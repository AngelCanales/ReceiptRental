﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReceiptRental.Database.Models
{
   public class Inventories
    {
        public int Id { get; set; }

        public int IdProduct { get; set; }

        public int Existence { get; set; }
    }
}
