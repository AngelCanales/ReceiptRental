using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Providers
{
  public interface IProvidersManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Providers>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Providers> FindByIdAsync(int id);
  
        Task CreateAsync(ReceiptRental.Database.Models.Providers providers);

        Task EditAsync(ReceiptRental.Database.Models.Providers providers);

        Task DeleteAsync(ReceiptRental.Database.Models.Providers providers);
    }
}
