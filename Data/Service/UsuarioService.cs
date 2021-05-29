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
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _configuration;

        public UsuarioService(ApplicationDbContext configuration)
        {
            _configuration = configuration;
        }


        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public async Task<Usuario> UsuarioSelect(string username)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT Id, UserName FROM AspNetUsers WHERE UserName LIKE '%" + username + "%'";
                return await conn.QueryFirstOrDefaultAsync<Usuario>(query, commandType: CommandType.Text);
            }
        }



    }
}
