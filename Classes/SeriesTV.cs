using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.Classes
{
    public class SeriesTV : BaseAtributos
    {
        private int Ano { get; set; }

        public SeriesTV(int id, Genero genero, string titulo, string descricao, int ano)
        : base(id, genero, titulo, descricao)
        {
            this.Ano = ano;

        }

        public override string ToString()
        {
            string retorno = base.ToString();
            retorno += "Ano de de Lançamento: " + this.Ano;
            return retorno;
        }
        public int retornaAno()
		{
			return this.Ano;
		}
        
    }
}