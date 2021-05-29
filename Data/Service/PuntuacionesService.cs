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
    public class PuntuacionesService : IPuntuacionesService
    {
        private readonly ApplicationDbContext _configuration;

        public PuntuacionesService(ApplicationDbContext configuration)
        {
            _configuration = configuration;
        }


        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public async Task<bool> PuntuacionesInsert(Puntuaciones puntuacion)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Codi_UserUsuarios", puntuacion.Codi_UserUsuarios, DbType.String);
                parameters.Add("Codi_ProdProductos", puntuacion.Codi_ProdProductos, DbType.Int32);
                parameters.Add("Scor_Punt", puntuacion.Scor_Punt, DbType.Int32);

                const string query = @"INSERT INTO Puntuaciones (Codi_UserUsuarios, Codi_ProdProductos, Scor_Punt) VALUES (@Codi_UserUsuarios, @Codi_ProdProductos, @Scor_Punt)";
                await conn.ExecuteAsync(query, new { puntuacion.Codi_UserUsuarios, puntuacion.Codi_ProdProductos, puntuacion.Scor_Punt }, commandType: CommandType.Text);
            }
            return true;
        }


    }
}
