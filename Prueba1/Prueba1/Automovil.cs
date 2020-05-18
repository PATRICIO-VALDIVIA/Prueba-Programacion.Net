using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
     class Automovil : vehiculo
    {

        private int marca;
        private int año;
        private int kilometraje;
        
        public Automovil(int marca, int año, int kilometraje, int idmotor, 
        TipoMotor tipoMotor, int cilindrada, int numRuedas, TipoRecubrimiento tipoRecubrimiento, 
        int minDurometro, int maxDurometro, TipoMezclador tipoMezclador, double capacidad) :
            base(idmotor, tipoMotor, cilindrada, numRuedas, tipoRecubrimiento,
            minDurometro, maxDurometro, tipoMezclador, capacidad)
        {}
    }
}
