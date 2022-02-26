using DIO_Projeto_Catalogo.Bases;

namespace DIO_Projeto_Catalogo.MangaHQetc
{
    public class QuadrinhosOpcoes : BaseOpcoes<Quadrinho>
    {

        QuadrinhosRepositorio itens = new QuadrinhosRepositorio();

        public void Listar()
        {
            base.Listar(itens.Lista());
            foreach (var hq in itens.Lista())
            {
                var excluido = hq.retornaOcultacao();
                Console.WriteLine("\n#ID: {0}\nTítulo: {1}\nStatus: {2}\nCapítulos:{3}", hq.retornaId(), hq.retornaTitulo(), (excluido ? "*Excluído*" : "Válido"), hq.retornaCapitulos());
                Console.Write("|");
                for(int i = 0; i <= hq.retornaCapitulosLidos(); i++){
                    Console.Write("▓");
                }  
                  for(int j = hq.retornaCapitulosLidos(); j < hq.retornaCapitulos(); j++){
                    Console.Write("░");
                }              
                Console.WriteLine($"| Lidos: {hq.retornaCapitulosLidos()}");
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
            var hq = itens.RetornaPorId(index);
            System.Console.WriteLine(hq);
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
        public static int ObterCaptitulos(int numCap)
        {
            int opcao = -1;
            string line = "";
            do
            {
                string erro1 = "Opção inválida, por favor digite um número igual ou maior que 1.", 
                erro2 = $"Opção inválida, por favor digite um número entre 0 e {numCap}.",
                erro3 = "Opção inválida, por favor digite apenas números.";

                line = Console.ReadLine();
                bool success = int.TryParse(line, out int temp);
                if (success)
                {
                    if( (temp > 0 && numCap <= 0) || (temp >= 0 && numCap > 0 && temp <= numCap)){
                        return opcao = temp;
                    }else if(numCap < 1 || (temp <= 0 && numCap < 1))System.Console.WriteLine(erro1);
                    else System.Console.WriteLine(erro2);
                }
                else System.Console.WriteLine(erro3);
            } while (opcao == -1);
            return opcao;
        }


        //caso tenha já um id(alterar deve enviar como argumento o id, caso seja um novo objeto enviar o argumento como -1)
        public Quadrinho AlteraAdiciona(int idExistente)
        {
            string entradaTitulo = "", entradaDescricao = "";
            int entradaGenero = -1;
            base.Inserir(ref entradaTitulo, ref entradaGenero, ref entradaDescricao);

            Console.Write("Digite o número de capitúlos atuais: ");
            int entradaCapitulos = ObterCaptitulos(-1);
            Console.Write("Digite o número de capitúlos que você já leu: ");
            int entradaCapitulosLidos = ObterCaptitulos(entradaCapitulos);
            int entradaId = (idExistente == -1 ? itens.ProximoId() : idExistente);
            Quadrinho novoHq = new Quadrinho(
            id: entradaId,
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            descricao: entradaDescricao,
            capitulos: entradaCapitulos,
            capituloslidos: entradaCapitulosLidos);

            return novoHq;
        }
    }
}