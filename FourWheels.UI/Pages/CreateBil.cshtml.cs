using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FourWheels.web.Pages
{
    public class CreateBilModel : PageModel
    {
        private readonly IBilService _bilService;
        private readonly ICustomerService _customerService;


        public CreateBilModel(IBilService service, ICustomerService customerService)
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
                    Ejer = Bil.Ejer,

                };
                await _bilService.CreateAsync(bil);
            }
            await OnGet();
        }
    }
}
