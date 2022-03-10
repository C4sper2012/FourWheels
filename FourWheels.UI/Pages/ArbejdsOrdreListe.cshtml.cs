using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.UI.Pages
{
    public class ArbejdsOrdreListeModel : PageModel
    {
        private readonly IBilService _bilService;
        private readonly IKundeService _kundeService;
        private readonly IServiceTypeService _serviceTypeService;
        public ArbejdsOrdreListeModel(IBilService bilService, IKundeService kundeService, IServiceTypeService serviceTypeService)
        {
            _bilService = bilService;
            _kundeService = kundeService;
            _serviceTypeService = serviceTypeService;
        }


        public void OnGet()
        {
        }
    }
}
