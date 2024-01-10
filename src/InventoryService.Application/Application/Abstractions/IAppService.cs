using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Application.Application.Abstractions
{
    public interface IAppService
    {
        void CreateInventory(object inventory);

        void DeleteInventory(Guid Id);

        void UpdateInventory(Guid Id, object inventory);
        
        object GetInventory(Guid Id);

        void AnnualRepports();
    }
}
