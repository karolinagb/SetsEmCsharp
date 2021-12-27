using System;

namespace ListaSomenteLeitura
{
    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.Tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula aula = obj as Aula;
            return this.titulo.CompareTo(aula.titulo);
        }

        public override string ToString()
        {
            return $"[Título: {titulo}, Tempo: {Tempo}]";
        }
    }
}
