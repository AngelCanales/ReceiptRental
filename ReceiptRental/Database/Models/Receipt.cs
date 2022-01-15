// <copyright file="Receipt.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Receipt
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public decimal Amount { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public int IdOwner { get; set; }

        public Owner Owner { get; set; }

        public int IdApartments { get; set; }

        public Apartments Apartments { get; set; }

        public int IdPaymentTypes { get; set; }

        public PaymentTypes PaymentTypes { get; set; }

        public int IdAlkylino { get; set; }

        public Alkylino Alkylino { get; set; }
    }
}
