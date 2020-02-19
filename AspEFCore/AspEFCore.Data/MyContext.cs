using AspEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }
        //这里可以写表之间的配置关系
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasOne(x => x.Province).WithMany(x => x.Cities).HasForeignKey(x => x.ProvinceId);

            // 给 CityCompany 配置联合主键
            modelBuilder.Entity<CityCompany>()
                .HasKey(x => new { x.CityId, x.CompanyId });

            modelBuilder.Entity<CityCompany>()
                .HasOne(x => x.City).WithMany(x => x.CityCompanies).HasForeignKey(x => x.CityId);

            modelBuilder.Entity<CityCompany>()
                .HasOne(x => x.Company).WithMany(x => x.CityCompanies).HasForeignKey(x => x.CompanyId);

            modelBuilder.Entity<Mayor>()
                .HasOne(x => x.City).WithOne(x => x.Mayor).HasForeignKey<Mayor>(x => x.CityId);
        }
        // 使用DbSet把数据库表和Model映射起来
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CityCompany> CityCompanies { get; set; }
        public DbSet<Mayor> Mayors { get; set; }
    }
}
