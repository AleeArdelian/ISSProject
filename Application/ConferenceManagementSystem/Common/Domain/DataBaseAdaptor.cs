using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSgui.Domain
{
    public class DataBaseAdaptor
    {
        private String conStr;
        private SqlConnection dbCon;

        public DataBaseAdaptor()
        {
            conStr = @"Data Source=DESKTOP-740KALD\SQLEXPRESS; Initial Catalog=ISS-DB; Integrated Security=true";
            dbCon = new SqlConnection(conStr);
        }

        public void openConnection()
        {
            dbCon.Open();
        }

        public void closeConnection()
        {
            dbCon.Close();
        }

        public SqlConnection GetConnection()
        {
            return dbCon;
        }

    }
}
