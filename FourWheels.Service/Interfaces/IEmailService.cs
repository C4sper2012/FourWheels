using FourWheels.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Service.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(Arbejdsordrer arbejdsordrer);
    }
}
