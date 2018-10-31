using System;

namespace sistemaaluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme a 1a nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a 2a nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a 3a nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());


            Console.WriteLine("A media do aluno {0} e: {1}", aluno.Nome, aluno.Media());
        }
    }
}
