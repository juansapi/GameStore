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
    public class FavoritoService : IFavoritoService
    {

        private readonly ApplicationDbContext _configuration;
        public FavoritoService(ApplicationDbContext configuration)
        {
            _configuration = configuration;
        }
        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //----------//----------/FAVORITE_CREATE/----------//----------//
        public async Task<bool> FavoritoInsert(Favorito favorito)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Codi_UserUsuarios", favorito.Codi_UserUsuarios, DbType.String);
                parameters.Add("Codi_ProdProductos", favorito.Codi_ProdProductos, DbType.Int32);

                const string query = @"INSERT INTO Favorito (Codi_UserUsuarios, Codi_ProdProductos) VALUES (@Codi_UserUsuarios, @Codi_ProdProductos)";
                await conn.ExecuteAsync(query, new { favorito.Codi_UserUsuarios, favorito.Codi_ProdProductos }, commandType: CommandType.Text);
            }
            return true;
        }
        //----------//----------/COMENTARIO_ALL_READ/----------//----------//
        public async Task<IEnumerable<Favorito>> GetAllFavoritos()
        {
            IEnumerable<Favorito> favorito;

            using (var conn = new SqlConnection(connectionString))
            {
                const string query = "SELECT Codi_Favo, Codi_UserUsuarios, Codi_ProdProductos FROM Favorito";
                favorito = await conn.QueryAsync<Favorito>(query, commandType: CommandType.Text);
            }
            return favorito;
        }
        public async Task<Favorito> FavoritoSelect(int id)
        { //Codi_Favo, Codi_UserUsuarios, Codi_ProdProductos
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT Codi_Favo, Codi_UserUsuarios, Codi_ProdProductos FROM Favorito WHERE Codi_ProdProductos LIKE '%" + id + "%'";
                return await conn.QueryFirstOrDefaultAsync<Favorito>(query, commandType: CommandType.Text);
            }
        }
        public async Task<bool> FavoritoDelete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = @"DELETE FROM Favorito WHERE Codi_Favo = @Codi_Favo";
                await conn.ExecuteAsync(query.ToString(), new { Codi_Favo = id }, commandType: CommandType.Text);
            }
            return true;
        }


    }
}
