// <copyright file="ReceiptManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Receipt
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Repositories;

    public class ReceiptManager : IReceiptManager
    {
        private readonly IRepository<ReceiptRental.Database.Models.Receipt> receipt;

        public ReceiptManager(IRepository<ReceiptRental.Database.Models.Receipt> receipt)
        {
            this.receipt = receipt;
        }

        public async Task CreateAsync(Database.Models.Receipt receipts)
        {
            this.receipt.Create(receipts);
            await this.receipt.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.Receipt receipts)
        {
            this.receipt.Delete(receipts);
            await this.receipt.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.Receipt receipts)
        {
            this.receipt.Update(receipts);
            await this.receipt.SaveChangesAsync();
        }

        public async Task<Database.Models.Receipt> FindByIdAsync(int id)
        {
            var receipts = await this.receipt.All().FirstOrDefaultAsync(w => w.Id == id);
            return receipts;
        }

        public async Task<IEnumerable<Database.Models.Receipt>> GetAllAsync()
        {
            var receipts = await this.receipt.All().ToListAsync();
            return receipts;
        }
    }
}
