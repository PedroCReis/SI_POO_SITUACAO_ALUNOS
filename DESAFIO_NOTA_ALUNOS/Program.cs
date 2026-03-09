using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Aluno
{
    public int Matricula;
    public string Nome;
    public int Idade;
}

class Professor
{
    public int Codigo;
    public string Nome;
    public string Formacao;
}

class Disciplina
{
    public int Codigo;
    public string Nome;
    public int CargaHoraria;
}

class Notas
{
    public double Nota1;
    public double Nota2;
    public double Nota3;
}

class Boletim
{
    public Aluno Aluno;
    public Professor Professor;
    public Disciplina Disciplina;
    public Notas Notas;
}

class Program
{
    static void Main(string[] args)
    {
       
        Aluno aluno = new Aluno();
        aluno.Matricula = 5089;
        aluno.Nome = "Bernardo";
        aluno.Idade = 17;

        
        Professor professor = new Professor();
        professor.Codigo = 101;
        professor.Nome = "Patricia";
        professor.Formacao = "Matemática";

       
        Disciplina disciplina = new Disciplina();
        disciplina.Codigo = 301;
        disciplina.Nome = "Matemática";
        disciplina.CargaHoraria = 80;

        
        Notas notas = new Notas();
        notas.Nota1 = 8.0;
        notas.Nota2 = 6.5;
        notas.Nota3 = 7.0;

        
        Boletim boletim = new Boletim();
        boletim.Aluno = aluno;
        boletim.Professor = professor;
        boletim.Disciplina = disciplina;
        boletim.Notas = notas;

        
        double media = (boletim.Notas.Nota1 + boletim.Notas.Nota2 + boletim.Notas.Nota3) / 3.0;


        string situacao;

        if (media >= 7.0)
        {
            situacao = "Aprovado";
        }
        else
        {
            situacao = "Reprovado";
        }
      

        Console.WriteLine("Aluno      : " + boletim.Aluno.Nome);
        Console.WriteLine("Disciplina : " + boletim.Disciplina.Nome);
        Console.WriteLine("Professor  : " + boletim.Professor.Nome);
        Console.WriteLine("");
        Console.WriteLine("Nota 1     : " + boletim.Notas.Nota1);
        Console.WriteLine("Nota 2     : " + boletim.Notas.Nota2);
        Console.WriteLine("Nota 3     : " + boletim.Notas.Nota3);
        Console.WriteLine("Média      : " + media);
        Console.WriteLine("");
        Console.WriteLine("Situação   : " + situacao);
        
    }
}