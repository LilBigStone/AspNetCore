using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Data.Models;
using ProjectApplication.Models;

namespace ProjectApplication.Data
{
    public class appDBcontent : IdentityDbContext<UserModel> {
        public appDBcontent(DbContextOptions<appDBcontent> options) : base(options)
        {

        }
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MilkProd> MilkProds { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopFav> ShopFav { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    
    }
}
