using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace WebApplication1.Data.PDF
{
    public interface IFacturaPDF
    {
        FileResult descargarPDF();
        Task GeneraFactura(Factura factura, Usuario usuario, Productos productos);
    }
}