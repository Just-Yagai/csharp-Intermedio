using System.Collections.Generic;

namespace School.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Remover(T entidad);
        T ObtenerPorId(int id);
        List<T> TraerTodos();
    }
}

