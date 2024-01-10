using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Infrastructure.EmailService.Abstractions
{
    public interface IEasyEmailService
    {
        /// <summary>
        /// Third Party SendEmail integration
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="emailBody"></param>
        void SendEmail(string email, string subject, string emailBody);
    }
}
