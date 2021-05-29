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
    public class ReportesService : IReportesService
    {
        private readonly ApplicationDbContext _configuration;

        public ReportesService(ApplicationDbContext configuration)
        {
            _configuration = configuration;
        }


        string connectionString = @"Data Source=DESKTOP-0RSF0KU;Initial Catalog=GameStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public async Task<bool> ReportesInsert(Reportes reportes)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Codi_UserUsuarios", reportes.Codi_UserUsuarios, DbType.String);
                parameters.Add("Codi_ProdProductos", reportes.Codi_ProdProductos, DbType.Int32);
                parameters.Add("Fech_Repo", reportes.Fech_Repo, DbType.DateTime);
                parameters.Add("Name_Repo", reportes.Name_Repo, DbType.String);
                parameters.Add("Desp_Repo", reportes.Desp_Repo, DbType.String);


                const string query = @"INSERT INTO Reportes (Codi_UserUsuarios, Codi_ProdProductos, Fech_Repo, Name_Repo, Desp_Repo) VALUES (@Codi_UserUsuarios, @Codi_ProdProductos, @Fech_Repo, @Name_Repo, @Desp_Repo)";
                await conn.ExecuteAsync(query, new { reportes.Codi_UserUsuarios, reportes.Codi_ProdProductos, reportes.Fech_Repo, reportes.Name_Repo, reportes.Desp_Repo }, commandType: CommandType.Text);
            }
            return true;
        }


        public async Task<IEnumerable<Reportes>> GetAllReportes()
        {
            IEnumerable<Reportes> reportes;

            using (var conn = new SqlConnection(connectionString))
            {
                const string query = "SELECT Codi_UserUsuarios, Codi_ProdProductos, Fech_Repo, Name_Repo, Desp_Repo FROM Reportes";
                reportes = await conn.QueryAsync<Reportes>(query, commandType: CommandType.Text);
            }

            return reportes;
        }

        public async Task<IEnumerable<Reportes>> Search(int busqueda)
        {
            IEnumerable<Reportes> reportes;

            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Codi_UserUsuarios, Codi_ProdProductos, Fech_Repo, Name_Repo, Desp_Repo FROM Reportes WHERE Codi_ProdProductos LIKE '%" + busqueda + "%'";
                reportes = await conn.QueryAsync<Reportes>(query, commandType: CommandType.Text);
            }

            return reportes;
        }





    }
}
