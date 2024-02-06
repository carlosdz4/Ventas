using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Infraestructure.Core
{
    internal interface IDaoBase<TEntity> where TEntity : class
    {
        DataResult Save(TEntity entity);

        List<TEntity> GetAll();

        TEntity GetById(int deptoId);

        bool Exists(string name);
    }
    
}
