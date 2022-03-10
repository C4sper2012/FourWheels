using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.UI.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IKundeService _kundeService;
        
        public CreateModel(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kunde Kunde { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            // if (!ModelState.IsValid)
            // {
            //     return Page();
            // }
            
            await _kundeService.CreateAsync(Kunde);

            return RedirectToPage("/Index");
        }

    }
}