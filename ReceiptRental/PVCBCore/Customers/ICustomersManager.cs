using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Customers
{
  public interface ICustomersManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Customers>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Customers> FindByIdAsync(int id);
  
        Task CreateAsync(ReceiptRental.Database.Models.Customers customers);

        Task EditAsync(ReceiptRental.Database.Models.Customers customers);

        Task DeleteAsync(ReceiptRental.Database.Models.Customers customers);
    }
}
