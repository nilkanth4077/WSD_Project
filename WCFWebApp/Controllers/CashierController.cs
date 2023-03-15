using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFWebApp.ServiceReference1;

namespace WCFWebApp.Controllers
{
    public class CashierController : Controller
    {
        public ActionResult getCashier()
        {
            CashierService1Client c = new CashierService1Client();
            List<Cashier> cli = c.GetCashiers().ToList();
            ViewBag.List = cli;
            return View();
        }
        public ActionResult insertCashier()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertCashier(Cashier cobj)
        {
            CashierService1Client i = new CashierService1Client();
            i.InsertCashier(cobj);
            return View();
        }
        public ActionResult updateCashier()
        {
            return View();
        }
        [HttpPost]
        public ActionResult updateCashier(Cashier cobj)
        {
            CashierService1Client i = new CashierService1Client();
            i.UpdateCashier(cobj);
            return View();
        }
        public ActionResult deleteCashier()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteCashier(int cid)
        {
            CashierService1Client i = new CashierService1Client();
            i.DeleteCashier(cid);
            return View();
        }
    }
}