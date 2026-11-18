using System.ComponentModel.DataAnnotations;
using DR4TP2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.CountryManager;

public class Exercicio12 : PageModel
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

        if (!CountryInput.CountryName.ToLower().First().Equals(CountryInput.CountryCode.ToLower().First()))
        {
            ModelState.AddModelError("CountryInput.CountryName", "A Primeira letra do Pais e do ISO devem ser iguais");
        }
        
        
        if (ModelState.IsValid)
        {
            CountryCreated = new Country
            {
                CountryName = CountryInput.CountryName,
                CountryCode = CountryInput.CountryCode
            };
        }

        return Page();
    }
}