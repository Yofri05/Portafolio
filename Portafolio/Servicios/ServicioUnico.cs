using System.Security.Cryptography;

namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            Obtenerguid = Guid.NewGuid();
        }

        public Guid Obtenerguid { get; private set; }
    }

    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {
            Obtenerguid = Guid.NewGuid();
        }

        public Guid Obtenerguid { get; private set; }
    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            Obtenerguid = Guid.NewGuid();
        }

        public Guid Obtenerguid { get; private set; }
    }
}
