using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourWheels.web.Pages
{
    public class CreateAO : PageModel
    {
        [BindProperty]
        public Arbejdsordrer ArbejdsOrdrer { get; set; }

        public SelectList Biler { get; set; }
        [BindProperty]
        public Bil ValgteBil { get; set; }
        public List<Servicetype> ServiceTyper { get; set; }

        private readonly IBilService _bilService;
        public CreateAO(IBilService bilService)
        {
            _bilService = bilService;
        }
    
        public async Task OnGetAsync()
        {
            List<Bil> biler = await _bilService.GetAllAsync();
            Biler = new SelectList(biler, "Id", "Registreringsnummer");
        }
    }
}
