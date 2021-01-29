using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Where_The_Wild_Items_Are.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
