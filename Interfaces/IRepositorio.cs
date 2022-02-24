namespace DIO_Projeto_Catalogo.Interfaces
{
    public interface IRepositorio<Tipo>
    {
        void MostraMenuDoTipo();
        List<Tipo> Lista();
        Tipo RetornaPorId(int id);
        void Insere(Tipo item);
        void Oculta(int id);
        void Atualiza(int id, Tipo item);
        int ProximoId();
    }
}