using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Model;

namespace WebApplication1.Data.Service
{
    public class ComentariosService : IComentariosService
    {
        private readonly ApplicationDbContext _configuration;
        public ComentariosService(ApplicationDbContext configuration)
        {
            _configuration = configuration;
        }
        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //----------//----------/COMENTARIOS_CREATE/----------//----------//
        public async Task<bool> ComentariosInsert(Comentarios comentarios)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Codi_UserUsuarios", comentarios.Codi_UserUsuarios, DbType.String);
                parameters.Add("Codi_ProdProductos", comentarios.Codi_ProdProductos, DbType.Int32);
                parameters.Add("Come_Come", comentarios.Come_Come, DbType.String);

                const string query = @"INSERT INTO Comentarios (Codi_UserUsuarios, Codi_ProdProductos, Come_Come) VALUES (@Codi_UserUsuarios, @Codi_ProdProductos, @Come_Come)";
                await conn.ExecuteAsync(query, new { comentarios.Codi_UserUsuarios, comentarios.Codi_ProdProductos, comentarios.Come_Come }, commandType: CommandType.Text);
            }
            return true;
        }
        //----------//----------//----------//----------////----------//----------//----------//----------//
        //----------//----------/COMENTARIO_ALL_READ/----------//----------//
        public async Task<IEnumerable<Comentarios>> GetAllComentarios()
        {
            IEnumerable<Comentarios> comentarios;

            using (var conn = new SqlConnection(connectionString))
            {
                const string query = "SELECT Codi_UserUsuarios, Codi_ProdProductos, Come_Come FROM Comentarios";
                comentarios = await conn.QueryAsync<Comentarios>(query, commandType: CommandType.Text);
            }
            return comentarios;
        }
        //----------//----------//----------//----------////----------//----------//----------//----------//
        //----------//----------/COMENTARIO_DELETE/----------//----------//
        public async Task<bool> ComentariosDelete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = @"DELETE FROM Comentarios WHERE Codi_Come = @Codi_Come";
                await conn.ExecuteAsync(query.ToString(), new { Codi_Come = id }, commandType: CommandType.Text);
            }
            return true;
        }





    }
}
