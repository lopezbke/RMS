using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RMS.Models;

namespace RMS.Controllers
{
    public class SuperUserController : Controller
    {
        // GET: SuperUser
        /*public ActionResult Index()
        {
            var model = new CreateTable();
            return View(model);
        }*/
        RMSEntities dbContext = new RMSEntities();
        public ActionResult SudoCreatetable()
        {
            var model = new CreateTable();
            return View(model);
        }

        [HttpPost]

        public ActionResult SudoCreateTable(string tableName, List<string> columnName, List<string> columnType)
        {
            
            Debug.WriteLine(tableName);
            int count = 0;
            string parameters = string.Empty;
            foreach (string elemment in columnName)
            {

                Debug.WriteLine(columnName[count]);
                Debug.WriteLine(columnType[count]);
                parameters = parameters + columnName[count] + " " + columnType[count] + ",";
                count++;
            }
            string sql = $"CREATE TABLE {tableName} ({parameters});";
            dbContext.Database.ExecuteSqlCommand(sql);
            return View();

        }
    }
}