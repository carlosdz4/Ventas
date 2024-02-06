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
    internal class RolMenuDB : IRolMenuDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<RolMenu> GetAll()
        {
            throw new NotImplementedException();
        }

        public RolMenu GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(RolMenu entity)
        {
            throw new NotImplementedException();
        }
    }
}
