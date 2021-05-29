using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public interface IReportesService
    {
        Task<bool> ReportesInsert(Reportes reportes);

        Task<IEnumerable<Reportes>> GetAllReportes();


        Task<IEnumerable<Reportes>> Search(int busqueda);


    }
}