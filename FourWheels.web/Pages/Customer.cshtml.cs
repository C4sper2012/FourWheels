﻿using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.web.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ICustomerService _customerService;
        private readonly string _imagePath = $"{Environment.CurrentDirectory}\\wwwroot\\img\\";
        
        public CreateModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kunde Item { get; set; }

        [BindProperty]
        public IFormFile ImageFile { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            await _customerService.CreateAsync(Item);

            return RedirectToPage("./Index");
        }

    }
}