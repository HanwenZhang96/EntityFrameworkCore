using EFCore.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    // 
    public class MyContext:DbContext
    {
        // 使用DbSet把数据库表和Model映射起来
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }

        // 数据库连接字符串,以下写法只适合教学，实际连接字符串不写在这里
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyEFCore;Trusted_Connection=True;");
            // 这个会直接生成到数据库
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MyEFCore;Data Source=DESKTOP-5VRS6ED");
        }

    }
}
