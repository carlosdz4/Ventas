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
    internal class NumeroCorrelativoDB : INumeroCorrelativoDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<NumeroCorrelativo> GetAll()
        {
            throw new NotImplementedException();
        }

        public NumeroCorrelativo GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(NumeroCorrelativo entity)
        {
            throw new NotImplementedException();
        }
    }
}
