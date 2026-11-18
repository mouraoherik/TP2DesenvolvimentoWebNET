using DR4TP2.Model;
using DR4TP2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.Notes;

public class SaveNotesModel : PageModel
{
    [BindProperty] 
    public Note NoteInput { get; set; } = new Note();

    private readonly NoteServiceTxt _noteServiceTxt;

    public SaveNotesModel(NoteServiceTxt noteServiceTxt)
    {
        _noteServiceTxt = noteServiceTxt;
    }
    public void OnGet()
    { 
        
    }

    public IActionResult OnPost()
    {
        NoteInput.DateTime = DateTime.Now;
        
        if (ModelState.IsValid)
        {
            _noteServiceTxt.AdicionarNotas(NoteInput);
            TempData["Mensagem"] = "Nota cadastrada com sucesso!";
            TempData["MensagemTipo"] = "success";
            return RedirectToPage("Index");
        }

        return Page();
    }
}