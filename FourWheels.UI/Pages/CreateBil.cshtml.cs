using System.ComponentModel.DataAnnotations;
using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourWheels.UI.Pages
{
    public class CreateBilModel : PageModel
    {
        private readonly IBilService _bilService;
        private readonly IKundeService _customerService;
        private readonly IEmailService _emailService;
        private readonly IArbejdsOrdrerService _arbejdsOrdrerService;


        public CreateBilModel(IBilService service, IKundeService customerService, IEmailService emailService, IArbejdsOrdrerService arbejdsOrdrerService)
        {
            _bilService = service;
            _customerService = customerService;
            _emailService = emailService;
            _arbejdsOrdrerService = arbejdsOrdrerService;
        }


        [BindProperty, Required]
        public Bil Bil { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<Kunde> Kunder { get; set; }

        [BindProperty]
        public Kunde Kunde { get; set; }

        public SelectList SelectKunde { get; set; }

        public async Task OnGet()
        {
            Kunder = await _customerService.GetAllAsync();
            SelectKunde = new SelectList(Kunder, "PKKundeID", "Fuldenavn");
        }

        public async Task OnPost(Bil bil)
        {
            Arbejdsordrer arbejdsordrer = await _arbejdsOrdrerService.GetByIdAsync(1);

            await _bilService.CreateAsync(bil);
            await _emailService.SendEmail(arbejdsordrer);
            await OnGet();
        }
    }
}
