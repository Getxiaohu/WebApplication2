using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Medical.System.Model;
using Medical.System.BLL.ZHQ_BLL;
using Microsoft.Extensions.Options;

namespace Medical.System_APIYL.Controllers
{
    public class MBController : Controller
    {
        BLL bll;
        public MBController(IOptions<ConnectionStrings> conn)
        {
            bll = new BLL(conn);
        }
        /// <summary>
        /// 例子
        /// </summary>
        /// <returns></returns>
        //public IActionResult Index()
        //{
        //    var list = bll.GetStudent<T>();
        //    return View();
        //}
    }
}
