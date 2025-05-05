using System;
using System.Collections.Generic;

public class EtecA
{
    public string NomeInstituicao { get; set; } = "ETEC AMS";
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    private const int HorasObrigatorias = 200;

    public void AdicionarAluno(string nome, int anoMatricula, int horasCurso)
    {
        Alunos.Add(new Aluno { Nome = nome, AnoMatricula = anoMatricula, HorasCurso = horasCurso, HorasObrigatorias = HorasObrigatorias });
    }

    public void ExibirAlunos()
    {
        Console.WriteLine($"\nInstituição: {NomeInstituicao}");
        foreach (var aluno in Alunos)
        {
            Console.WriteLine($"- Nome: {aluno.Nome}, Ano Matrícula: {aluno.AnoMatricula}, Horas do Curso: {aluno.HorasCurso}, Horas Obrigatórias: {aluno.HorasObrigatorias}");
        }
    }

    public void ExibirAlunosComObrigatoriedade()
    {
        Console.WriteLine($"\nAlunos com obrigatoriedade de {HorasObrigatorias}h:");
        foreach (var aluno in Alunos)
        {
            Console.WriteLine($"- {aluno.Nome} (Ano: {aluno.AnoMatricula})");
        }
    }
}
