using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourWheels.UI.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IKundeService _kundeService;
        public CreateModel(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public Kunde Kunde { get; set; }
        
        [BindProperty] 
        public Bil Bil { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            // if (!ModelState.IsValid)
            // {
            //     return Page();
            // }
            Kunde.Biler = new List<Bil> {Bil};
            await _kundeService.CreateAsync(Kunde);

            return RedirectToPage("/Index");
        }

    }
}