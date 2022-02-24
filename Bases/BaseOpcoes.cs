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
        public void Inserir(ref string entradaTitulo,ref  int entradaGenero,ref string entradaDescricao)
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o número referente ao gênero: ");
            entradaGenero = int.Parse(Console.ReadLine());

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
    }
}