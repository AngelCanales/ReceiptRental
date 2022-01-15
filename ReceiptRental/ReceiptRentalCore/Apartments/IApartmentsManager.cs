// <copyright file="IApartmentsManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Apartments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApartmentsManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Apartments>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Apartments> FindByIdAsync(int id);

        Task CreateAsync(ReceiptRental.Database.Models.Apartments apartments);

        Task EditAsync(ReceiptRental.Database.Models.Apartments apartments);

        Task DeleteAsync(ReceiptRental.Database.Models.Apartments apartments);
    }
}
