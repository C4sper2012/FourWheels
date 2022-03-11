using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.UI.Pages
{
    public class Details : PageModel
    {
        private readonly IBilService _bilService;
        private readonly IArbejdsOrdrerService _arbejdsOrdrerService;
        public Details(IBilService bilService, IArbejdsOrdrerService arbejdsOrdrerService)
        {
            _bilService = bilService;
            _arbejdsOrdrerService = arbejdsOrdrerService;
        }

        [BindProperty(SupportsGet = true)]
        public Bil Bil { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<Arbejdsordrer> ArbejdsOrdrere { get; set; }
        [BindProperty(SupportsGet = true)]
        public Arbejdsordrer NyesteArbejdsOrder { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            Bil = await _bilService.GetByIdAsync(id);
            
            ArbejdsOrdrere = (await _arbejdsOrdrerService.GetAllAsync())
                .Where(x => x.Bil.Registreringsnummer == Bil.Registreringsnummer)
                .OrderByDescending(x => x.Oprettet).ToList();

            NyesteArbejdsOrder = ArbejdsOrdrere.FirstOrDefault();
                
            return Page();
        }
    }
}