using Divisima.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisima.DAL.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> opt):base(opt)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                ID = 1,
                NameSurName = "Emrehan Ağaçyetiştiren",
                LastLoginDate = DateTime.Now,
                LastLoginIP = "",
                UserName = "Ağaç",
                Password = "202cb962ac59075b964b07152d234b70"

            });

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Slide> Slide { get; set; }

    }
}
