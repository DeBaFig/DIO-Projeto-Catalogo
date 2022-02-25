namespace DIO_Projeto_Catalogo.Bases
{
    public class BaseAtributos : BaseCatalogo
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private bool Oculto { get; set; }

        // Métodos
        public BaseAtributos(int id, Genero genero, string titulo, string descricao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Oculto = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "\nID: " + this.Id + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaOcultacao()
        {
            return this.Oculto;
        }
        public void Ocultar()
        {
            this.Oculto = true;
        }
    }
}