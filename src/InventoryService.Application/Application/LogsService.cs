using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Application.Application
{
    public class LogsService
    {
        public Task<Object> LogsService(Task<object> action) 
        {
            try 
            {
                //TODO: AppService -> LogService -> Domain Layer
                return await action();   
            }
            catch (Exception ex)
            {
                // Create file
                // Persist Log exception

                throw;
            }
        }
        
    }
}
