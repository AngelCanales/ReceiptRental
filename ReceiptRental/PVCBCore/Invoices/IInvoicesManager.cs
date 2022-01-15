using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Invoices
{
  public interface IInvoicesManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Invoices>> GetAllAsync();

        Task<IEnumerable<ReceiptRental.Database.Models.Invoices>> GetAllByDateAsync(DateTime date);

        Task<IEnumerable<ReceiptRental.Database.Models.Invoices>> GetAllByDateYearAsync(DateTime datestar, DateTime dateend);

        Task<ReceiptRental.Database.Models.Invoices> FindByIdAsync(int id);

        Task<ReceiptRental.Database.Models.Invoices> FindByNumberInvoicesAsync(string number);

        Task<ReceiptRental.Database.Models.Invoices> FindAllByDateAsync(DateTime date);

        Task CreateAsync(ReceiptRental.Database.Models.Invoices invoices);

        Task EditAsync(ReceiptRental.Database.Models.Invoices invoices);

        Task DeleteAsync(ReceiptRental.Database.Models.Invoices invoices);
    }
}
