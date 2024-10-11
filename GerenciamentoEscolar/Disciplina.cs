namespace GerenciamentoEscolar
{
    internal class Disciplina
    {
        public string Nome { get; private set; }
        public string Codigo { get; private set; }

        public Disciplina(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public override string ToString()
        {
            return $"Nome:{Nome} \nCodigo: {Codigo}";
        }
    }
}
