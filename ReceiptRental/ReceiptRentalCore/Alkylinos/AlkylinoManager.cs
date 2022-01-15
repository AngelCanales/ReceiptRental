// <copyright file="AlkylinoManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Alkylinos
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Repositories;

    public class AlkylinoManager : IAlkylinoManager
    {
        private readonly IRepository<ReceiptRental.Database.Models.Alkylino> alkylino;

        public AlkylinoManager(IRepository<ReceiptRental.Database.Models.Alkylino> alkylino)
        {
            this.alkylino = alkylino;
        }

        public async Task CreateAsync(Database.Models.Alkylino nalkylino)
        {
            this.alkylino.Create(nalkylino);
            await this.alkylino.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.Alkylino nalkylino)
        {
            this.alkylino.Delete(nalkylino);
            await this.alkylino.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.Alkylino nalkylino)
        {
            this.alkylino.Update(nalkylino);
            await this.alkylino.SaveChangesAsync();
        }

        public async Task<Database.Models.Alkylino> FindByIdAsync(int id)
        {
            var nalkylino = await this.alkylino.All().FirstOrDefaultAsync( w => w.Id == id);
            return nalkylino; 
        }

        public async Task<IEnumerable<Database.Models.Alkylino>> GetAllAsync()
        {
            var nalkylino = await this.alkylino.All().ToListAsync();
            return nalkylino;
        }
    }
}
