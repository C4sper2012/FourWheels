using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly IKundeService _kundeService;

        public EmailService(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        public async Task SendEmail(Arbejdsordrer arbejdsordrer)
        {

            Kunde kunde = await _kundeService.GetByIdAsync(arbejdsordrer.Bil.FKEjer);

            using (var smtp = new SmtpClient("127.0.0.1", 25))
            {
                var message = new MailMessage
                {
                    Subject = "Din bil er færdig!",
                    Body = $"Hej {kunde.Fuldenavn}" +
                           $"Din {arbejdsordrer.Bil.Producent} {arbejdsordrer.Bil.Model} " +
                           $"med registreringsnummer: {arbejdsordrer.Bil.Registreringsnummer} er nu færdig og kan afhentes.",


                    From = new MailAddress("fourWheels@mail.dk")
                };

                message.To.Add($"{arbejdsordrer.Bil.Kunde.Email}");
                await smtp.SendMailAsync(message);
            }
        }
    }
}
