// <copyright file="IPaymentTypesManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.PaymentTypes
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPaymentTypesManagers
    {
        Task<IEnumerable<ReceiptRental.Database.Models.PaymentTypes>> GetAllAsync();

        Task<ReceiptRental.Database.Models.PaymentTypes> FindByIdAsync(int id);

        Task CreateAsync(ReceiptRental.Database.Models.PaymentTypes paymentTypes);

        Task EditAsync(ReceiptRental.Database.Models.PaymentTypes paymentTypes);

        Task DeleteAsync(ReceiptRental.Database.Models.PaymentTypes paymentTypes);
    }
}
