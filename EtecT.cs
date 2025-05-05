using System;
using System.Collections.Generic;

public class EtecT
{
    public string NomeInstituicao { get; set; } = "ETEC Técnico";
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

    public void AdicionarAluno(string nome, int anoMatricula, int horasCurso)
    {
        Alunos.Add(new Aluno { Nome = nome, AnoMatricula = anoMatricula, HorasCurso = horasCurso });
    }

    public void ExibirAlunos()
    {
        Console.WriteLine($"\nInstituição: {NomeInstituicao}");
        foreach (var aluno in Alunos)
        {
            Console.WriteLine($"- Nome: {aluno.Nome}, Ano Matrícula: {aluno.AnoMatricula}, Horas do Curso: {aluno.HorasCurso}");
        }
    }
}




