using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Products
{
  public interface IProductsManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Products>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Products> FindByIdAsync(int id);
  
        Task CreateAsync(ReceiptRental.Database.Models.Products invoices);

        Task EditAsync(ReceiptRental.Database.Models.Products invoices);

        Task DeleteAsync(ReceiptRental.Database.Models.Products invoices);
    }
}
