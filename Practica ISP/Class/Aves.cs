using Practica_ISP.Interface;

namespace Practica_ISP.Class
{
    public class Aves
    {
        public class Pato : IAve, INadar
        {
            public void Nadar()
            {
                throw new NotImplementedException();
            }

            public void PonerHuevos()
            {
                throw new NotImplementedException();
            }

            public void Volar()
            {
                throw new NotImplementedException();
            }
        }

        public class Pinguino : IAve, INadar
        {
            public void Nadar()
            {
                throw new NotImplementedException();
            }

            public void PonerHuevos()
            {
                throw new NotImplementedException();
            }
        }
    }
}
