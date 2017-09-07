using DiagnostisktProv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Data
{
    public class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context)
        {
            var tv = new ProductCategory { ProductCategoryName = "TV" };
            var dvd = new ProductCategory { ProductCategoryName = "DVD" };
            var vhs = new ProductCategory { ProductCategoryName = "VHS" };

            context.AddRange(tv, dvd, vhs);
            context.SaveChanges();
        }
    }
}
