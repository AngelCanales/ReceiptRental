// <copyright file="ApartmentsManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Apartments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Repositories;

    public class ApartmentsManager : IApartmentsManager
    {
        private readonly IRepository<ReceiptRental.Database.Models.Apartments> apartments;

        public ApartmentsManager(IRepository<ReceiptRental.Database.Models.Apartments> apartments)
        {
            this.apartments = apartments;
        }

        public async Task CreateAsync(Database.Models.Apartments apartment)
        {
            this.apartments.Create(apartment);
            await this.apartments.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.Apartments apartment)
        {
            this.apartments.Delete(apartment);
            await this.apartments.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.Apartments apartment)
        {
            this.apartments.Update(apartment);
            await this.apartments.SaveChangesAsync();
        }

        public async Task<Database.Models.Apartments> FindByIdAsync(int id)
        {
            var apartment = await this.apartments.All().FirstOrDefaultAsync(w => w.Id == id);
            return apartment;
        }

        public async Task<IEnumerable<Database.Models.Apartments>> GetAllAsync()
        {
            var apartment = await this.apartments.All().ToListAsync();
            return apartment;
        }
    }
}
