using System.ComponentModel.DataAnnotations;
using DR4TP2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.CityManager;

// Validação do Lado do Servidor com Data Annotations
//
// Valide os dados de entrada para garantir que o nome da cidade tenha no mínimo 3 caracteres.
//
// Tarefas:
//
// Crie uma classe InputModel aninhada ao PageModel.
// Adicione a propriedade CityName com o atributo [Required] e [MinLength(3)].
// Implemente a lógica de ModelState.IsValid no OnPost.
// Mostre as mensagens de erro quando a validação falhar.

public class CreateCityEx3Model : PageModel
{
    [BindProperty] 
    public InputModelCity InputCity { get; set; }


    public class InputModelCity
    {
        [Required(ErrorMessage = "O Nome da cidade é obrigatório")]
        [MinLength(3,ErrorMessage = "A Cidade deve ter no mínimo 3 caracteres")]
        public string CityName { get; set; }
    }
    
    public City CityCreated { get; set; }
    

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        CityCreated = new City
        {
            CityName = InputCity.CityName
        };
        
        return Page();
    }
    
}