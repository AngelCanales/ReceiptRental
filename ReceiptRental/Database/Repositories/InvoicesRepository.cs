﻿using ReceiptRental.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptRental.Database.Repositories
{
   public class InvoicesRepository : DbContextRepositoryBase<Invoices>
    {
        public InvoicesRepository(PVCBContext context)
         : base(context)
        {
        }

        public override IQueryable<Invoices> All()
        {
            return this.Context.Invoices;
        }

        protected Invoices MapNewValuesToOld(Invoices oldEntity, Invoices newEntity)
        {
            oldEntity.Date = newEntity.Date;
            oldEntity.Description = newEntity.Description;
            oldEntity.InvoicesTypes = newEntity.InvoicesTypes;
            oldEntity.Total = newEntity.Total;
            oldEntity.DetailInvoices = newEntity.DetailInvoices;
            oldEntity.NumFactura = newEntity.NumFactura;
            oldEntity.Cash = newEntity.Cash;
            oldEntity.Tax = newEntity.Tax;
            oldEntity.Exchange = newEntity.Exchange;
            oldEntity.IdCustomer = newEntity.IdCustomer;
            oldEntity.IdProvider = newEntity.IdProvider;
            oldEntity.CodeCustomer = newEntity.CodeCustomer;
            oldEntity.CodeProvider = newEntity.CodeProvider;
            return oldEntity;
        }
    }
}

