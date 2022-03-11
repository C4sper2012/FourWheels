using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public InputModel Input { get; set; } = new();

        #region Dependencies
        private readonly IBilService _bilService;
        private readonly IServiceTypeService _serviceTypeService;
        private readonly IArbejdsOrdrerService _arbejdsOrdreService;
        public CreateAO(IBilService bilService, IServiceTypeService serviceTypeService, IArbejdsOrdrerService arbejdsOrdreService)
        {
            _bilService = bilService;
            _serviceTypeService = serviceTypeService;
            _arbejdsOrdreService = arbejdsOrdreService;
        }
        #endregion
    
        public async Task OnGetAsync()
        {
            List<Bil> biler = await _bilService.GetAllWithKundeAsync();
            List<Servicetype> serviceTyper = await _serviceTypeService.GetAllAsync();

            Input.Biler = biler.Select(b => new SelectListItem($"{b.Registreringsnummer} - {b.Kunde.Fuldenavn} ({b.Producent} {b.Model})", b.PKBilID.ToString()))
                               .ToList();
            Input.ServiceTyper = new SelectList(serviceTyper, nameof(Servicetype.PKServicetypeID), nameof(Servicetype.ServiceType));
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            
            Arbejdsordrer ordrer = new Arbejdsordrer()
            {
                Bil = await _bilService.GetByIdAsync(Input.ValgteBilId),
                Servicetype = await _serviceTypeService.GetByIdAsync(Input.ValgteServiceTypeId)
            };
            await _arbejdsOrdreService.CreateAsync(ordrer);
            return RedirectToPage("/index");
        }
        
        public class InputModel
        {
            public List<SelectListItem> Biler { get; set; }
            public SelectList ServiceTyper { get; set; }

            [BindProperty, DisplayName("Eksisterende kunde"), Required(ErrorMessage = "Du skal vælge en kunde")]
            public int ValgteBilId { get; set; } = new();
            [BindProperty, DisplayName("Service type"), Required(ErrorMessage = "Du skal vælge en service type")]
            public int ValgteServiceTypeId { get; set; }
        }
    }
}
