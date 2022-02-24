using DIO_Projeto_Catalogo.Interfaces;
using DIO_Projeto_Catalogo.Menus;

namespace DIO_Projeto_Catalogo.Series
{
    public class SeriesTVRepositorio : IRepositorio<SeriesTV>
    {
        private List<SeriesTV> listaSerieTV = new List<SeriesTV>();
        public void Atualiza(int id, SeriesTV item)
        {
            listaSerieTV[id] = item;
        }

        public void Insere(SeriesTV item)
        {
            listaSerieTV.Add(item);
        }

        public List<SeriesTV> Lista()
        {
            return listaSerieTV;
        }

        public void MostraMenuDoTipo()
        {
            var opcao = -1;
            SerieTVOpcoes opcoesMenu = new SerieTVOpcoes();
            string boasVindas = "\nNo catálogo de Series você pode encontar e registrar\nas mais diversas séries de todas as plataformas.\n";
            string menuOpcoes = "1-Listar Series\n2-Adicionar Serie \n3-Atualizar Serie\n4-Excluir Serie\n5-Visualizar Serie";
            Menu.MostraDesenho();
            Menu.MostaMenu(boasVindas, menuOpcoes);
            while (opcao != 0)
            {
                opcao = Menu.ObterOpcaoUsuario(5);
                switch (opcao)
                {
                    case 1:
                    opcoesMenu.Listar();
                        break;
                    case 2:
                    opcoesMenu.Inserir();
                        break;
                    case 3:
                        opcoesMenu.Atualiza();
                        break;
                    case 4:
                    opcoesMenu.Excluir();
                        break;
                    case 5:
                        opcoesMenu.Visualizar();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                }
                if (opcao != 0)
                    Menu.MostaMenu(boasVindas, menuOpcoes);
            }

        }

        public void Oculta(int id)
        {
            listaSerieTV[id].Ocultar();
        }

        public int ProximoId()
        {
            return listaSerieTV.Count;
        }

        public SeriesTV RetornaPorId(int id)
        {
            return listaSerieTV[id];
        }
    }
}
