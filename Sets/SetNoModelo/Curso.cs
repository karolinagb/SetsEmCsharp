using SetNoModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListaSomenteLeitura
{
    class Curso
    {
        private IList<Aula> aulas;

        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public  IList<Aula> Aulas
        {
            //Propriedade de coleção somente leitura
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public  string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach(var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ = Language Integrated Query
                //Consulta integrada a linguagem

                //Para cada aula da coleção some o tempo
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            //string.Join pega a coleção, une separando por vírgula
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}
