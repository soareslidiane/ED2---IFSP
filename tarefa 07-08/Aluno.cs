using System;
using System.Collections.Generic;

class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public bool PodeMatricular(Curso curso)
    {
        foreach (Curso c in Escola.cursos)
        {
            if (c != curso)
            {
                foreach (Disciplina d in c.disciplinas)
                {
                    if (d.alunos.Any(a => a.Id == this.Id))
                    {
                        Console.WriteLine("O aluno já está matriculado em outro curso.");
                        return false;
                    }
                }
            }
        }

        int totalDisciplinas = 0;
        foreach (Disciplina d in curso.disciplinas)
        {
            if (d.alunos.Any(a => a.Id == this.Id))
            {
                totalDisciplinas++;
            }
        }

        if (totalDisciplinas >= 6)
        {
            Console.WriteLine("O aluno já está matriculado em 6 disciplinas.");
            return false;
        }

        return true;
    }
}









