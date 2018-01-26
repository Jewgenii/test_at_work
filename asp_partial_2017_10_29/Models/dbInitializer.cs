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
            context.Products.Add(new Product() { Name = "car", Info = "1", Price = 122 });
            context.Products.Add(new Product() { Name = "cbs", Info = "1", Price = 333 });
            context.Products.Add(new Product() { Name = "camp", Info = "1", Price = 22 });
            context.Products.Add(new Product() { Name = "cross", Info = "1", Price = 44 });

            context.Products.Add(new Product() { Name = "cbs1", Info = "1", Price = 333 });
            context.Products.Add(new Product() { Name = "camp2", Info = "1", Price = 22 });
            context.Products.Add(new Product() { Name = "cross3", Info = "1", Price = 44 });

            context.Products.Add(new Product() { Name = "cbs4", Info = "1", Price = 333 });
            context.Products.Add(new Product() { Name = "camp5", Info = "1", Price = 22 });
            context.Products.Add(new Product() { Name = "cross6", Info = "1", Price = 44 });

            context.Products.Add(new Product() { Name = "cbs7", Info = "1", Price = 333 });
            context.Products.Add(new Product() { Name = "camp8", Info = "1", Price = 22 });
            context.Products.Add(new Product() { Name = "cross9", Info = "1", Price = 44 });

            context.SaveChanges();


            base.Seed(context);
        }
    }
}