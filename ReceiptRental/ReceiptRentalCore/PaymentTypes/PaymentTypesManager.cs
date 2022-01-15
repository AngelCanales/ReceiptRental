// <copyright file="PaymentTypesManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.PaymentTypes
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Repositories;

    public class PaymentTypesManager : IPaymentTypesManagers
    {
        private readonly IRepository<ReceiptRental.Database.Models.PaymentTypes> paymentTypes;

        public PaymentTypesManager(IRepository<ReceiptRental.Database.Models.PaymentTypes> paymentTypes)
        {
            this.paymentTypes = paymentTypes;
        }

        public async Task CreateAsync(Database.Models.PaymentTypes paymentType)
        {
            this.paymentTypes.Create(paymentType);
            await this.paymentTypes.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.PaymentTypes paymentType)
        {
            this.paymentTypes.Delete(paymentType);
            await this.paymentTypes.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.PaymentTypes paymentType)
        {
            this.paymentTypes.Update(paymentType);
            await this.paymentTypes.SaveChangesAsync();
        }

        public async Task<Database.Models.PaymentTypes> FindByIdAsync(int id)
        {
            var paymentType = await this.paymentTypes.All().FirstOrDefaultAsync(w => w.Id == id);
            return paymentType;
        }

        public async Task<IEnumerable<Database.Models.PaymentTypes>> GetAllAsync()
        {
            var paymentType = await this.paymentTypes.All().ToListAsync();
            return paymentType;
        }
    }
}
