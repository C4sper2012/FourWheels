using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.UI.Pages
{
    public class KundeListe : PageModel
    {
        private readonly IKundeService _kundeService;
        public KundeListe(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        [BindProperty(SupportsGet = true)]
        public List<Kunde> ListKunde { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ListKunde = await _kundeService.GetAllAsync();
            return Page();
        }
    }
}