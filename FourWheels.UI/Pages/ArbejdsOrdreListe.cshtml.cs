using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.UI.Pages
{
    public class ArbejdsOrdreListeModel : PageModel
    {
        private readonly IArbejdsOrdrerService _arbejdsOrdrerService;
        public ArbejdsOrdreListeModel(IArbejdsOrdrerService arbejdsOrdrerService)
        {
            _arbejdsOrdrerService = arbejdsOrdrerService;
        }

        [BindProperty(SupportsGet = true)]
        public List<Arbejdsordrer> Arbejdsordrers { get; set; }


        public DateTime DefaultTime = new DateTime(01, 01, 0001, 00, 00, 00);

        // && item.TidBrugt != ""

        public async Task OnGet()
        {
            Arbejdsordrers = await _arbejdsOrdrerService.GetAllAOIncludeMek();
        }
    }
}
