﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReceiptRental.Models
{
  public class ProductsModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public decimal? Price { get; set; }

        public decimal? Cost { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public int Existence { get; set; }

        public string ExistenceText { get; set; }

        public byte[] Image { get; set; }
    }
}
