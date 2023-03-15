using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceApp
{
    public class Service1 : IService1, ICashierService1
    {
        public void DeleteCashier(int id)
        {
            CashierContext co = new CashierContext();
            var d = (from cas in co.Cashiers
                     where cas.cid == id
                     select cas).First();
            co.Cashiers.Remove(d);
            co.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            ItemContext io = new ItemContext();
            var c = (from it in io.Items
                     where it.iid == id
                     select it).First();
            io.Items.Remove(c);
            io.SaveChanges();
        }

        public IEnumerable<Cashier> GetCashiers()
        {
            List<Cashier> cli = new List<Cashier>();
            CashierContext co = new CashierContext();
            cli = co.Cashiers.ToList();
            return cli;
        }

        public IEnumerable<Item> GetItems()
        {
            List<Item> li = new List<Item>();
            ItemContext io = new ItemContext();
            li = io.Items.ToList();
            return li;
        }

        public void InsertCashier(Cashier cobj)
        {
            CashierContext co = new CashierContext();
            co.Cashiers.Add(cobj);
            co.SaveChanges();
        }

        public void InsertItem(Item iobj)
        {
            ItemContext io = new ItemContext();
            io.Items.Add(iobj);
            io.SaveChanges();
        }

        public void UpdateCashier(Cashier cobj)
        {
            CashierContext co = new CashierContext();
            var d = (from cas in co.Cashiers
                     where cas.cid == cobj.cid
                     select cas).First();
            d.cName = cobj.cName;
            d.cRole = cobj.cRole;
            co.SaveChanges();
        }

        public void UpdateItem(Item iobj)
        {
            ItemContext io = new ItemContext();
            var c = (from it in io.Items
                     where it.iid == iobj.iid
                     select it).First();
            c.iName = iobj.iName;
            c.iQuantity = iobj.iQuantity;
            c.iDesc = iobj.iDesc;
            io.SaveChanges();
        }
    }
}
