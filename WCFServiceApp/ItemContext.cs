using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WCFServiceApp
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public ItemContext() : base("MyAppCS")
        {

        }
    }
}