using System;

public class Aluno
{
    public string Nome { get; set; }
    public int AnoMatricula { get; set; }
    public int HorasCurso { get; set; }
    public int? HorasObrigatorias { get; set; }
}

class Program
{
    static void Main()
    {
        // Criando instâncias
        EtecT tecnico = new EtecT();
        EtecA ams = new EtecA();

        // Adicionando alunos
        tecnico.AdicionarAluno("Alice", 2023, 120);
        tecnico.AdicionarAluno("Bruno", 2022, 300);

        ams.AdicionarAluno("Carla", 2024, 130);
        ams.AdicionarAluno("Diego", 2023, 200);

        // Exibindo dados
        tecnico.ExibirAlunos();
        ams.ExibirAlunos();
        ams.ExibirAlunosComObrigatoriedade();
    }
}
