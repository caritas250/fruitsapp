using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FruitsApp.Data;
using FruitsApp.Model;

namespace FruitsApp.Pages_ProductPage
{
    public class IndexModel : PageModel
    {
        private readonly FruitsApp.Data.ProductContext _context;

        public IndexModel(FruitsApp.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
