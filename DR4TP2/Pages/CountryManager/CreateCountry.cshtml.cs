using System.ComponentModel.DataAnnotations;
using DR4TP2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.CountryManager;

public class CreateCountry : PageModel
{

    [BindProperty] public InputModelCountry CountryInput { get; set; }

    public Country CountryCreated;


    public class InputModelCountry
    {
        [Required(ErrorMessage = "Nome do país é obrigatório")]
        public string CountryName { get; set; }
        
        [Required(ErrorMessage = "Codigo do país é obrigatório." ),StringLength(2, MinimumLength = 2,ErrorMessage = "Codigo do pais deve ter exatamente {1} caracteres")]
        public string CountryCode { get; set; }
    }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        CountryCreated = new Country
        {
            CountryName = CountryInput.CountryName,
            CountryCode = CountryInput.CountryCode
        };

        return Page();
    }
}