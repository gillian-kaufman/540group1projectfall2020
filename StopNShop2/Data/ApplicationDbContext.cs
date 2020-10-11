using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StopNShop2.Models;

namespace StopNShop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StopNShop2.Models.Category> Category { get; set; }
        public DbSet<StopNShop2.Models.Customer> Customer { get; set; }
        public DbSet<StopNShop2.Models.Product> Product { get; set; }
        public DbSet<StopNShop2.Models.ProductReview> ProductReview { get; set; }
        public DbSet<StopNShop2.Models.ShoppingCart> ShoppingCart { get; set; }
    }
}
