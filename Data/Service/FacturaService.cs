using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Service
{
    public class FacturaService : IFacturaService
    {
        private readonly ApplicationDbContext _configuration;

        public FacturaService(ApplicationDbContext configuration)
        {
            _configuration = configuration;
        }


        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public async Task<bool> FacturaInsert(Factura factura)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Codi_UserUsuarios", factura.Codi_UserUsuarios, DbType.String);
                parameters.Add("Codi_ProdProductos", factura.Codi_ProdProductos, DbType.Int32);
                parameters.Add("Prec_Fact", factura.Prec_Fact, DbType.Double);
                parameters.Add("Fech_Fact", factura.Fech_Fact, DbType.DateTime);

                const string query = @"INSERT INTO Facturas (Codi_UserUsuarios, Codi_ProdProductos, Prec_Fact, Fech_Fact) VALUES (@Codi_UserUsuarios, @Codi_ProdProductos, @Prec_Fact, @Fech_Fact)";
                await conn.ExecuteAsync(query, new { factura.Codi_UserUsuarios, factura.Codi_ProdProductos, factura.Prec_Fact, factura.Fech_Fact }, commandType: CommandType.Text);
            }
            return true;
        }

        public async Task<Productos> FacturaSelect()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT Codi_Fact, Codi_UserUsuario, Codi_ProdProductos, Fech_Fact, Prec_Fact FROM Facturas";
                return await conn.QueryFirstOrDefaultAsync<Productos>(query, commandType: CommandType.Text);
            }
        }

        public async Task<IEnumerable<Factura>> ListaFacturas()
        {
            IEnumerable<Factura> factura;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                string query = "SELECT Codi_Fact, Codi_UserUsuarios, Codi_ProdProductos, Fech_Fact, Prec_Fact FROM Facturas";
                factura = await conn.QueryAsync<Factura>(query, commandType: CommandType.Text);
            }

            return factura;
        }


    }
}
