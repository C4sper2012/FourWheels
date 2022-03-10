using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourWheels.web.Pages
{
    public class CreateAO : PageModel
    {
        public class InputModel
        {
            public SelectList Biler { get; set; }
            public SelectList Kunder { get; set; }
            public SelectList ServiceTyper { get; set; }

            [BindProperty]
            public Bil ValgteBil { get; set; } = new();
            [BindProperty]
            public Kunde ValgteKunde { get; set; }
            [BindProperty]
            public Servicetype ValgteServiceType { get; set; }
            
            [BindProperty]
            public Arbejdsordrer ArbejdsOrdrer { get; set; }
        }
        public InputModel Input { get; set; } = new();

        private readonly IBilService _bilService;
        private readonly IKundeService _kundeService;
        private readonly IServiceTypeService _serviceTypeService;
        public CreateAO(IBilService bilService, IKundeService kundeService, IServiceTypeService serviceTypeService)
        {
            _bilService = bilService;
            _kundeService = kundeService;
            _serviceTypeService = serviceTypeService;
        }
    
        public async Task OnGetAsync()
        {
            List<Kunde> kunder = await _kundeService.GetAllAsync();
            Input.Kunder = new SelectList(kunder, "Id", "Fuldenavn");
            
            List<Bil> biler = await _bilService.GetAllAsync();
            List<Servicetype> serviceTyper = await _serviceTypeService.GetAllAsync();
            
            Input.Biler = new SelectList(biler, "ID", "Registreringsnummer");
            Input.ServiceTyper = new SelectList(serviceTyper, "Id", "ServiceType");
        }
        public async Task OnGetKundeSelectedAsync(int id)
        {
            Input.ValgteKunde = await _kundeService.GetByIdAsync(id);
            Input.ValgteKunde ??= new();
        }
    }
}
