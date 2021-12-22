using System;
using System.Collections.Generic;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETS = Conjuntos

            //Duas propriedades do Set
            //1 - Não permite duplicidade
            //2 - Os elementos não são mantidos em ordem específica

            //declaando set de alunos
            ISet<string> alunos = new HashSet<string>();

            //adicionando alunos
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(string.Join(",", alunos));
            Console.WriteLine();

            //Diferença entre conjunto e lista
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(",", alunos));
            Console.WriteLine();

            //Verificando ordenação
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",", alunos));
            Console.WriteLine();

            //Adicionando dados repetidos (ele nao adiciona e tb n da erro)
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));
            Console.WriteLine();

            //Com HashSet as buscas por elementos são mais rápidas

            //alunos.Sort  = ISet nao possui o metodo Sort

            //Copiando
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(",", alunosEmLista));
            Console.WriteLine();
        }
    }
}
