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
    class ReviewRepository : IRepository<Review>
    {
        public void Add(Review entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO Reviews(PaperID,ReviewerCNP,Qualifier,Comments,ReevalRequest)" +
                    " VALUES (@PaperID,@ReviewerCNP,@Qualifier,@Comments,0)";
                db.Execute(query, entity);
            }
        }

        public List<Review> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<string> FindCNPs()
        {
            throw new NotImplementedException();
        }

        public Review FindOne(Review entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Review entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
