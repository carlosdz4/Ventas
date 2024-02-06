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
    internal class UsuarioDB : IUsuarioDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
