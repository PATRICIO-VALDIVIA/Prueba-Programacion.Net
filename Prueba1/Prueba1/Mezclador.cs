using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    enum TipoMezclador
    {
        CARBURADOR, INYECTORES
    }
    class Mezclador : VehiculoComponentes
    {
        private TipoMezclador _tipo;

        public Mezclador(TipoMezclador tipo)
        {
            _tipo = tipo;
        }

        public Mezclador(string tipo)
        {
            Tipo = tipo;
        }

        public string Tipo
        {
            get { return _tipo.ToString(); }
            set
            {
                bool resultado = Enum.TryParse(value, out _tipo);
                if (!resultado)
                    Console.WriteLine("Error, no se pudo convertir el tipo a un Mezclador");
            }
        }

    }
}
