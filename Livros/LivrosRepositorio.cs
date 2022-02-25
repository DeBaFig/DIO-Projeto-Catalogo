using DIO_Projeto_Catalogo.Interfaces;
using DIO_Projeto_Catalogo.Menus;

namespace DIO_Projeto_Catalogo.Livros
{
    public class LivrosRepositorio  : IRepositorio<Livro>
    {
        private List<Livro> listaLivros = new List<Livro>();
        public void Atualiza(int id, Livro item)
        {
            listaLivros[id] = item;
        }

        public void Insere(Livro item)
        {
            listaLivros.Add(item);
        }

        public List<Livro> Lista()
        {
            return listaLivros;
        }

        public void MostraMenuDoTipo()
        {
            var opcao = -1;
            LivrosOpcoes opcoesMenu = new LivrosOpcoes();
            string boasVindas = "\nNo catálogo de Livros você pode encontar e registrar\nos mais diversos livros.\n";
            string menuOpcoes = "1-Listar livros\n2-Adicionar livros \n3-Atualizar livro\n4-Excluir livro\n5-Visualizar livro";
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
            listaLivros[id].Ocultar();
        }

        public int ProximoId()
        {
            return listaLivros.Count;
        }

        public Livro RetornaPorId(int id)
        {
            return listaLivros[id];
        }
    }
}