using DiagnostisktProv.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList GetSelectList()
        {
            var categories = _context.ProductCategory.ToList();
            return new SelectList(categories, "ProductCategoryId", "ProductCategoryName");
        }
    }
}
