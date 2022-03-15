using Fiorello13.Data;
using Fiorello13.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello13.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Product> products = await _context.Products.Where(p=> p.IsDeleted==false)
                .Include(m => m.Category)
                .Include(m => m.Images)
                .OrderByDescending(m=> m.Id)
                .Take(8)
                .ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> LoadMore()
        {

            List<Product> products = await _context.Products.Where(p => p.IsDeleted == false)
               
                .OrderByDescending(m => m.Id)
                .Skip(4)
                .Take(4)
                .ToListAsync();
            return Json(products);
        }
    }
}
