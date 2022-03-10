using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.web.Pages
{
    public class CreateBilModel : PageModel
    {
        private readonly IBilService _service;


        public CreateBilModel(IBilService service)
        {
            _service = service;
        }


        [BindProperty]
        public Bil Bil { get; set; }

        public async void OnGet()
        {
            await _service.GetAllAsync();
        }

        public async Task<IActionResult> OnPost()
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
                await _service.CreateAsync(bil);
            }
            return RedirectToPage();
        }
    }
}
