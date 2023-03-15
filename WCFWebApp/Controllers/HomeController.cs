using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFWebApp.ServiceReference1;

namespace WCFWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Item> item = new List<Item>();

            string cs = ConfigurationManager.ConnectionStrings["MyAppCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Items", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Item i1 = new Item();
                    i1.iName = rdr["iName"].ToString();
                    item.Add(i1);
                }

                SelectList list = new SelectList(item, "iName", "iName");
                ViewBag.DropDownList = list;
            }
            return View();
        }
    }
}