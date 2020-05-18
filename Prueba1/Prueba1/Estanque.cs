using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    class Estanque : VehiculoComponentes
    {
       
        private double _litros;
        
        public bool MitadCombu()
        {
            return _litros > 10.5 && _litros <= 50.0;
        }
         public bool BajoCombu()
        {
            return _litros <= 10.5;
        }
         
    }
}
