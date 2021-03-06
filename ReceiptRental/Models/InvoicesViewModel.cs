using System;
using System.Collections.Generic;
using System.Text;

namespace ReceiptRental.Models
{
  public class InvoicesViewModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public decimal Total { get; set; }

        public string InvoicesTypes { get; set; }


        public string NumFactura { get; set; }

        public decimal Tax { get; set; }

        public decimal Exchange { get; set; }

        public decimal Cash { get; set; }

        public int IdCustomer { get; set; }

        public int IdProvider { get; set; }

        public string CodeCustomer { get; set; }

        public string CodeProvider { get; set; }
    }
}
