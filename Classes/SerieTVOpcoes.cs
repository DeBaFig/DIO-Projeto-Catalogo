using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.Classes
{
    public class SerieTVOpcoes : BaseOpcoes<SeriesTV>
    {
        SeriesTVRepositorio itens = new SeriesTVRepositorio();
        public void Listar()
        {
            base.Listar(itens.Lista());
            foreach (var serie in itens.Lista())
            {
                var excluido = serie.retornaOcultacao();
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        public void Inserir(){
            string entradaTitulo = "", entradaDescricao="";
            int entradaGenero =-1;
            Console.WriteLine("Inserir nova série");
            base.Inserir(ref entradaTitulo, ref entradaGenero, ref entradaDescricao);
			Console.Write("Digite o Ano de Início: ");
			int entradaAno = int.Parse(Console.ReadLine());
            SeriesTV novaSerie = 

        }
    }
}