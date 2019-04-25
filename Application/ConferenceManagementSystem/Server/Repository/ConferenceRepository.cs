using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace Server.Repository
{
    class ConferenceRepository : IRepository<Conference>
    {
        public void Add(Conference entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
            {
                string query = "insert into Conferences(ConferenceName) values (@ConferenceName)";
                db.Execute(query, entity);
            }
        }

        public List<Conference> FindAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
            {
                return db.Query<Conference>("select * from Conferences").ToList();
            }
        }

        public bool FindOne(Conference entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Conference entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Conference entity)
        {
            throw new NotImplementedException();
        }
    }
}
