using System;

class Disciplina
{
    private List<Aluno> alunos = new List<Aluno>();
    public int Id { get; private set; }
    public string Descricao { get; set; }

    public bool MatricularAluno(Aluno aluno)
    {
        if (alunos.Count < 15 && !alunos.Contains(aluno))
        {
            alunos.Add(aluno);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool DesmatricularAluno(Aluno aluno)
    {
        if (alunos.Contains(aluno))
        {
            alunos.Remove(aluno);
            return true;
        }
        else
        {
            return false;
    }
}
