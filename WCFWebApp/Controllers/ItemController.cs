using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFWebApp.ServiceReference1;

namespace WCFWebApp.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult getItem()
        {
            Service1Client i = new Service1Client();
            List<Item> ili = i.GetItems().ToList();
            ViewBag.List = ili;
            return View();
        }
        public ActionResult insertItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertItem(Item iobj)
        {
            Service1Client i = new Service1Client();
            i.InsertItem(iobj);
            return View();
        }
        public ActionResult updateItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult updateItem(Item iobj)
        {
            Service1Client i = new Service1Client();
            i.UpdateItem(iobj);
            return View();
        }
        public ActionResult deleteItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteItem(int iid)
        {
            Service1Client i = new Service1Client();
            i.DeleteItem(iid);
            return View();
        }
    }
}