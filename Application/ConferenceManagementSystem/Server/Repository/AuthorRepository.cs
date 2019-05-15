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
    public class AuthorRepository : IRepository<Author>
    {
        public void Add(Author entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO Authors(CNP,FirstName,LastName,Email,Affiliation,Username,Passwd)" +
                    " VALUES (@CNP,@FirstName,@LastName,@Email,@Affiliation,@Username,@Passwd)";
                db.Execute(query, entity);
            }
        }

        public List<Author> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<string> FindCNPs()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT CNP FROM Authors").ToList();
            }
        }

        public List<string> FindUsernames()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT Username FROM Authors").ToList();
            }
        }

        public List<string> FindEmails()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT Email FROM Authors").ToList();
            }
        }

        public Author FindOne(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
