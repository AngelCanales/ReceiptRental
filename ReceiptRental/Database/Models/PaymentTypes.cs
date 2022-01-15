// <copyright file="PaymentTypes.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PaymentTypes
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
