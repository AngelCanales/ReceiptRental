﻿using ImTools;
using ReceiptRental.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptRental.Database.Repositories
{
  public  class DetailInvoicesRepository : DbContextRepositoryBase<DetailInvoices>
    {
        public DetailInvoicesRepository(PVCBContext context)
         : base(context)
        {
        }

        public override IQueryable<DetailInvoices> All()
        {
            return this.Context.DetailInvoices;
        }

        protected DetailInvoices MapNewValuesToOld(DetailInvoices oldEntity, DetailInvoices newEntity)
        {
            oldEntity.Description = newEntity.Description;
            oldEntity.TotalItem = newEntity.TotalItem;
            oldEntity.Price = newEntity.Price;
            oldEntity.Quantity = newEntity.Quantity;
            oldEntity.IdProduct = newEntity.IdProduct;
            oldEntity.CodeProduct = newEntity.CodeProduct;
            oldEntity.Tax = newEntity.Tax;
            oldEntity.Discount = newEntity.Discount;
            return oldEntity;
        }
    }
}
