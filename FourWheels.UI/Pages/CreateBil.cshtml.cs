using System.ComponentModel.DataAnnotations;
using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourWheels.UI.Pages
{
    public class CreateBilModel : PageModel
    {
        private readonly IBilService _bilService;
        private readonly IKundeService _customerService;


        public CreateBilModel(IBilService service, IKundeService customerService)
        {
            _bilService = service;
            _customerService = customerService;
        }


        [BindProperty, Required]
        public Bil Bil { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<Kunde> Kunder { get; set; }

        [BindProperty]
        public Kunde Kunde { get; set; }

        public SelectList SelectKunde { get; set; }

        public async Task OnGet()
        {
            Kunder = await _customerService.GetAllAsync();
            SelectKunde = new SelectList(Kunder, "Id", "Fuldenavn");
        }

        public async Task OnPost(Bil bil)
        {
            //ModelState.ClearValidationState(nameof(bil));
            // TryValidateModel(bil);
            // if (!ModelState.IsValid)
            // {
            //     await _bilService.CreateAsync(bil);
            // }
            await _bilService.CreateAsync(bil);
            await OnGet();
        }
    }
}
