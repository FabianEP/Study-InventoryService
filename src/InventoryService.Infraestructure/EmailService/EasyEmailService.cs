using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryService.Infrastructure.EmailService.Abstractions;

namespace InventoryService.Infrastructure.EmailService
{
    public class EasyEmailService : IEasyEmailService
    {
        public void SendEmail(string email, string subject, string emailBody)
        {
            throw new NotImplementedException();
        }
    }
}
