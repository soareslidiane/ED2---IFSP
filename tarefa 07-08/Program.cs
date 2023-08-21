using System;

class Program
{
    static Escola escola = new Escola();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Opções no seletor:");
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Adicionar curso");
            Console.WriteLine("2. Pesquisar curso (mostrar inclusive as disciplinas associadas)");
            Console.WriteLine("3. Remover curso (não pode ter nenhuma disciplina associada)");
            Console.WriteLine("4. Adicionar disciplina no curso");
            Console.WriteLine("5. Pesquisar disciplina (mostrar inclusive os alunos matriculados)");
            Console.WriteLine("6. Remover disciplina do curso (não pode ter nenhum aluno matriculado)");
            Console.WriteLine("7. Matricular aluno na disciplina");
            Console.WriteLine("8. Remover aluno da disciplina");
            Console.WriteLine("9. Pesquisar aluno (informar seu nome e em quais disciplinas ele está matriculado)");

            Console.Write("Escolha uma opção: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AdicionarCurso();
                    break;
                case 2:
                    PesquisarCurso();
                    break;
                case 3:
                    RemoverCurso();
                    break;
                case 4:
                    AdicionarDisciplinaNoCurso();
                    break;
                case 5:
                    PesquisarDisciplina();
                    break;
                case 6:
                    RemoverDisciplinaDoCurso();
                    break;
                case 7:
                    MatricularAlunoNaDisciplina();
                    break;
                case 8:
                    RemoverAlunoDaDisciplina();
                    break;
                case 9:
                    PesquisarAluno();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (choice != 0);
    }

  

    static void AdicionarCurso()
    {
        Curso curso = new Curso();
        Console.Write("Digite o ID do curso: ");
        curso.Id = int.Parse(Console.ReadLine());
        Console.Write("Digite a descrição do curso: ");
        curso.Descricao = Console.ReadLine();
        escola.AdicionarCurso(curso);
        Console.WriteLine("Curso adicionado com sucesso!");
    }

