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
    internal class DetalleVentaDB : IDetalleVentaDB
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<DetalleVenta> GetAll()
        {
            throw new NotImplementedException();
        }

        public DetalleVenta GetById(int deptoId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(DetalleVenta entity)
        {
            throw new NotImplementedException();
        }
    }
