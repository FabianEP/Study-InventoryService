using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryService.Application.Application.Abstractions;

namespace InventoryService.Application.Application
{
    public class AppService : IAppService
    {
        public void AnnualRepports()
        {
            throw new NotImplementedException();
        }

        public void CreateInventory(object inventory)
        {
            // TODO: Log Exception 
            throw new NotImplementedException();
        }

        public void DeleteInventory(Guid Id)
        {
            throw new NotImplementedException();
        }

        public object GetInventory(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(Guid Id, object inventory)
        {
            throw new NotImplementedException();
        }
    }
}
