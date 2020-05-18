using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    abstract class VehiculoComponentes
    {
        private double _estadocomp;

        protected VehiculoComponentes()
        {
            _estadocomp = 0.0;
            _estadocomp = 100.0;
        }

        public double EstadoComponente
        {
            get => _estadocomp;
            set => double.TryParse(value.ToString(), out _estadocomp);
        }

    }
}

