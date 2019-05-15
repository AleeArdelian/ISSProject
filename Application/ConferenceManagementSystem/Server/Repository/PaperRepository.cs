using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Server.Repository
{
    class PaperRepository : IRepository<Paper>
    {
        public void Add(Paper entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Paper entity, int SectionID)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO Papers(SectionID,Content,PaperName,Topic,Abstract,isAccepted)" +
                    " VALUES ("+SectionID+ ",@Content,@PaperName,@Topic,@Abstract,0)";
                db.Execute(query, entity);
            }
        }

        public int FindMaxID()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                List<int> res = db.Query<int>("SELECT MAX(PaperID) FROM Papers").ToList();
                return res[0];
            }
        }

        public List<Paper> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<string> FindCNPs()
        {
            throw new NotImplementedException();
        }

        public Paper FindOne(Paper entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Paper entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Paper entity)
        {
            throw new NotImplementedException();
        }
    }
}
