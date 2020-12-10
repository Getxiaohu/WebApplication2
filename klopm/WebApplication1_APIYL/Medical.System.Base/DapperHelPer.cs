using System;
using System.Collections.Generic;
using System.Text;
using Medical.System.Model;
using Microsoft.Extensions.Options;

namespace Medical.System.Server
{
   public class DapperHelPer
    {
        public IOptions<ConnectionStrings> _conn;

        public DapperHelPer(IOptions<ConnectionStrings> conn)
        {
            _conn = conn;
        }
    }
}
