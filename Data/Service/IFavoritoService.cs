using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public interface IFavoritoService
    {
        Task<bool> FavoritoDelete(int id);
        Task<bool> FavoritoInsert(Favorito favorito);
        Task<Favorito> FavoritoSelect(int id);
        Task<IEnumerable<Favorito>> GetAllFavoritos();
    }
}