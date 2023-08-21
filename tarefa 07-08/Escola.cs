using System;

class Escola
{
    private List<Curso> cursos = new List<Curso>();

    public bool AdicionarCurso(Curso curso)
    {
        if (cursos.Count < 5 && !cursos.Contains(curso))
        {
            cursos.Add(curso);
            return true;
        }
        else
        {
            return false;
        }
    }

    public Curso PesquisarCurso(Curso curso)
    {
        return cursos.Find(c => c.Id == curso.Id);
    }

    public bool RemoverCurso(Curso curso)
    {
        Curso cursoEncontrado = cursos.Find(c => c.Id == curso.Id);

        if (cursoEncontrado != null && cursoEncontrado.Disciplinas.Count == 0)
        {
            cursos.Remove(cursoEncontrado);
            return true;
        }
        else
        {
            return false;
        }
    }
}
