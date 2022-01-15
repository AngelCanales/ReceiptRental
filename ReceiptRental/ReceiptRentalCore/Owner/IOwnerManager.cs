// <copyright file="IOwnerManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Owner
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOwnerManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Owner>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Owner> FindByIdAsync(int id);

        Task CreateAsync(ReceiptRental.Database.Models.Owner alkylino);

        Task EditAsync(ReceiptRental.Database.Models.Owner alkylino);

        Task DeleteAsync(ReceiptRental.Database.Models.Owner alkylino);
    }
}
