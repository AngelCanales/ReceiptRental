namespace ReceiptRental.ReceiptRentalSeedData
{
    using System;
    using System.Threading.Tasks;
    using ReceiptRental.Database;
    using ReceiptRental.Database.Models;

    public class ReceiptRentalSeedData
    {
        public static async Task EnsureReceiptRentalSeedData(ReceiptRentalContext context)
        {
            bool exist = false;

            try
            {
                SQLitePCL.Batteries_V2.Init();
                exist = context.Database.EnsureCreated();
            }
            catch (Exception)
            {
            }

            if (!exist)
            {
                return;
            }

            await InsertData(context);
        }

        private static async Task InsertData(ReceiptRentalContext context)
        {
            context.Add(new PaymentTypes { Code = "10", Description = "Mensual" });
            context.Add(new PaymentTypes { Code = "10", Description = "Quincenal" });
            context.Add(new Owner { IdCard = "0512199100330", Name = "Maria Argentina Guardado Trochez" });
            context.Add(new Templates { Template = "0512199100330", Name = "TemplateReceipt" });
            await context.SaveChangesAsync();
        }
    }
}
