// <copyright file="ITemplatesManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Templates
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITemplatesManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Templates>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Templates> FindByIdAsync(int id);

        Task CreateAsync(ReceiptRental.Database.Models.Templates templates);

        Task EditAsync(ReceiptRental.Database.Models.Templates templates);

        Task DeleteAsync(ReceiptRental.Database.Models.Templates templates);
    }
}
