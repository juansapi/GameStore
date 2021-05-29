using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public interface IPuntuacionesService
    {
        Task<bool> PuntuacionesInsert(Puntuaciones puntuacion);
    }
}