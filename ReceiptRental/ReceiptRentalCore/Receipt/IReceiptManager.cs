// <copyright file="IReceiptManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Receipt
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IReceiptManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Receipt>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Receipt> FindByIdAsync(int id);

        Task CreateAsync(ReceiptRental.Database.Models.Receipt receipt);

        Task EditAsync(ReceiptRental.Database.Models.Receipt receipt);

        Task DeleteAsync(ReceiptRental.Database.Models.Receipt receipt);
    }
}
