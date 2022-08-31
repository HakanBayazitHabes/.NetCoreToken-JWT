using AuthServer.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Data
{
    public class AppDbContext:IdentityDbContext<UserApp,IdentityRole,string>
    {
        /// <summary>
        /// DbContextOptions classı DbContext'dan kalıtım alır
        /// </summary>
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<UserRefreshToken> userRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //IEntityTypeConfiguration implemente edilmiş classları bulur. Bulunan classlar buraya toplanır
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
