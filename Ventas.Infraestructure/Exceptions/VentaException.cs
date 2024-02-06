﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Infraestructure.Exceptions
{
    internal class VentaException : Exception
    {
        public VentaException(string message) : base(message) 
        {

            SaveError(message);

        }

        void SaveError(string message)
        {
            // X logica para guardar el erro ocurrido //
        }
    }
}
