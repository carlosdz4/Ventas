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
    internal class CategoriaDB : ICategoriaDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categoria GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
