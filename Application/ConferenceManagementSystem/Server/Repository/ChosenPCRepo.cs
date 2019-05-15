using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using Dapper;

namespace Server.Repository
{
    class ChosenPCRepo : IRepository<ChosenPCMember>
    {
        public void Add(ChosenPCMember entity)
        {
            throw new NotImplementedException();
        }

        public List<ChosenPCMember> FindAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<ChosenPCMember>("SELECT * FROM ChosenProgramCommittee").ToList();
            }
        }

        public List<string> FindCNPs()
        {
            throw new NotImplementedException();
        }

        public ChosenPCMember FindOne(ChosenPCMember entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(ChosenPCMember entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ChosenPCMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
