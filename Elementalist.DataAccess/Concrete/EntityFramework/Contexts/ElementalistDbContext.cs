using Elementalist.Core.Entities.Concrete;
using Elementalist.DataAccess.Constants;
using Elementalist.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.DataAccess.Concrete.EntityFramework.Contexts
{
    public class ElementalistDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Parameters.ConnectionString);//(connectionString: @"Server=DESKTOP-U3CMHH9\SQLEXPRESS; Database=Elementalist; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
