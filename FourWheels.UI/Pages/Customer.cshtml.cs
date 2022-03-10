using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.UI.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ICustomerService _customerService;
        
        public CreateModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kunde Kunde { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            await _customerService.CreateAsync(Kunde);

            return RedirectToPage("./Index");
        }

    }
}