using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.Livros
{
    public class Livro: BaseAtributos
    {
        
        private string Autor { get; set; }
        private int Lancamento { get; set; }

        public Livro(int id, Genero genero, string titulo, string descricao, string autor, int lancamento)
        : base(id, genero, titulo, descricao)
        {
            this.Autor = autor;
            this.Lancamento = lancamento;
        }

        public override string ToString()
        {
            string retorno = base.ToString();
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Lancamento;
            return retorno;
        }
        public int retornaAno()
		{
			return this.Lancamento;
		}

        public string retornaAutor()
		{
			return this.Autor;
		}
    }
}