// <copyright file="OwnerManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Owner
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Repositories;

    public class OwnerManager : IOwnerManager
    {
        private readonly IRepository<ReceiptRental.Database.Models.Owner> owner;

        public OwnerManager(IRepository<ReceiptRental.Database.Models.Owner> owner)
        {
            this.owner = owner;
        }

        public async Task CreateAsync(Database.Models.Owner owner)
        {
            this.owner.Create(owner);
            await this.owner.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.Owner owner)
        {
            this.owner.Delete(owner);
            await this.owner.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.Owner owner)
        {
            this.owner.Update(owner);
            await this.owner.SaveChangesAsync();
        }

        public async Task<Database.Models.Owner> FindByIdAsync(int id)
        {
            var owner = await this.owner.All().FirstOrDefaultAsync(w => w.Id == id);
            return owner;
        }

        public async Task<IEnumerable<Database.Models.Owner>> GetAllAsync()
        {
            var owner = await this.owner.All().ToListAsync();
            return owner;
        }
    }
}
