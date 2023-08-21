using System;

class Curso
{
    private List<Disciplina> disciplinas = new List<Disciplina>();
    public int Id { get; set; }
    public string Descricao { get; set; }

    public bool AdicionarDisciplina(Disciplina disciplina)
    {
        if (disciplinas.Count < 12 && !disciplinas.Contains(disciplina))
        {
            disciplinas.Add(disciplina);
            return true;
        }
        else
        {
            return false;
        }
    }

    public Disciplina PesquisarDisciplina(Disciplina disciplina)
    {
        return disciplinas.Find(d => d.Id == disciplina.Id);
    }

    public bool RemoverDisciplina(Disciplina disciplina)
    {
        Disciplina disciplinaEncontrada = disciplinas.Find(d => d.Id == disciplina.Id);

        if (disciplinaEncontrada != null && disciplinaEncontrada.Alunos.Count == 0)
        {
            disciplinas.Remove(disciplinaEncontrada);
            return true;
        }
        else
        {
            return false;
        }
    }
}