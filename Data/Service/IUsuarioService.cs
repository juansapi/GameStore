using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public interface IUsuarioService
    {
        Task<Usuario> UsuarioSelect(string username);
    }
}