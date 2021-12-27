namespace SetNoModelo
{
    class Aluno
    {
        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }

        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"[Nome: {Nome}, Matrícula: {NumeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if(outro == null)
            {
                return false;
            }

            return Nome.Equals(outro.Nome);
        }

        //Quando modificamos o método Equals temos que modificar o método GetHashCode também
        //porque a rapidez da busca depende do código de dispersão.

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }

        //OBS
        //Dois objetos que são iguais possuem o mesmo hash code.
        //Porém, o contrário não é verdadeiro:
        //Dois objetos com mesmo hash codes não são necessariamente iguais
    }
}
