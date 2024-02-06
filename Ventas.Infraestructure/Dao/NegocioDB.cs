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
    internal class NegocioDB : INegocioDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Negocio> GetAll()
        {
            throw new NotImplementedException();
        }

        public Negocio GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Negocio entity)
        {
            throw new NotImplementedException();
        }
    }
}
