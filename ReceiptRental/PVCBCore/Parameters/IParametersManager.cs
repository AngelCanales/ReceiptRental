using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Parameters
{
  public interface IParametersManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Parameters>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Parameters> FindByIdAsync(string key);
  
        Task CreateAsync(ReceiptRental.Database.Models.Parameters invoices);

        Task EditAsync(ReceiptRental.Database.Models.Parameters invoices);

        Task DeleteAsync(ReceiptRental.Database.Models.Parameters invoices);
    }
}
