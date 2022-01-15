// <copyright file="DbContextRepositoryBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental.Database.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DbContextRepositoryBase<TEntity> : RepositoryBase<TEntity, ReceiptRentalContext>
         where TEntity : class
    {
        public DbContextRepositoryBase(ReceiptRentalContext context)
            : base(context)
        {
            this.Context = context;
        }
    }
}
