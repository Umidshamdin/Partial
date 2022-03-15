using Fiorello13.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello13.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {


        }
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<SliderDetail> SliderDetails { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Gift_Video> Gift_Videos { get; set; }

        public DbSet<Experts> Experts { get; set; }
        public DbSet<Exspert_Image> Exspert_Images { get; set; }
      









    }
}
