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
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO Conferences(ConferenceName) VALUES (@ConferenceName)";
                db.Execute(query, entity);
            }
        }

        public List<Conference> FindAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<Conference>("SELECT * FROM Conferences").ToList();
            }
        }

        public List<string> FindCNPs()
        {
            throw new NotImplementedException();
        }

        public Conference FindOne(Conference entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<Conference>("SELECT * FROM Conferences WHERE ConferenceId = @ConferenceId", entity).SingleOrDefault();
            }
        }

        public void Remove(Conference entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                db.Execute("DELETE * FROM Conferences WHERE ConferenceId = @ConferenceId", entity);
            }
        }

        public void Update(Conference entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                db.Execute("UPDATE Conferences SET ConferenceName = @ConferenceName WHERE ConferenceId = @ConferenceId", entity);
            }
        }
    }
}
