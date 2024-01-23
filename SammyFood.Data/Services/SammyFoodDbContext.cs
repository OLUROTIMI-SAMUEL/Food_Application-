using Microsoft.EntityFrameworkCore;
using SammyFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammyFood.Data.Services
{
    public class SammyFoodDbContext : DbContext
    {
        //public SammyFoodDbContext(DbContextOptions<SammyFoodDbContext> options) : base(options)
        //{
        //}
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
