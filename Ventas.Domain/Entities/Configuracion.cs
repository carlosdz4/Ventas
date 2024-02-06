﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Entities
{
    public class Configuracion
    {

        public int Id { get; set; }
        public string? Recurso { get; set; }

        public string? Propiedad { get; set; }

        public string? Valor { get; set; }
    }
}
