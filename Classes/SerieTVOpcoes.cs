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

        public void Inserir()
        {
            string entradaTitulo = "", entradaDescricao = "";
            int entradaGenero = -1;
            Console.WriteLine("Inserir nova série\n");

            base.Inserir(ref entradaTitulo, ref entradaGenero, ref entradaDescricao);

            Console.Write("Digite o Ano de Lançamento: ");
            int entradaAno = ObterAno();

            SeriesTV novaSerie = new SeriesTV(
            id: itens.ProximoId(),
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entradaAno,
            descricao: entradaDescricao);

            itens.Insere(novaSerie);
        }

         public static int ObterAno()
        {
            System.DateTime moment = new System.DateTime();
            int opcao = -1;
            string line = "";
            int year = moment.Year;
            do
            {
                line = Console.ReadLine();
                bool success = int.TryParse(line, out int temp);
                if (success)
                {
                    if (temp <= year && temp >= 1800) opcao = temp;
                    else System.Console.WriteLine($"Opção inválida, por favor escolha entre 1800 e {year}.");
                }
                else System.Console.WriteLine($"Opção inválida, por favor digite apenas números.");

            } while (opcao == -1);
            return opcao;
        }
    }
}