﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{

    abstract class vehiculo
    {
        private Motor _motor;
        private Rueda[] _ruedas;
        private Estanque _estanque;
        private Mezclador _mezclador;

        public vehiculo(int idMotor, TipoMotor tipoMotor, int cilindrada,
                        int numRuedas, TipoRecubrimiento tipoRecubrimiento,
                        int minDurometro, int maxDurometro,
                        TipoMezclador tipoMezclador, double capacidad)
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);
            _ruedas = new Rueda[numRuedas];
            for (int i = 0; i < numRuedas; i++)
            {
                Ruedas[i] = new Rueda(tipoRecubrimiento, minDurometro, maxDurometro);
            }


            _mezclador = new Mezclador(tipoMezclador);

        }

        internal Motor Motor { get => _motor; set => _motor = value; }
        internal Estanque Estanque { get => _estanque; set => _estanque = value; }
        internal Rueda[] Ruedas { get => _ruedas; set => _ruedas = value; }
        internal Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }
    }
}
