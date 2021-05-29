using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public interface IComentariosService
    {
        Task<bool> ComentariosDelete(int id);
        Task<bool> ComentariosInsert(Comentarios comentarios);
        Task<IEnumerable<Comentarios>> GetAllComentarios();
    }
}