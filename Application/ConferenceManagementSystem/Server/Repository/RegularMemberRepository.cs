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
    class RegularMemberRepository : IRepository<RegularMember>
    {
        public void Add(RegularMember entity)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                string query = "INSERT INTO RegularMembers(CNP,FirstName,LastName,Email,Website,Affiliation,Username,Passwd,isReviewer)" +
                    " VALUES (@CNP,@FirstName,@LastName,@Email,@Website,@Affiliation,@Username,@Passwd,0)";
                db.Execute(query, entity);
            }
        }

        public List<RegularMember> FindAll()
        {
            throw new NotImplementedException();
        }

        public RegularMember FindOne(RegularMember entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(RegularMember entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RegularMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
