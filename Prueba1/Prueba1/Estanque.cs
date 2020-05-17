using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    class Estanque : VehiculoComponentes
    {
        private readonly double _Capacidad;
        private double _litros;
        public Estanque(double capacidad)
        {

            _Capacidad = Capacidad;
        }

        public double Capacidad => _Capacidad;

        public double Litros
        {
            get => _litros;
            set => double.TryParse(value.ToString(), out _litros);
        }

        public bool BajoCombustible()
        {
            return _litros <= 10.5;
        }

        public bool MitadCombustible()
        {
            return _litros > 10.5 && _litros <= 50.0;
        }
    }
}
