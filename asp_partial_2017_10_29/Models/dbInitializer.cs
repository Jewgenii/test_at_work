using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_partial_2017_10_29.Models
{
    public class dbInitializer : DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Products.Add(new Product() { Name = "car", Info = "1", Price = 122 });
            context.Products.Add(new Product() { Name = "cbs", Info = "1", Price = 333 });
            context.Products.Add(new Product() { Name = "camp", Info = "1", Price = 22 });
            context.Products.Add(new Product() { Name = "cross", Info = "1", Price = 44 });

            context.SaveChanges();


            base.Seed(context);
        }
    }
}