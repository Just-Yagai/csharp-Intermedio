using Refactoring.Entities;

namespace Refactoring.Interfaces
{
    public interface IAsientoRepository<T> where T : class
    {
        void Agregar(T asiento);
        void Actualizar(T asiento);
        void Remover(T asiento);
        List<T> TraerTodos();
        T ObtenerPorId(int asientoId);
    }
}
