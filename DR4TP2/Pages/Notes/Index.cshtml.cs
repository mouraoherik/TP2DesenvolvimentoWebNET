using DR4TP2.Model;
using DR4TP2.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.Notes;

public class IndexModel : PageModel
{
    public List<Note> notes { get; set; } = new List<Note>();
    private readonly NoteServiceTxt _noteServiceTxt;

    public IndexModel(NoteServiceTxt noteServiceTxt)
    {
        _noteServiceTxt = noteServiceTxt;
    }

    public void OnGet()
    {
        notes = _noteServiceTxt.CarregarNotas();
    }
}