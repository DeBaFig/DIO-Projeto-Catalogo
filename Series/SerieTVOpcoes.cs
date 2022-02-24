using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.Series
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
            itens.Insere(AlteraAdiciona(-1));
        }

        public int Visualizar()
        {
            var index = ProcuraId(itens.Lista());
            var serie = itens.RetornaPorId(index);
            System.Console.WriteLine(serie);
            return index;
        }
        public void Excluir()
        {
            var index = Visualizar();
            if (SimOuNao())
            {
                itens.Oculta(index);
                System.Console.WriteLine("Item foi excluido");
            }
            else System.Console.WriteLine("Nenhuma mudança foi implementada.");
        }
        public void Atualiza()
        {
            var index = Visualizar();
            Console.WriteLine("\nGostaria de alterar essa serie?");
            if (SimOuNao())
            {
                itens.Atualiza(index, AlteraAdiciona(index));
            }
            else System.Console.WriteLine("Nenhuma mudança foi implementada.");
        }
        public static int ObterAno()
        {
            int opcao = -1;
            string line = "";
            int year = DateTime.Today.Year;
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


        //caso tenha já um id(alterar deve enviar como argumento o id, caso seja um novo objeto enviar o argumento como -1)
        public SeriesTV AlteraAdiciona(int idExistente)
        {
            string entradaTitulo = "", entradaDescricao = "";
            int entradaGenero = -1;
            base.Inserir(ref entradaTitulo, ref entradaGenero, ref entradaDescricao);

            Console.Write("Digite o Ano de Lançamento: ");
            int entradaAno = ObterAno();
            int entradaId = (idExistente == -1 ? itens.ProximoId() : idExistente);
            SeriesTV novaSerie = new SeriesTV(
            id: entradaId,
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entradaAno,
            descricao: entradaDescricao);

            return novaSerie;
        }
    }
}