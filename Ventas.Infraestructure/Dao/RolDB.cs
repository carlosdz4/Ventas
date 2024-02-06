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
    internal class RolDB : IRolDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Rol> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rol GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Rol entity)
        {
            throw new NotImplementedException();
        }
    }
}
