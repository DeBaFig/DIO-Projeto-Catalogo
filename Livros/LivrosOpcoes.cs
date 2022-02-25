using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.Livros
{
    public class LivrosOpcoes: BaseOpcoes<Livro>
    {
        
        LivrosRepositorio itens = new LivrosRepositorio();
        public void Listar()
        {
            base.Listar(itens.Lista());
            foreach (var livro in itens.Lista())
            {
                var excluido = livro.retornaOcultacao();
                Console.WriteLine("\n#ID: {0}\nTítulo: {1}\nAutor: {2}\nStatus: {3}", livro.retornaId(), livro.retornaAutor(), livro.retornaTitulo(), (excluido ? "*Excluído*" : "Válido"));
                Console.WriteLine("__________________________________");
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
                    if (temp <= year ) opcao = temp;
                    else System.Console.WriteLine($"Opção inválida, por favor digite um ano até {year}.");
                }
                else System.Console.WriteLine($"Opção inválida, por favor digite apenas números.");

            } while (opcao == -1);
            return opcao;
        }


        //caso tenha já um id(alterar deve enviar como argumento o id, caso seja um novo objeto enviar o argumento como -1)
        public Livro AlteraAdiciona(int idExistente)
        {
            string entradaTitulo = "", entradaDescricao = "";
            int entradaGenero = -1;
            base.Inserir(ref entradaTitulo, ref entradaGenero, ref entradaDescricao);

            Console.Write("Digite o Ano de Lançamento: ");
            int entradaAno = ObterAno();
            Console.Write("Digite o nome do Autor: ");
            string entradaAutor = Console.ReadLine();
            int entradaId = (idExistente == -1 ? itens.ProximoId() : idExistente);
            Livro novoLivro = new Livro(
            id: entradaId,
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            lancamento: entradaAno,
            descricao: entradaDescricao,
            autor:entradaAutor );

            return novoLivro;
        }
    }
}