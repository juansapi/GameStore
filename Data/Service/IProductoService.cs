using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public interface IProductoService
    {
        Task<IEnumerable<Productos>> GetAllProductos();
        Task<bool> ProductoInsert(Productos producto);
        Task<IEnumerable<Productos>> Search(string busqueda);
        Task<IEnumerable<Productos>> FiltroAventuraGenero(string IDGenero);
        Task<Productos> ProductoSelect(int id);

    }
}