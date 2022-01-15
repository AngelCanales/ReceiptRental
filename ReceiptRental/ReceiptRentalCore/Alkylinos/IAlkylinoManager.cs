// <copyright file="IAlkylinoManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Alkylinos
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAlkylinoManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Alkylino>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Alkylino> FindByIdAsync(int id);

        Task CreateAsync(ReceiptRental.Database.Models.Alkylino alkylino);

        Task EditAsync(ReceiptRental.Database.Models.Alkylino alkylino);

        Task DeleteAsync(ReceiptRental.Database.Models.Alkylino alkylino);
    }
}
