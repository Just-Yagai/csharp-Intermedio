using Refactoring.Entities;
using Refactoring.Interfaces;

namespace Refactoring.Repository
{
    public class AsientoRepository<T> : IAsientoRepository<T> where T : class
    {
        protected List<T> _entities;

        public AsientoRepository()
        {
            _entities = new List<T>();
        }

        public void Agregar(T asiento) 
        {
            _entities.Add(asiento);
        }
        public void Actualizar(T asiento) 
        { 
            
        }
        public void Remover(T asiento) 
        {
            _entities.Remove(asiento);
        }
        public T ObtenerPorId(int asientoId)
        {
            return null;
        }
        public virtual List<T> TraerTodos()
        {
            return _entities;
    }
}
