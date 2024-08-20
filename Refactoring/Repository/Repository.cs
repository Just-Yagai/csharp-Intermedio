using Refactoring.Entities;
using Refactoring.Interfaces;

namespace Refactoring.Repository
{
    public class Repository : AsientoRepository<Asiento>, IAsientoRepository
    {
        public override Asiento ObtenerPorId(int asientoId) 
        {
            return _entities.FirstOrDefault(a => a.AsientoId == asientoId);
        }    
    }
}
