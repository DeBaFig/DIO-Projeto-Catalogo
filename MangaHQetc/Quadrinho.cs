using DIO_Projeto_Catalogo.Livros;

namespace DIO_Projeto_Catalogo.MangaHQetc
{
    public class Quadrinho : Livro
    {
        private int Capitulos { get; set; }
        public Quadrinho(int id, Genero genero, string titulo, string descricao, string autor, int lancamento, int capitulos)
        : base(id, genero, titulo, descricao, autor, lancamento)
        {
            this.Capitulos = capitulos;
        }

         public override string ToString()
        {
            string retorno = base.ToString();
            retorno += "Número de Capítulos (Atuais)" + this.Capitulos;
            return retorno;
        }
        public int retornaCapitulos()
		{
			return this.Capitulos;
		}
    }
}