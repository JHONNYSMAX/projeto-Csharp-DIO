using System.Collections.Generic;
namespace DIO.Serie.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);
        int proximoId();
    }
}