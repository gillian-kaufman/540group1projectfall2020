using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoftwareEngineeringSilkRoad.Models;

namespace SoftwareEngineeringSilkRoad.Data
{
    public class SoftwareEngineeringSilkRoadContext : DbContext
    {
        public SoftwareEngineeringSilkRoadContext (DbContextOptions<SoftwareEngineeringSilkRoadContext> options)
            : base(options)
        {
        }

        public DbSet<SoftwareEngineeringSilkRoad.Models.Customer> Customer { get; set; }

        public DbSet<SoftwareEngineeringSilkRoad.Models.Product> Product { get; set; }

        public DbSet<SoftwareEngineeringSilkRoad.Models.ShoppingCart> ShoppingCart { get; set; }

        public DbSet<SoftwareEngineeringSilkRoad.Models.ProductReview> ProductReview { get; set; }

        public DbSet<SoftwareEngineeringSilkRoad.Models.WishList> WishList { get; set; }
    }
}
