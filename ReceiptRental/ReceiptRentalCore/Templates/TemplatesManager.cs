// <copyright file="TemplatesManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.ReceiptRentalCore.Templates
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Repositories;

    public class TemplatesManager : ITemplatesManager
    {
        private readonly IRepository<ReceiptRental.Database.Models.Templates> templates;

        public TemplatesManager(IRepository<ReceiptRental.Database.Models.Templates> templates)
        {
            this.templates = templates;
        }

        public async Task CreateAsync(Database.Models.Templates template)
        {
            this.templates.Create(template);
            await this.templates.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.Templates template)
        {
            this.templates.Delete(template);
            await this.templates.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.Templates template)
        {
            this.templates.Update(template);
            await this.templates.SaveChangesAsync();
        }

        public async Task<Database.Models.Templates> FindByIdAsync(int id)
        {
            var template = await this.templates.All().FirstOrDefaultAsync(w => w.Id == id);
            return template;
        }

        public async Task<IEnumerable<Database.Models.Templates>> GetAllAsync()
        {
            var template = await this.templates.All().ToListAsync();
            return template;
        }
    }
}
