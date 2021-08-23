using Dapper;
using Marte.Domain.Entities;
using Marte.Domain.Interfaces.Repositories;
using Marte.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Infra.Repositories
{
    public class SondaRepository : RepositoryBase<Sonda>, ISondaRepository
    {
        public SondaRepository(IConfiguration configuration) : base(configuration) { }

        public override void Insert(Sonda entity)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    DynamicParameters param = new DynamicParameters();
                    //param.Add("x", entity.x);
                    //param.Add("y", entity.y);
                    //param.Add("direction", entity.direction);
                    var addUser = db.QueryFirstOrDefault<Sonda>("AddSonda", param, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
