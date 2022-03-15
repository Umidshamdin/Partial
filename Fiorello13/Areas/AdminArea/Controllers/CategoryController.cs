using Fiorello13.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello13.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.Where(m => m.IsDeleted==false).ToListAsync();
            return View(categories);
        }
        public IActionResult Detail(int Id)
        {
            return Json(new
            {
                action="Detail"
            });
        }
        public IActionResult Edit(int Id)
        {
            return Json(new
            {
                action = "Edit"
            });
        }
        public IActionResult Delete(int Id)
        {
            return Json(new
            {
                action = "Delete"
            });
        }
    }
}
