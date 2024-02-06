using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    internal class ConfiguracionDB : IConfiguracionDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Configuracion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Configuracion GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Configuracion entity)
        {
            throw new NotImplementedException();
        }
    }
}
