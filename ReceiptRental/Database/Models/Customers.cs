﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReceiptRental.Database.Models
{
  public class Customers
    {
        public int Id { get; set; }

        public DateTime DateCreate { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Location { get; set; }

        public string City { get; set; }

    }
}
