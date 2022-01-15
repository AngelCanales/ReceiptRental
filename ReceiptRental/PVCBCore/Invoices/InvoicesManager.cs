﻿using Microsoft.EntityFrameworkCore;
using ReceiptRental.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Invoices
{
    public class InvoicesManager : IInvoicesManager
    {
        private readonly IRepository<ReceiptRental.Database.Models.Invoices> invoices;
        private readonly IRepository<ReceiptRental.Database.Models.DetailInvoices> detailInvoices;

        public InvoicesManager(IRepository<ReceiptRental.Database.Models.Invoices> invoices, IRepository<ReceiptRental.Database.Models.DetailInvoices> detailInvoices)
        {
            this.invoices = invoices;
            this.detailInvoices = detailInvoices;
        }

        public async Task CreateAsync(Database.Models.Invoices invoices)
        {
            this.invoices.Create(invoices);
            await this.invoices.SaveChangesAsync();
        }

        public async Task DeleteAsync(Database.Models.Invoices invoices)
        {
            
            this.invoices.Delete(invoices);
            await this.invoices.SaveChangesAsync();
        }

        public async Task EditAsync(Database.Models.Invoices invoices)
        {
            this.invoices.Update(invoices);
            await this.invoices.SaveChangesAsync();
        }

        public async Task<Database.Models.Invoices> FindAllByDateAsync(DateTime date)
        {
            var invoicesDatalist = await this.invoices.All().Include(i => i.DetailInvoices).FirstOrDefaultAsync(w => w.Date == date);
            return invoicesDatalist;
        }

        public async Task<Database.Models.Invoices> FindByIdAsync(int id)
        {
            var invoicesDatalist = await this.invoices.All().Include(i => i.DetailInvoices).FirstOrDefaultAsync( w => w.Id == id);
            return invoicesDatalist; 
        }

        public async Task<Database.Models.Invoices> FindByNumberInvoicesAsync(string number)
        {
            var invoicesDatalist = await this.invoices.All().Include(i => i.DetailInvoices).FirstOrDefaultAsync(w => w.NumFactura == number);
            return invoicesDatalist;
        }

        public async Task<IEnumerable<Database.Models.Invoices>> GetAllAsync()
        {
            var invoicesDatalist = await this.invoices.All().Include( i => i.DetailInvoices).ToListAsync();
            return invoicesDatalist;
        }

        public async Task<IEnumerable<Database.Models.Invoices>> GetAllByDateAsync(DateTime date)
        {
            var invoicesDatalist = await this.invoices.All().Where(w => w.Date.Date == date.Date ).Include(i => i.DetailInvoices).ToListAsync();
            return invoicesDatalist;
        }

        public async Task<IEnumerable<Database.Models.Invoices>> GetAllByDateYearAsync(DateTime datestar, DateTime dateend)
        {
            var invoicesDatalist = await this.invoices.All().Where(w => w.Date.Date >= datestar.Date && w.Date.Date <= dateend.Date).Include(i => i.DetailInvoices).ToListAsync();
            return invoicesDatalist;
        }
    }
}
