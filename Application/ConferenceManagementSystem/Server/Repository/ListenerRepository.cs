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
    public class ListenerRepository : IRepository<Listener>
    {
        public void Add(Listener entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO Participants(CNP,FirstName,LastName,Email,Username,Passwd)" +
                    " VALUES (@CNP,@FirstName,@LastName,@Email,@Username,@Passwd)";
                db.Execute(query, entity);
            }
        }

        public List<Listener> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<string> FindCNPs()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT CNP FROM Participants").ToList();
            }
        }

        public List<string> FindUsernames()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT Username FROM Participants").ToList();
            }
        }

        public List<string> FindEmails()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT Email FROM Participants").ToList();
            }
        }

        public Listener FindOne(Listener entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Listener entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Listener entity)
        {
            throw new NotImplementedException();
        }
    }
}
