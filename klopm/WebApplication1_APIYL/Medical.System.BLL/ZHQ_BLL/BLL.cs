using System;
using System.Collections.Generic;
using System.Text;
using Medical.System.Model;
using Medical.System.Server;
using Microsoft.Extensions.Options;
using Medical.System.Server.ZHQ_Server;

namespace Medical.System.BLL.ZHQ_BLL
{
   public class BLL
    {
        DAL dal;
        public BLL(IOptions<ConnectionStrings> conn)
        {
            dal = new DAL(conn);
        }
        //例子
        public List<T> GetStudent<T>()
        {
           return dal.GetStudent<T>();
        }
    }
}