    static void PesquisarCurso()
    {
        Console.Write("Digite o ID do curso a ser pesquisado: ");
        int cursoId = int.Parse(Console.ReadLine());
        Curso curso = escola.PesquisarCurso(new Curso { Id = cursoId });

        if (curso != null)
        {
            Console.WriteLine($"Curso encontrado: ID: {curso.Id}, Descrição: {curso.Descricao}");
            Console.WriteLine("Disciplinas associadas:");
            foreach (var disciplina in curso.Disciplinas)
            {
                Console.WriteLine($"ID: {disciplina.Id}, Descrição: {disciplina.Descricao}");
            }
        }
        else
        {
            Console.WriteLine("Curso não encontrado!");
        }
    }
}

    static void RemoverCurso()
    {
    Console.Write("Digite o ID do curso a ser removido: ");
    int cursoId = int.Parse(Console.ReadLine());

    Curso curso = escola.PesquisarCurso(new Curso { Id = cursoId });

    if (curso != null)
    {
        if (curso.Disciplinas.Count == 0)
        {
            if (escola.RemoverCurso(curso))
            {
                Console.WriteLine("Curso removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível remover o curso.");
            }
        }
        else
        {
            Console.WriteLine("O curso possui disciplinas associadas. Não pode ser removido.");
        }
    }
    else
    {
        Console.WriteLine("Curso não encontrado!");
    }
}

    static void AdicionarDisciplinaNoCurso()
    {
    Console.Write("Digite o ID do curso para adicionar disciplina: ");
    int cursoId = int.Parse(Console.ReadLine());

    Curso curso = escola.PesquisarCurso(new Curso { Id = cursoId });

    if (curso != null)
    {
        Disciplina disciplina = new Disciplina();
        Console.Write("Digite o ID da disciplina: ");
        disciplina.Id = int.Parse(Console.ReadLine());
        Console.Write("Digite a descrição da disciplina: ");
        disciplina.Descricao = Console.ReadLine();

        if (curso.AdicionarDisciplina(disciplina))
        {
            Console.WriteLine("Disciplina adicionada ao curso com sucesso!");
        }
        else
        {
            Console.WriteLine("Não foi possível adicionar a disciplina ao curso.");
        }
    }
    else
    {
        Console.WriteLine("Curso não encontrado!");
    }
}

    static void PesquisarDisciplina()
    {
    Console.Write("Digite o ID da disciplina a ser pesquisada: ");
    int disciplinaId = int.Parse(Console.ReadLine());

    Disciplina disciplinaEncontrada = null;
    Curso cursoEncontrado = null;

    foreach (Curso curso in escola.Cursos)
    {
        disciplinaEncontrada = curso.PesquisarDisciplina(new Disciplina { Id = disciplinaId });
        if (disciplinaEncontrada != null)
        {
            cursoEncontrado = curso;
            break;
        }
    }

    if (disciplinaEncontrada != null && cursoEncontrado != null)
    {
        Console.WriteLine($"Disciplina encontrada: ID: {disciplinaEncontrada.Id}, Descrição: {disciplinaEncontrada.Descricao}");
        Console.WriteLine($"Curso associado: ID: {cursoEncontrado.Id}, Descrição: {cursoEncontrado.Descricao}");
        Console.WriteLine("Alunos matriculados:");

        foreach (Aluno aluno in disciplinaEncontrada.Alunos)
        {
            Console.WriteLine($"ID: {aluno.Id}, Nome: {aluno.Nome}");
        }
    }
    else
    {
        Console.WriteLine("Disciplina não encontrada!");
    }
}

    static void RemoverDisciplinaDoCurso()
    {
    Console.Write("Digite o ID do curso para remover disciplina: ");
    int cursoId = int.Parse(Console.ReadLine());

    Curso curso = escola.PesquisarCurso(new Curso { Id = cursoId });

    if (curso != null)
    {
        Console.Write("Digite o ID da disciplina a ser removida: ");
        int disciplinaId = int.Parse(Console.ReadLine());

        Disciplina disciplina = curso.PesquisarDisciplina(new Disciplina { Id = disciplinaId });

        if (disciplina != null)
        {
            if (disciplina.Alunos.Count == 0)
            {
                if (curso.RemoverDisciplina(disciplina))
                {
                    Console.WriteLine("Disciplina removida do curso com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível remover a disciplina do curso.");
                }
            }
            else
            {
                Console.WriteLine("A disciplina possui alunos matriculados. Não pode ser removida.");
            }
        }
        else
        {
            Console.WriteLine("Disciplina não encontrada!");
        }
    }
    else
    {
        Console.WriteLine("Curso não encontrado!");
    }

    }

    static void MatricularAlunoNaDisciplina()
    {
    Console.Write("Digite o ID da disciplina para matricular o aluno: ");
    int disciplinaId = int.Parse(Console.ReadLine());

    Disciplina disciplina = escola.PesquisarDisciplina(new Disciplina { Id = disciplinaId });

    if (disciplina != null)
    {
        Console.Write("Digite o ID do aluno: ");
        int alunoId = int.Parse(Console.ReadLine());

        Aluno aluno = new Aluno();  
        if (aluno != null)
        {
            if (disciplina.MatricularAluno(aluno))
            {
                Console.WriteLine("Aluno matriculado na disciplina com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível matricular o aluno na disciplina.");
            }
        }
        else
        {
            Console.WriteLine("Aluno não encontrado!");
        }
    }
    else
    {
        Console.WriteLine("Disciplina não encontrada!");
    }
    }

    static void RemoverAlunoDaDisciplina()
    {
    Console.Write("Digite o ID da disciplina para remover o aluno: ");
    int disciplinaId = int.Parse(Console.ReadLine());

    Disciplina disciplina = escola.PesquisarDisciplina(new Disciplina { Id = disciplinaId });

    if (disciplina != null)
    {
        Console.Write("Digite o ID do aluno: ");
        int alunoId = int.Parse(Console.ReadLine());

        Aluno aluno = new Aluno();  
        if (aluno != null)
        {
            if (disciplina.DesmatricularAluno(aluno))
            {
                Console.WriteLine("Aluno removido da disciplina com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível remover o aluno da disciplina.");
            }
        }
        else
        {
            Console.WriteLine("Aluno não encontrado!");
        }
    }
    else
    {
        Console.WriteLine("Disciplina não encontrada!");
    }
}

    static void PesquisarAluno()
    {
    Console.Write("Digite o nome do aluno: ");
    string nomeAluno = Console.ReadLine();

    foreach (Curso curso in escola.Cursos)
    {
        foreach (Disciplina disciplina in curso.Disciplinas)
        {
            foreach (Aluno aluno in disciplina.Alunos)
            {
                if (aluno.Nome.Equals(nomeAluno, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Aluno encontrado: ID: {aluno.Id}, Nome: {aluno.Nome}");
                    Console.WriteLine($"Matriculado na disciplina: {disciplina.Descricao}, Curso: {curso.Descricao}");
                }
            }
        }
    }
}
 

