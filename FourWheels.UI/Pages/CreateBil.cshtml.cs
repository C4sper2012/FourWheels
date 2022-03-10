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


        public CreateBilModel(IBilService service, IKundeService customerService)
        {
            _bilService = service;
            _customerService = customerService;
        }


        [BindProperty, Required]
        public Bil Bil { get; set; }

        public List<Kunde> Kunder { get; set; } = new List<Kunde>();

        public SelectList SelectKunde { get; set; }

        public async Task OnGet()
        {
            Kunder = await _customerService.GetAllAsync();
            SelectKunde = new SelectList(Kunder);
        }

        public async Task OnPost()
        {
            if (ModelState.IsValid)
            {
                Bil bil = new Bil
                {
                    Registreringsnummer = Bil.Registreringsnummer,
                    Stelnummer = Bil.Stelnummer,
                    Producent = Bil.Producent,
                    Model = Bil.Model,
                    FKEjer = Bil.FKEjer,

                };
                await _bilService.CreateAsync(bil);
            }
            await OnGet();
        }
    }
}
