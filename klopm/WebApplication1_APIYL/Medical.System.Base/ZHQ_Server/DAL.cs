using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Medical.System.Model;
using Microsoft.Extensions.Options;
using Dapper;
using System.Linq;

namespace Medical.System.Server.ZHQ_Server
{
  public  class DAL
    {
        IDbConnection dbconn;
        public DAL(IOptions<ConnectionStrings> conn)
        {
            dbconn = new SqlConnection(conn.Value.Conn);
        }
       // 例子
        public List<T> GetStudent<T>()
        {
            string sql = "select * from Student";
            return dbconn.Query<T>(sql).ToList();

        }
    }
}
