using System;

namespace School.Data.Entities
{
    public class Asiento
    {
        public int AsientoId { get; set; }
        public int BusId { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
