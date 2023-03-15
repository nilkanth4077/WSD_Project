using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WCFServiceApp
{
    public class CashierContext : DbContext
    {
        public DbSet<Cashier> Cashiers { get; set; }
        public CashierContext() : base("MyAppCS")
        {

        }
    }
}