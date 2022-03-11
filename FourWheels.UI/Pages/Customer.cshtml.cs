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
        private readonly IBilService _bilService;
        public CreateModel(IKundeService kundeService, IBilService bilService)
        {
            _kundeService = kundeService;
            _bilService = bilService;
        }

        public async Task<IActionResult> OnGet()
        {
            BilList = (await _bilService.GetAllAsync()).Where(x => false).ToList();
            return Page();
        }

        [BindProperty]
        public Kunde Kunde { get; set; }

        public List<Bil> BilList { get; set; }
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