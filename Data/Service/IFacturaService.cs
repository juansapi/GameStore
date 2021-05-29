using System.Threading.Tasks;
using WebApplication1.Data.Model;
using System;
using System.Collections.Generic;

namespace WebApplication1.Data.Service
{
    public interface IFacturaService
    {
        Task<bool> FacturaInsert(Factura factura);
        Task<Productos> FacturaSelect();
        Task<IEnumerable<Factura>> ListaFacturas();
    }
}