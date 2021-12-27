using ListaSomenteLeitura;
using System;

namespace SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar o curso
            Curso curso = new Curso("C# Coleções", "Marcelo Oliveira");
            curso.Adiciona(new Aula("Trabalhando com listas", 21));
            curso.Adiciona(new Aula("Criando uma aula", 20));
            curso.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            curso.Matricula(a1);
            curso.Matricula(a2);
            curso.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach(var aluno in curso.Alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(curso.EstaMatriculado(a1));
            Console.WriteLine();

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            //a1 igual tonini?
            Console.WriteLine("A1 igual tonini?");
            Console.WriteLine(a1 == tonini);
            Console.WriteLine("A1 igual tonini usando método Equals alterado");
            Console.WriteLine(a1.Equals(tonini));

            Console.Clear();
            Console.WriteLine("Quem é o aluno com matricula 5617?");
            Aluno aluno5617 = curso.BuscaMatriculado(5617);
            Console.WriteLine("aluno5617: " + aluno5617);

            Console.WriteLine();
            Console.WriteLine("Quem é o aluno 5618?");
            Console.WriteLine(curso.BuscaMatriculado(5618));

            Console.WriteLine();
            //E se tentarmos adicionar outro aluno com a mesma
            //chave 5617?
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //curso.Matricula(fabio);
            //Uma das características de um dicionário é que a chave
            //é única
            //E se quisermos trocar o aluno que tem a mesma chave?
            curso.SubstituiAluno(fabio);
            //Quem é o aluno 5617 agora?
            Console.WriteLine("Quem é o aluno 5617 agora?");
            Console.WriteLine(curso.BuscaMatriculado(5617));

            //Como um dicionario armazena os valores (diagrama)
            //Ao usarmos um dicionario o .net através de um algoritmo interno, busca os valores de
            //dispersão referente aquela chave para encontrar o valor esperado.
        }
    }
}
