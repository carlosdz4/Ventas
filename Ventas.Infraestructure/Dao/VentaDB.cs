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
    internal class VentaDB : IVentaDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Venta GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Venta entity)
        {
            throw new NotImplementedException();
        }
    }
}
