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
    class PcMemberRepository : IRepository<PcMember>
    {
        public void Add(PcMember entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO ChairMembers(CNP,FirstName,LastName,Email,Website,Affiliation,Username,Passwd)" +
                    " VALUES (@CNP,@FirstName,@LastName,@Email,@Website,@Affiliation,@Username,@Passwd)";
                db.Execute(query, entity);
            }
        }

        public List<PcMember> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<string> FindCNPs()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT CNP FROM ChairMembers").ToList();
            }
        }

        public List<string> FindUsernames()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT Username FROM ChairMembers").ToList();
            }
        }

        public List<string> FindEmails()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                return db.Query<String>("SELECT Email FROM ChairMembers").ToList();
            }
        }

        public bool hasUsernamePassword(string username, string password)
        {
            List<String> res;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                res=db.Query<String>("SELECT CNP FROM ChairMembers WHERE Username='" + username + "' AND Passwd='" + password + "'").ToList();
                if (res.Capacity == 1) return true;
                else return false;
            }
        }

        public PcMember FindOne(PcMember entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(PcMember entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PcMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
