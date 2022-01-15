using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.PVCBCore.Inventories
{
  public interface IInventoriesManager
    {
        Task<IEnumerable<ReceiptRental.Database.Models.Inventories>> GetAllAsync();

        Task<ReceiptRental.Database.Models.Inventories> FindByIdAsync(int id);
  
        Task CreateAsync(ReceiptRental.Database.Models.Inventories inventories);

        Task EditAsync(ReceiptRental.Database.Models.Inventories inventories);

        Task DeleteAsync(ReceiptRental.Database.Models.Inventories inventories);
    }
}
