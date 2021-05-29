using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Data.Model;
using WebApplication1.Data.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Service
{
    public class ProductoService : IProductoService
    {
        private readonly ApplicationDbContext _configuration;

        public ProductoService(ApplicationDbContext configuration)
        {
            _configuration = configuration;

        }
        

        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public async Task<bool> ProductoInsert(Productos producto)
        {

            using (var conn = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Codi_Prod", producto.Codi_Prod, DbType.Int32);
                parameters.Add("Name_Prod", producto.Name_Prod, DbType.String);
                parameters.Add("Desp_Prod", producto.Desp_Prod, DbType.String);
                parameters.Add("Genero", producto.Genero, DbType.String);
                parameters.Add("Imgn_Prod", producto.Imgn_Prod, DbType.String);
                parameters.Add("Pric_Prod", producto.Pric_Prod, DbType.Int32);
                parameters.Add("Descuent_Prod", producto.Descuent_Prod, DbType.Int32);

                const string query = @"INSERT INTO Productos (Codi_Prod, Name_Prod, Desp_Prod, Genero, Imgn_Prod, Pric_Prod, Descuent_Prod) VALUES (@Codi_Prod, @Name_Prod, @Desp_Prod, @Genero, @Imgn_Prod, @Pric_Prod, @Descuent_Prod)";
                await conn.ExecuteAsync(query, new { producto.Codi_Prod, producto.Name_Prod, producto.Desp_Prod, producto.Genero, producto.Imgn_Prod, producto.Pric_Prod, producto.Descuent_Prod }, commandType: CommandType.Text);
            }

            return true;
        }

        public async Task<IEnumerable<Productos>> GetAllProductos()
        {
            IEnumerable<Productos> productos;

            using (var conn = new SqlConnection(connectionString))
            {
                const string query = "SELECT Codi_Prod, Name_Prod, Desp_Prod, Imgn_Prod, Genero, Pric_Prod, Descuent_Prod FROM Productos";
                productos = await conn.QueryAsync<Productos>(query, commandType: CommandType.Text);
            }

            return productos;
        }

        public async Task<IEnumerable<Productos>> Search(string busqueda)
        {
            IEnumerable<Productos> productos;

            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Codi_Prod, Name_Prod, Imgn_Prod, Genero, Pric_Prod, Descuent_Prod FROM Productos WHERE Name_Prod LIKE '%" + busqueda + "%'";
                productos = await conn.QueryAsync<Productos>(query, commandType: CommandType.Text);
            }

            return productos;
        }

        public async Task<IEnumerable<Productos>> FiltroAventuraGenero(string IDGenero)
        {
            IEnumerable<Productos> productos;

            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Codi_Prod, Name_Prod, Imgn_Prod, Genero, Pric_Prod, Descuent_Prod FROM Productos WHERE Genero LIKE '%" + IDGenero + "%'";
                productos = await conn.QueryAsync<Productos>(query, commandType: CommandType.Text);
            }

            return productos;
        }

        public async Task<Productos> ProductoSelect(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT Codi_Prod, Name_Prod, Desp_Prod, Imgn_Prod, Genero, Pric_Prod FROM Productos WHERE Codi_Prod LIKE '%" + id + "%'";
                return await conn.QueryFirstOrDefaultAsync<Productos>(query, commandType: CommandType.Text);
            }
        }

    }
}
