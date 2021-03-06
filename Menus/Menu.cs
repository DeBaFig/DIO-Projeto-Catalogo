using DIO_Projeto_Catalogo.Bases;
using DIO_Projeto_Catalogo.Livros;
using DIO_Projeto_Catalogo.MangaHQetc;
using DIO_Projeto_Catalogo.Series;

namespace DIO_Projeto_Catalogo.Menus
{
    public class Menu
    {
        
        public static void MostaMenu(string boasVindas, string menuOpcoes)
        {
            Console.WriteLine(boasVindas);
            Console.WriteLine("Informe a opção desejada:\n");
            Console.WriteLine(menuOpcoes);
            Console.WriteLine("0- Sair\n");
        }

        public static void escolhaCatalogo(string boasVindas, string menuOpcoes)
        {
            var opcao = -1;
             
            MostaMenu(boasVindas, menuOpcoes);
            SeriesTVRepositorio serie = new SeriesTVRepositorio();
            LivrosRepositorio livro = new LivrosRepositorio();
            QuadrinhosRepositorio hq = new QuadrinhosRepositorio();
            while (opcao != 0)
            {
                opcao = ObterOpcaoUsuario(3);

                switch (opcao)
                {
                    case 1:
                        serie.MostraMenuDoTipo();
                        break;
                    case 2:
                        livro.MostraMenuDoTipo();
                        break;
                    case 3:
                        hq.MostraMenuDoTipo();
                        break;
                    case 0:
                        Console.WriteLine("Obrigada, volte sempre!");
                        break;
                }
                if (opcao != 0)
                    MostaMenu(boasVindas, menuOpcoes);
            }
        }
        public static int ObterOpcaoUsuario(int numOpcoes)
        {
            int opcao = -1;
            string line = "";
            do
            {
                line = Console.ReadLine();
                bool success = int.TryParse(line, out int temp);
                if (success)
                {
                    if (temp <= numOpcoes && temp >= 0) opcao = temp;
                    else System.Console.WriteLine($"Opção inválida, por favor escolha entre 0 e {numOpcoes}.");

                }
                else System.Console.WriteLine($"Opção inválida, por favor digite apenas números.");

            } while (opcao == -1);
            return opcao;
        }

        //
    }
}
