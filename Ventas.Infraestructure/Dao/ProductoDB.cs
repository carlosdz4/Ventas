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
    internal class ProductoDB : IProductoDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Producto GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
