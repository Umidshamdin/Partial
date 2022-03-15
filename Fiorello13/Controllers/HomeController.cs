using Fiorello13.Data;
using Fiorello13.Models;
using Fiorello13.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello13.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();

            List<Category> categories = await _context.Categories.ToListAsync();

            List<Product> products = await _context.Products
                .Include(m => m.Category)
                .Include(m => m.Images)
                .ToListAsync();

            Gift gift = await _context.Gifts.FirstOrDefaultAsync();

            Gift_Video gift_Video = await _context.Gift_Videos.FirstOrDefaultAsync();
            Experts experts = await _context.Experts.FirstOrDefaultAsync();

            List<Exspert_Image> exspert_Images = await _context.Exspert_Images.ToListAsync();

          


            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                Categories=categories,
                Products=products,
                Gift_Video=gift_Video,
                Experts=experts,
                Exspert_Images=exspert_Images,
                
               

                
              

            };

            return View(homeVM);
        }
    }
}
