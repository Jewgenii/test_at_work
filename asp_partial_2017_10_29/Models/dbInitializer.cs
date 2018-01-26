using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_partial_2017_10_29.Models
{
    public class dbInitializer : DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                context.Products.Add(new Product() { Name = "car", Info = "1", Price = new Random().Next(100) });
                context.Products.Add(new Product() { Name = "cbs", Info = "1", Price = new Random().Next(100) });
                context.Products.Add(new Product() { Name = "camp", Info = "1", Price = new Random().Next(100) });
                context.Products.Add(new Product() { Name = "cross", Info = "1", Price = new Random().Next(100) });
            }

            context.SaveChanges();


            base.Seed(context);
        }
    }
}