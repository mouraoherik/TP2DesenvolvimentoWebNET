using DR4TP2.Model;

namespace DR4TP2.Services;

public class NoteServiceTxt
{
    private readonly string caminho = "notes.txt";


    public List<Note> CarregarNotas()
    {
        var notes = new List<Note>();
        if (System.IO.File.Exists(caminho))
        {
            var linhas = System.IO.File.ReadAllLines(caminho);

            foreach (var linha in linhas)
            {
                var partes = linha.Split(';');

                Note note = new Note()
                {
                    Mensagem = partes[0],
                    DateTime = DateTime.Parse(partes[1])
                };
                notes.Add(note);
            }
        }
        else
        {
            System.IO.File.Create(caminho).Close();
        }

        return notes;
    }


    public void SalvarNotas(List<Note> notes)
    {
        var linhas = new List<string>();
        foreach (var note in notes)
        {
            linhas.Add(note.Mensagem + ";" + note.DateTime);
        }
        System.IO.File.WriteAllLines(caminho, linhas);
    }

    public void AdicionarNotas(Note novaNota)
    {
        var notes = CarregarNotas();
        notes.Add(novaNota);
        SalvarNotas(notes);
    }
}