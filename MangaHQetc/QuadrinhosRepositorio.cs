using DIO_Projeto_Catalogo.Interfaces;
using DIO_Projeto_Catalogo.Menus;

namespace DIO_Projeto_Catalogo.MangaHQetc
{
    public class QuadrinhosRepositorio : IRepositorio<Quadrinho>
    {
        
        private List<Quadrinho> listaHQ = new List<Quadrinho>();

        public void Atualiza(int id, Quadrinho item)
        {
            listaHQ[id] = item;
        }

        public void Insere(Quadrinho item)
        {
            listaHQ.Add(item);
        }

        public List<Quadrinho> Lista()
        {
            return listaHQ;
        }

        public void MostraMenuDoTipo()
        {
            var opcao = -1;
            QuadrinhosOpcoes opcoesMenu = new QuadrinhosOpcoes();
            string boasVindas = "\nNo catálogo de HQ's / Mangás / Manhua / Manhawa você pode encontar e registrar\nos mais diversos quadrinhos.\n";
            string menuOpcoes = "1-Listar HQ's / Mangás / Manhua / Manhawa \n2-Adicionar quadrinho \n3-Atualizar quadrinho\n4-Excluir quadrinho\n5-Visualizar quadrinho";
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
            listaHQ[id].Ocultar();
        }

        public int ProximoId()
        {
            return listaHQ.Count;
        }
            public Quadrinho RetornaPorId(int id)
        {
            return listaHQ[id];
        }

    }
}