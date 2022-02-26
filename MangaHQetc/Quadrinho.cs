using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.MangaHQetc
{
    public class Quadrinho : BaseAtributos
    {
        private int Capitulos { get; set; }
        private int CapitulosLidos { get; set; }
        public Quadrinho(
            int id, 
            Genero genero, 
            string titulo, 
            string descricao, 
            int capitulos,
            int capituloslidos)
        : base(id, genero, titulo, descricao)
        {
            this.Capitulos = capitulos;
            this.CapitulosLidos = capituloslidos;
        }

        public override string ToString()
        {
            string retorno = base.ToString();

            retorno += "Número de Capítulos (Atuais)" + this.Capitulos+ Environment.NewLine;
            retorno += "Número de Capítulos já lidos" + this.CapitulosLidos;
            
            return retorno;
        }
       
        public int retornaCapitulos()
        {
            return this.Capitulos;
        }
        public int retornaCapitulosLidos()
        {
            return this.CapitulosLidos;
        }
    }
}