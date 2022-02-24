namespace DIO_Projeto_Catalogo.Bases
{
    public abstract class BaseOpcoes<tipo>
    {
        public void Listar(List<tipo> itens)
        {
            Console.WriteLine("Listar séries");
            if (itens.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
        }
        public void Inserir(ref string entradaTitulo, ref int entradaGenero, ref string entradaDescricao)
        {
            int numGeneroMax=-1;
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                numGeneroMax = i;
            }
            Console.Write("\nDigite o número referente ao gênero: ");
            entradaGenero = ObterGenero(numGeneroMax);

            Console.Write("Digite o Título: ");
            entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição: ");
            entradaDescricao = Console.ReadLine();
        }
        void Atualizar()
        {

        }
        void Ocultar()
        {

        }
        void Visualizar()
        {

        }

        public static int ObterGenero(int numOpcoes)
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
    }
}