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
    internal class MenuDB : IMenuDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
