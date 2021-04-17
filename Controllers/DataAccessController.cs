using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RMS.Controllers
{
    public class DataAccessController : Controller
    {
        RMSEntities dbcontext = new RMSEntities();
        // GET: DataAccess
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetTables() 
        {
            dbcontext
            return JsonResult();
        }
    }
}