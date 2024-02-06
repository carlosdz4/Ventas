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
    internal class TipoDocumentoVentaDB : ITipoDocumentoVentaDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<TipoDocumentoVenta> GetAll()
        {
            throw new NotImplementedException();
        }

        public TipoDocumentoVenta GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(TipoDocumentoVenta entity)
        {
            throw new NotImplementedException();
        }
    }
}
